using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class CustomerCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ICustomerLogic customerLogic;
        public int ID { set { Id = value; } }
        private int? Id;
        public CustomerCreationForm(ICustomerLogic customerLogic)
        {
            InitializeComponent();
            this.customerLogic = customerLogic;
        }

        private void CustomerCreationForm_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                try
                {
                    var customer = customerLogic.Read(new CustomerBindingModel { ID = Id })?[0];
                    if (customer != null)
                    {
                        firstNameTextBox.Text = customer.FirstName;
                        lastNameTextBox.Text = customer.LastName;
                        phoneTextBox.Text = customer.PhoneNumber;
                        emailTextBox.Text = customer.Email;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Customer loading error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                MessageBox.Show(
                    "Fill First Name",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Last Name",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Phone Number",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                customerLogic.CreateOrUpdate(new CustomerBindingModel
                {
                    ID = Id,
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    PhoneNumber = phoneTextBox.Text,
                    Email = emailTextBox.Text
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
                    "Customer saving error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
