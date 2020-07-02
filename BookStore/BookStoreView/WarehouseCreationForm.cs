using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class WarehouseCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IWarehouseLogic warehouseLogic;
        private readonly IAddressLogic addressLogic;
        public int ID { set { Id = value; } }
        private int? Id;
        public WarehouseCreationForm(IWarehouseLogic warehouseLogic, IAddressLogic addressLogic)
        {
            InitializeComponent();
            this.warehouseLogic = warehouseLogic;
            this.addressLogic = addressLogic;
        }

        private void WarehouseCreationForm_Load(object sender, EventArgs e)
        {
            LoadAddresses();
            if (Id.HasValue)
            {
                try
                {
                    var warehouse = warehouseLogic.Read(new WarehouseBindingModel { ID = Id })?[0];
                    if (warehouse != null)
                    {
                        nameTextBox.Text = warehouse.Name;
                        capacityTextBox.Text = warehouse.Capacity.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Warehouse loading error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void LoadAddresses()
        {
            try
            {
                List<AddressViewModel> addressesList = addressLogic.Read(null);
                if (addressesList != null)
                {
                    addressComboBox.DisplayMember = "Street";
                    addressComboBox.ValueMember = "ID";
                    addressComboBox.DataSource = addressesList;
                    addressComboBox.SelectedItem = null;
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

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Name",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(capacityTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Capacity",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (addressComboBox.SelectedValue == null)
            {
                MessageBox.Show(
                    "Choose address",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {
                warehouseLogic.CreateOrUpdate(new WarehouseBindingModel
                {
                    ID = Id,
                    Name = nameTextBox.Text,
                    Capacity = Convert.ToInt32(capacityTextBox.Text),
                    AddressID = Convert.ToInt32(addressComboBox.SelectedValue)
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
                    "Warehouse saving error",
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
