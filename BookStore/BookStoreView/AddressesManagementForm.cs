using BookStoreBusinessLogic.Interfaces;
using BookStoreBusinessLogic.BindingModels;
using System;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class AddressesManagementForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IAddressLogic addressLogic;
        public AddressesManagementForm(IAddressLogic addressLogic)
        {
            InitializeComponent();
            this.addressLogic = addressLogic;
        }

        private void AddressesManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var addressesList = addressLogic.Read(null);
                if (addressesList != null)
                {
                    addressesGridView.DataSource = addressesList;
                    addressesGridView.Columns[0].Visible = false;
                    addressesGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Addresses list loading error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddressCreationForm form = Container.Resolve<AddressCreationForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (addressesGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<AddressCreationForm>();
                form.ID = Convert.ToInt32(addressesGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (addressesGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Are you sure?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int addressID = Convert.ToInt32(addressesGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        addressLogic.Delete(new AddressBindingModel { ID = addressID });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Address deleting error",
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
