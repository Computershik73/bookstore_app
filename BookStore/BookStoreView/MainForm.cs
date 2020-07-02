using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.BusinessLogic;
using BookStoreBusinessLogic.ViewModels;
using BookStoreBusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly MainLogic mainLogic;
        private readonly IOrderLogic orderLogic;
        public MainForm(MainLogic mainLogic, IOrderLogic orderLogic)
        {
            InitializeComponent();
            this.mainLogic = mainLogic;
            this.orderLogic = orderLogic;
        }

        private void LoadOrders()
        {
            try
            {
                List<OrderViewModel> ordersList = orderLogic.Read(null);
                if (ordersList != null)
                {
                    ordersGridView.DataSource = ordersList;
                    ordersGridView.Columns[0].Visible = false;
                    ordersGridView.Columns[1].Visible = false;
                    ordersGridView.Columns[5].Visible = false;
                    ordersGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Orders loading error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AddressesManagementForm>();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void WarehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<WarehousesManagementForm>();
            form.ShowDialog();
        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<BooksManagementForm>();
            form.ShowDialog();
        }

        private void AuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AuthorsManagementForm>();
            form.ShowDialog();
        }

        private void PublishingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<PublishingsManagementForm>();
            form.ShowDialog();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<CustomersManagementForm>();
            form.ShowDialog();
        }

        private void StartPreparingButton_Click(object sender, EventArgs e)
        {
            if (ordersGridView.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value);
                try
                {
                    mainLogic.StartPreparingAnOrder(new ChangeOrderStatusBindingModel { OrderID = ID });
                    LoadOrders();
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
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                mainLogic.CompleteOrder(new ChangeOrderStatusBindingModel { OrderID = ID });
                LoadOrders();
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

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                mainLogic.ConfirmOrder(new ChangeOrderStatusBindingModel { OrderID = ID });
                LoadOrders();
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

        private void GetPaidButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ordersGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                mainLogic.PayOrder(new ChangeOrderStatusBindingModel { OrderID = ID });
                LoadOrders();
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

        private void RefreshOrdersButton_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<OrderCreationForm>();
            form.ShowDialog();
            LoadOrders();
        }
    }
}
