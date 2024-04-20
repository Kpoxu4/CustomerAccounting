

namespace CustomerAccounting
{
    public partial class CustomerForm : Form
    {
        private Button _addButton;
        private Button _deleteButton;
        public CustomerForm()
        {
            InitializeComponent();
            Text = "Учет клиентов мебельного производства";
            Size = new Size(500, 250);
            LoadForm();
        }

        //первый Экран
        private void LoadForm()
        {
            Label nameProgram = new Label(); 
            nameProgram.Location = new System.Drawing.Point(100, 30);
            nameProgram.Text = "Учет клиентов мебельного производства";
            nameProgram.AutoSize = true;
            nameProgram.Font = new Font(nameProgram.Font.FontFamily, 10);


            _addButton = AddButton("Добавить клиента.", new Point(130, 70));
            _deleteButton = AddButton("Удалить клиента.", new Point(230,70));

            Controls.Add(nameProgram);
            Controls.Add(_deleteButton);
            Controls.Add(_addButton);
        }

        // метод добавление новой кнопки на  1 экран.
        private Button AddButton(string nameButton, Point size)
        {
            var newButton = new Button()
            {
                BackColor = Color.DodgerBlue,
                Size = new Size(100, 50),
                Text = nameButton,
                Location = size

            };
            return newButton;
        }
    }
}
