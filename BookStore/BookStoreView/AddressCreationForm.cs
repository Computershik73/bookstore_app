using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class AddressCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IAddressLogic addressLogic;
        public int ID { set { Id = value; } }
        private int? Id;

        public AddressCreationForm(IAddressLogic addressLogic)
        {
            InitializeComponent();
            this.addressLogic = addressLogic;
        }

        private void AddressCreationForm_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                try
                {
                    var address = addressLogic.Read(new AddressBindingModel { ID = Id })?[0];
                    if (address != null)
                    {
                        countryTextBox.Text = address.Country;
                        stateTextBox.Text = address.State;
                        cityTextBox.Text = address.City;
                        streetTextBox.Text = address.Street;
                        buildingTextBox.Text = address.Building;
                        postalCodeTextBox.Text = address.ZipPostalCode.ToString();               
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Address list loading error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(countryTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Country",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(stateTextBox.Text))
            {
                MessageBox.Show(
                    "Fill State",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                MessageBox.Show(
                    "Fill City",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(streetTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Street",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(buildingTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Building",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(postalCodeTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Postal Code",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                addressLogic.CreateOrUpdate(new AddressBindingModel
                {
                    ID = Id,
                    Country = countryTextBox.Text,
                    State = stateTextBox.Text,
                    City = cityTextBox.Text,
                    Street = streetTextBox.Text,
                    Building = buildingTextBox.Text,
                    ZipPostalCode = Convert.ToInt32(postalCodeTextBox.Text)
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
                    "Address saving error",
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
