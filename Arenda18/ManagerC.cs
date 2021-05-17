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
    public partial class ManagerC : Form
    {
        Model1 db = new Model1();
        public ManagerC()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Сотрудники lich = (Сотрудники)сотрудникиBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить данные пациента? " + lich.ID_Сотрудника.ToString(),
                "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Сотрудники.Remove(lich);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                сотрудникиBindingSource.DataSource = db.Сотрудники.ToList();
            }
        }
    }
}
