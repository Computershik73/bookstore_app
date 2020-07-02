using BookStoreBusinessLogic.Interfaces;
using BookStoreBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace BookStoreView
{
    public partial class BookAddingForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int ID
        {
            get { return Convert.ToInt32(bookComboBox.SelectedValue); }
            set { bookComboBox.SelectedValue = value; }
        }
        public string ComponentName { get { return bookComboBox.Text; } }
        public int Count
        {
            get { return Convert.ToInt32(countTextBox.Text); }
            set { countTextBox.Text = value.ToString(); }
        }
        public BookAddingForm(IBookLogic bookLogic)
        {
            InitializeComponent();
            List<BookViewModel> list = bookLogic.Read(null);
            if (list != null)
            {
                bookComboBox.DisplayMember = "Title";
                bookComboBox.ValueMember = "ID";
                bookComboBox.DataSource = list;
                bookComboBox.SelectedItem = null;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(countTextBox.Text))
            {
                MessageBox.Show(
                    "Fill Count",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (bookComboBox.SelectedValue == null)
            {
                MessageBox.Show(
                    "Choose book",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
