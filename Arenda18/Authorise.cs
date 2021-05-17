using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arenda18
{
    public partial class Authorise : Form
    {
        public static Authorise FORMA { get; set; }
        public static Сотрудники USER { get; set; }
        Model1 db = new Model1();
        public Authorise()
        {
            InitializeComponent();
        }
        //проверка на ввод только  букв и цифр, и backspace
        private void парольTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        //проверка на ввод только  букв и цифр, и backspace
        private void логинTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 64 && e.KeyChar != 46 && e.KeyChar != 95)
                e.Handled = true;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (логинTextBox.Text == "" || парольTextBox.Text == "")
            {
                MessageBox.Show("Нужно ввести логин и пароль!");
                return;
            }
            //поиск уч. записи в БД
            foreach (Сотрудники usr in db.Сотрудники)
            {
                //если данные найдены запускается одна из следующих форм
                if ((usr != null) && (usr.Пароль == парольTextBox.Text))
                {
                    USER = usr;
                    FORMA = this;
                    //форма Адимна
                    if (usr.Роль == "Администратор")
                    {
                        Admin frm = new Admin();
                        frm.db = db;
                        DialogResult dr = frm.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            сотрудникиBindingSource.DataSource = db.Сотрудники.ToList();
                        }
                        this.Hide();
                    }
                    //форма менеджера А
                    else if (usr.Роль == "Менеджер А")
                    {
                        ManagerA frm = new ManagerA();
                        frm.Show();
                        this.Hide();
                    }
                    //форма менеджера С
                    else if (usr.Роль == "Менеджер С")
                    {
                        ManagerC frm = new ManagerC();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Роли {usr.Роль} в системе нет!");
                        return;
                    }
                }
            }
        }
    }



}


