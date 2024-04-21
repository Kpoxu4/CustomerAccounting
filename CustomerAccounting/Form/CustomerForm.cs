using CustomerAccounting.Class;
using CustomerAccounting.Form;
using System.Windows.Forms;

namespace CustomerAccounting
{
    public partial class CustomerForm : System.Windows.Forms.Form
    {
        private Button _addButton;
        private Button _deleteButton;
        private Button _showClients;
        private Label _header;
        
        //private Form _formDelete;

        public CustomerForm()
        {
            ListClients listClients = new ListClients();    
            Text = "Учет клиентов мебельного производства";
            this.Size = new Size(500, 250);
            this.StartPosition = FormStartPosition.Manual;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadForm();
        }

        //первый Экран
        private void LoadForm()
        {
            _header = AddHeader("Учет клиентов мебельного производства", new Point(100, 30), 10);
            _addButton = AddButton("Добавить клиента.", new Point(100, 70), new Size(100, 50),Color.Cyan);
            _showClients = AddButton("Список клиентов.", new Point(200, 70), new Size(100, 50), Color.Cyan);
            _deleteButton = AddButton("Удалить клиента.", new Point(300,70), new Size(100, 50), Color.Cyan);

            Controls.Add(_header);
            Controls.Add(_deleteButton);
            Controls.Add(_addButton);
            Controls.Add(_showClients);

            _addButton.Click += AddClick!;
            _showClients.Click += showClient!;
            _deleteButton.Click += DeleteClic!;
        }

        private void AddClick(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }
        private void showClient(object sender, EventArgs e)
        {
            ShowForm showForm = new ShowForm();
            showForm.Show();
        }

        private void DeleteClic(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

   
        // метод добавление новой кнопки на  1 экран.
        private Button AddButton(string nameButton, Point location, Size size, Color color = default(Color))
        {
            var newButton = new Button()
            {
                BackColor = color,
                Size = size,
                Text = nameButton,
                Location = location

            };
            return newButton;
        }
        // метод добавления Заголовка
        private Label AddHeader (string name, Point location, int sizeFontFamily)
        {
            Label header = new Label();
            header.Location = new System.Drawing.Point(location.X, location.Y);
            header.Text = name;
            header.AutoSize = true;
            header.Font = new Font(header.Font.FontFamily, sizeFontFamily);
            return header;  
        }
        private System.Windows.Forms.Form AddNewForm(string  name)
        {
            var newForm = new System.Windows.Forms.Form();
            newForm.AutoSize = true;
            newForm.Text =  name;
            newForm.Show();
            return newForm;
        }
    }
}
