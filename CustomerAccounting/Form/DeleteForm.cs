using CustomerAccounting.Class;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CustomerAccounting.Form
{
    public class DeleteForm : System.Windows.Forms.Form
    {
        private const int _indent = 50;

        private int _y = 20;

        private List<CheckBox> checkBoxes = new List<CheckBox>();

        private Button _btnDelete;
        public DeleteForm()
        {
            Text = "Удаление клиентов.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            // Создание панели с прокруткой
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Height = Screen.PrimaryScreen.Bounds.Height;
            panel.AutoScroll = true;

            this.Controls.Add(panel);
            DeleteClients(panel);

            this.Height = Screen.PrimaryScreen.Bounds.Height + _indent;
            this.Width = panel.PreferredSize.Width + _indent;

            // Создание кнопки удаления
            Button deleteButton = new Button();
            deleteButton.Text = "Удалить выбранных клиентов";
            _btnDelete = deleteButton;
            _btnDelete.AutoSize = true; 
            _btnDelete.Dock = DockStyle.Top;
             this.Controls.Add(_btnDelete);
            _btnDelete.Click += DeleteButton_Click; // Обработчик события нажатия на кнопку
            
        }

        private void DeleteClients(Panel panel)
        {
            int number = 1;
           
            for (int i = 0; i < ListClients._clients.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Location = new Point(20, _y);
                checkBox.AutoSize = true;
                checkBox.Text = number +"\n"+ ListClients._clients[i].ToString();
                checkBox.Font = new System.Drawing.Font(checkBox.Font.FontFamily, 20); // Увеличиваем размер шрифта до 20
                checkBoxes.Add(checkBox); // Добавляем флажок в список
                panel.Controls.Add(checkBox); // Добавляем флажок на панель
                _y += checkBox.Height + 20; // Увеличиваем y для следующего флажка
                number++;
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            for (int i = checkBoxes.Count - 1; i >= 0; i--)
            {
                if (checkBoxes[i].Checked)
                {
                    // Удаляем клиента из списка
                    ListClients.DeleteClients(ListClients._clients[i]);
                    // Удаляем флажок из списка и с панели
                    checkBoxes[i].Dispose();
                    checkBoxes.RemoveAt(i);
                }
            }
            
        }

    }
}
