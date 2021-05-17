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
    public partial class Admin : Form
    {
        public Model1 db = new Model1();
        public Сотрудники user{ get; set; }
        public Admin()
        {
            InitializeComponent();
            сотрудникиBindingSource.DataSource.ToString();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            номерMaskedTextBox.Mask = "+7(000)000-0000";
            сотрудникиBindingSource.AddNew();
        }
        private void Register_Click(object sender, EventArgs e)
        {
            if (iD_СотрудникаTextBox.Text == "" || логинTextBox.Text == "" || парольTextBox.Text == "" || рольTextBox.Text == "" || номерMaskedTextBox.Mask == "" || фИОTextBox.Text == "")
            {
                MessageBox.Show("Одно из важных полей не заполнено!");
                return;
            }
            user = (Сотрудники)сотрудникиBindingSource.List[0];
            db.Сотрудники.Add(user);
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            
            //Сотрудники lich = new Сотрудники();
            //try
            //{
            //    lich.ID_Сотрудника = Convert.ToInt32(iD_СотрудникаTextBox.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Неверные данные" + ex.Message);
            //    return;
            //}
            //lich.ФИО = фИОTextBox.Text;
            //lich.Номер = номерTextBox.Text;
            //lich.Логин = логинTextBox.Text;
            //lich.Пароль = парольTextBox.Text;
            //lich.Пол = comboBox1.Text;
            //lich.Роль = рольTextBox.Text;
            ////lich.Фото = фотоPictureBox;
            //db.Сотрудники.Add(lich);
            //db.SaveChanges();
            //DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = " Выберите фото сотрудника ";
            ofd.InitialDirectory = @" Z:\2020_2021 учебный год\22 ИС\УП\Ихебинике\10 - Аренда ТЦ (задание квал отбор 2019)\Ресурсы\Image Сотрудники";
            ofd.Filter = " Файлы JPG, GIF, PNG| *.jpg; *.gif; *.png | Все файлы(*.*) | *.* ";
            DialogResult rc = ofd.ShowDialog();
            if (rc == DialogResult.OK)
            {
                // показываем выбранный файл в PictureBox
                фотоPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
