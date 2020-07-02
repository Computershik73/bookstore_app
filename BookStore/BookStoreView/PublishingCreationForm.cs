using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class PublishingCreationForm : Form
    {
        public new IUnityContainer Container { get; set; }
        private readonly IPublishingLogic publishingLogic;
        public int ID { set { Id = value; } }
        private int? Id;
        public PublishingCreationForm(IPublishingLogic publishingLogic)
        {
            InitializeComponent();
            this.publishingLogic = publishingLogic;
        }

        private void PublishingCreationForm_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                try
                {
                    var publishing = publishingLogic.Read(new PublishingBindingModel { ID = Id })?[0];
                    if (publishing != null)
                    {
                        nameTextBox.Text = publishing.Name;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "PublishingS loading error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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
            try
            {
                publishingLogic.CreateOrUpdate(new PublishingBindingModel
                {
                    ID = Id,
                    Name = nameTextBox.Text
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
                    "Publishing saving error",
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
