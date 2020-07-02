using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class BookCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IBookLogic bookLogic;
        private readonly IAuthorLogic authorLogic;
        private readonly IPublishingLogic publishingLogic;
        public int ID { set { Id = value; } }
        private int? Id;
        public BookCreationForm(IBookLogic bookLogic, IAuthorLogic authorLogic, IPublishingLogic publishingLogic)
        {
            InitializeComponent();
            this.bookLogic = bookLogic;
            this.authorLogic = authorLogic;
            this.publishingLogic = publishingLogic;
        }

        private void BookCreationForm_Load(object sender, EventArgs e)
        {
            LoadAuthors();
            LoadPublishings();
            if (Id.HasValue)
            {
                try
                {
                    var book = bookLogic.Read(new BookBindingModel { ID = Id })?[0];
                    if (book != null)
                    {
                        titleTextBox.Text = book.Title;
                        genreTextBox.Text = book.Genre;
                        yearTextBox.Text = book.PublicationYear.ToString();
                        costTextBox.Text = book.CostOfPurchase.ToString();
                        priceTextBox.Text = book.Price.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Book loading error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void LoadAuthors()
        {
            try
            {
                List<AuthorViewModel> authorsList = authorLogic.Read(null);
                if (authorsList != null)
                {
                    authorComboBox.DisplayMember = "LastName";
                    authorComboBox.ValueMember = "ID";
                    authorComboBox.DataSource = authorsList;
                    authorComboBox.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Authors list loading error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadPublishings()
        {
            try
            {
                List<PublishingViewModel> publishingsList = publishingLogic.Read(null);
                if (publishingsList != null)
                {
                    publishingComboBox.DisplayMember = "Name";
                    publishingComboBox.ValueMember = "ID";
                    publishingComboBox.DataSource = publishingsList;
                    publishingComboBox.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Publishings list loading error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Title",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(genreTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Genre",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(yearTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Year",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(costTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Cost",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Price",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (authorComboBox.SelectedValue == null)
            {
                MessageBox.Show(
                    "Choose author",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (publishingComboBox.SelectedValue == null)
            {
                MessageBox.Show(
                    "Choose publishing",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            try
            {
                bookLogic.CreateOrUpdate(new BookBindingModel
                {
                    ID = Id,
                    Title = titleTextBox.Text,
                    Genre = genreTextBox.Text,
                    PublicationYear = Convert.ToInt32(yearTextBox.Text),
                    CostOfPurchase = Convert.ToDecimal(costTextBox.Text),
                    Price = Convert.ToDecimal(priceTextBox.Text),
                    AuthorID = Convert.ToInt32(authorComboBox.SelectedValue),
                    PublishingID = Convert.ToInt32(publishingComboBox.SelectedValue)
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
                    "Book saving error",
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
