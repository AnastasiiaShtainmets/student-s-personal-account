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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet13.Студент1". При необходимости она может быть перемещена или удалена.
            this.студент1TableAdapter2.Fill(this.qualificationDataSet13.Студент1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet12.Студент1". При необходимости она может быть перемещена или удалена.
            this.студент1TableAdapter1.Fill(this.qualificationDataSet12.Студент1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet11.Студент1". При необходимости она может быть перемещена или удалена.
            this.студент1TableAdapter.Fill(this.qualificationDataSet11.Студент1);

        }
    }
}
