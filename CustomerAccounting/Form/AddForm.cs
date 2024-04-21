using CustomerAccounting.Class;

namespace CustomerAccounting.Form
{
    public class AddForm : System.Windows.Forms.Form
    {
        private TextBox? _nameTextBox;
        private TextBox? _telNamber;
        private TextBox? _address;
        private TextBox? _orderName;
        private Button? _buttonAddClient;
                    
        public AddForm()
        {
            Text = "Добавление клиентов";
            Size = new Size(500, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadForm();
        }

        private void LoadForm()
        {
            _nameTextBox     = addTexBox("Имя клиента.", new Point(0, 20));
            _telNamber       = addTexBox("Телефон.", new Point(0, 40));
            _address         = addTexBox("Адрес.", new Point(0, 60));
            _orderName = addTexBox("Название изделия.", new Point(0, 80));
            _buttonAddClient = AddButton("Добавить клиента.", new Point(50, 120), new Size(100,40));

            Controls.Add(_orderName);
            Controls.Add(_nameTextBox);
            Controls.Add(_telNamber);
            Controls.Add(_address);
            Controls.Add(_buttonAddClient);

            _buttonAddClient.Click += AddClienInList!;
        }

        private void AddClienInList(object sender, EventArgs e)
        {
            var name = _nameTextBox.Text;
            var tel = _telNamber.Text;
            var address = _address.Text;
            var orderName = _orderName.Text;

            var client = new Client(name, tel, address, orderName);
            ListClients.AddClients(client);

            DialogResult result = MessageBox.Show("Хотите добавить еще 1 клиента ??", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { }
            else this.Close();
        }

        private TextBox addTexBox(string nameTextBox, Point location)
        {
            TextBox textBox = new TextBox();
            textBox.Size = new Size(200, 20);
            textBox.Location = location;    
            textBox.Text = nameTextBox;
            return textBox;
        }
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
    }
}
