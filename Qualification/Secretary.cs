using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qualification
{
    public partial class Secretary : Form
    {
        public Secretary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Secretary_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet10.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter2.Fill(this.qualificationDataSet10.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet9.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter1.Fill(this.qualificationDataSet9.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet8.Табель_студентов". При необходимости она может быть перемещена или удалена.
            this.табель_студентовTableAdapter1.Fill(this.qualificationDataSet8.Табель_студентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet7.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.qualificationDataSet7.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet6.Табель_студентов". При необходимости она может быть перемещена или удалена.
            this.табель_студентовTableAdapter.Fill(this.qualificationDataSet6.Табель_студентов);

        }
    }
}
