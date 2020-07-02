using BookStoreBusinessLogic.Interfaces;
using BookStoreBusinessLogic.BindingModels;
using System;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class CustomersManagementForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ICustomerLogic customerLogic;
        public CustomersManagementForm(ICustomerLogic customerLogic)
        {
            InitializeComponent();
            this.customerLogic = customerLogic;
        }

        private void CustomersManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var customersList = customerLogic.Read(null);
                if (customersList != null)
                {
                    customersGridView.DataSource = customersList;
                    customersGridView.Columns[0].Visible = false;
                    customersGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "customers list loading error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CustomerCreationForm form = Container.Resolve<CustomerCreationForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (customersGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<AddressCreationForm>();
                form.ID = Convert.ToInt32(customersGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (customersGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Are you sure?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int customerID = Convert.ToInt32(customersGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        customerLogic.Delete(new CustomerBindingModel { ID = customerID });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Customer deleting error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
