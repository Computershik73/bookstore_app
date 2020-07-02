using BookStoreBusinessLogic.Interfaces;
using BookStoreBusinessLogic.BindingModels;
using System;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class PublishingsManagementForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IPublishingLogic publishingLogic;
        public PublishingsManagementForm(IPublishingLogic publishingLogic)
        {
            InitializeComponent();
            this.publishingLogic = publishingLogic;
        }

        private void PublishingsManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var publishingsList = publishingLogic.Read(null);
                if (publishingsList != null)
                {
                    publishingsGridView.DataSource = publishingsList;
                    publishingsGridView.Columns[0].Visible = false;
                    publishingsGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "publishings list loading error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            PublishingCreationForm form = Container.Resolve<PublishingCreationForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (publishingsGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<AddressCreationForm>();
                form.ID = Convert.ToInt32(publishingsGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (publishingsGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Are you sure?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int publishingID = Convert.ToInt32(publishingsGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        publishingLogic.Delete(new PublishingBindingModel { ID = publishingID });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Publishing deleting error",
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
