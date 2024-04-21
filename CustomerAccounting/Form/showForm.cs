using CustomerAccounting.Class;
using System.Text;

namespace CustomerAccounting.Form
{
    public class ShowForm : System.Windows.Forms.Form
    {
        private const int _indent = 1;
        public ShowForm()
        {
            Text = "Список клиентов.";
            this.StartPosition = FormStartPosition.CenterScreen;
            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);

            ShowClients(panel);
            this.Height = Screen.PrimaryScreen.Bounds.Height + _indent;
            this.Width = panel.PreferredSize.Width + _indent;
        }

        private void ShowClients(Panel panel)
        {

            Label myLabel = new Label();
            myLabel.Location = new Point(10, 10);
            myLabel.AutoSize = true;
            myLabel.Font = new Font(myLabel.Font.FontFamily, 20); // Увеличиваем размер шрифта до 20
            myLabel.ForeColor = Color.DarkKhaki; // Изменяем цвет текста на красный
            myLabel.Text = ListClients.ShowClients().ToString();

            panel.Controls.Add(myLabel);
        }
    }
}
