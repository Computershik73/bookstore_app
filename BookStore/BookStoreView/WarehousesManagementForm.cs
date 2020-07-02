using BookStoreBusinessLogic.Interfaces;
using BookStoreBusinessLogic.BindingModels;
using System;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class WarehousesManagementForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IWarehouseLogic warehouseLogic;
        public WarehousesManagementForm(IWarehouseLogic warehouseLogic)
        {
            InitializeComponent();
            this.warehouseLogic = warehouseLogic;
        }

        private void WarehousesManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var warehousesList = warehouseLogic.Read(null);
                if (warehousesList != null)
                {
                    warehousesGridView.DataSource = warehousesList;
                    warehousesGridView.Columns[0].Visible = false;
                    warehousesGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Warehouses list loading error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            WarehouseCreationForm form = Container.Resolve<WarehouseCreationForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (warehousesGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<AddressCreationForm>();
                form.ID = Convert.ToInt32(warehousesGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (warehousesGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Are you sure?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int warehouseID = Convert.ToInt32(warehousesGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        warehouseLogic.Delete(new WarehouseBindingModel { ID = warehouseID });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Warehouse deleting error",
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
