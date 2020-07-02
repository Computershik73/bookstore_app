using BookStoreBusinessLogic.Interfaces;
using BookStoreBusinessLogic.BindingModels;
using System;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class BooksManagementForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IBookLogic bookLogic;
        public BooksManagementForm(IBookLogic bookLogic)
        {
            InitializeComponent();
            this.bookLogic = bookLogic;
        }

        private void BooksManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var booksList = bookLogic.Read(null);
                if (booksList != null)
                {
                    booksGridView.DataSource = booksList;
                    booksGridView.Columns[0].Visible = false;
                    booksGridView.Columns[4].Visible = false;
                    booksGridView.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "books list loading error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            BookCreationForm form = Container.Resolve<BookCreationForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (booksGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<AddressCreationForm>();
                form.ID = Convert.ToInt32(booksGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (booksGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(
                    "Are you sure?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int bookID = Convert.ToInt32(booksGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        bookLogic.Delete(new BookBindingModel { ID = bookID });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Book deleting error",
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
