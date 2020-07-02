using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class AuthorCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IAuthorLogic authorLogic;
        public int ID { set { Id = value; } }
        private int? Id;
        public AuthorCreationForm(IAuthorLogic authorLogic)
        {
            InitializeComponent();
            this.authorLogic = authorLogic;
        }

        private void AuthorCreationForm_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                try
                {
                    var author = authorLogic.Read(new AuthorBindingModel { ID = Id })?[0];
                    if (author != null)
                    {
                        firstNameTextBox.Text = author.FirstName;
                        lastNameTextBox.Text = author.LastName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Author list loading error",
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
            try
            {
                authorLogic.CreateOrUpdate(new AuthorBindingModel
                {
                    ID = Id,
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text
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
                    "Author saving error",
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
