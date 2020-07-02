using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.ViewModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreBusinessLogic.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class OrderCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ICustomerLogic customerLogic;
        private readonly MainLogic mainLogic;
        private Dictionary<int, (string, int)> orderBooks;

        public OrderCreationForm(ICustomerLogic customerLogic, MainLogic mainLogic)
        {
            InitializeComponent();
            this.customerLogic = customerLogic;
            this.mainLogic = mainLogic;
        }

        private void OrderCreationForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            orderBooks = new Dictionary<int, (string, int)>();
        }

        private void LoadCustomers()
        {
            try
            {
                List<CustomerViewModel> customersList = customerLogic.Read(null);
                if (customersList != null)
                {
                    customerComboBox.DisplayMember = "PhoneNumber";
                    customerComboBox.ValueMember = "ID";
                    customerComboBox.DataSource = customersList;
                    customerComboBox.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Customers loading error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadBooks()
        {
            try
            {
                if (orderBooks != null)
                {
                    booksGridView.Rows.Clear();
                    foreach (var orderBook in orderBooks)
                    {
                        booksGridView.Rows.Add(new object[] {
                            orderBook.Key,
                            orderBook.Value.Item1,
                            orderBook.Value.Item2
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Books Loading error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddComponentButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<BookAddingForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (orderBooks.ContainsKey(form.ID))
                {
                    orderBooks[form.ID] = (form.ComponentName, form.Count);
                }
                else
                {
                    orderBooks.Add(form.ID, (form.ComponentName, form.Count));
                }
                LoadBooks();
            }
        }

        private void UpdateComponentButton_Click(object sender, EventArgs e)
        {
            if (booksGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<BookAddingForm>();
                int ID = Convert.ToInt32(booksGridView.SelectedRows[0].Cells[0].Value);
                form.ID = ID;
                form.Count = orderBooks[ID].Item2;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    orderBooks[form.ID] = (form.ComponentName, form.Count);
                    LoadBooks();
                }
            }
        }

        private void DeleteComponentButton_Click(object sender, EventArgs e)
        {
            if (booksGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Are you sure?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        orderBooks.Remove(Convert.ToInt32(booksGridView.SelectedRows[0].Cells[0].Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    LoadBooks();
                }
            }
        }

        private void RefreshComponentsButton_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedValue == null)
            {
                MessageBox.Show(
                    "Choose customer",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (orderBooks == null || orderBooks.Count == 0)
            {
                MessageBox.Show(
                    "Choose Books",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                mainLogic.CreateOrder(new OrderBindingModel
                {
                    CustomerID = Convert.ToInt32(customerComboBox.SelectedValue),
                    Books = orderBooks
                });
                MessageBox.Show(
                    "Successfully saved",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void СancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
