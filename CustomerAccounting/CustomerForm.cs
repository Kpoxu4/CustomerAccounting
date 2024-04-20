

namespace CustomerAccounting
{
    public partial class CustomerForm : Form
    {
        private Button _addButton;
        private Button _deleteButton;
        public CustomerForm()
        {
            InitializeComponent();
            Text = "���� �������� ���������� ������������";
            Size = new Size(500, 250);
            LoadForm();
        }

        //������ �����
        private void LoadForm()
        {
            Label nameProgram = new Label(); 
            nameProgram.Location = new System.Drawing.Point(100, 30);
            nameProgram.Text = "���� �������� ���������� ������������";
            nameProgram.AutoSize = true;
            nameProgram.Font = new Font(nameProgram.Font.FontFamily, 10);


            _addButton = AddButton("�������� �������.", new Point(130, 70));
            _deleteButton = AddButton("������� �������.", new Point(230,70));

            Controls.Add(nameProgram);
            Controls.Add(_deleteButton);
            Controls.Add(_addButton);
        }

        // ����� ���������� ����� ������ ��  1 �����.
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
