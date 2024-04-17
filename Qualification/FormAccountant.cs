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
    public partial class FormAccountant : Form
    {
        public FormAccountant()
        {
            InitializeComponent();
        }

        private void FormAccountant_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet5.Стипендия". При необходимости она может быть перемещена или удалена.
            this.стипендияTableAdapter1.Fill(this.qualificationDataSet5.Стипендия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet3.Табель_студентов". При необходимости она может быть перемещена или удалена.
            this.табель_студентовTableAdapter1.Fill(this.qualificationDataSet3.Табель_студентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet1.Табель_студентов". При необходимости она может быть перемещена или удалена.
           // this.табель_студентовTableAdapter.Fill(this.qualificationDataSet1.Табель_студентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet.Стипендия". При необходимости она может быть перемещена или удалена.
            

        }

        private void calculateScholarship_Click(object sender, EventArgs e)
        {
            string selectedId = dataGridViewStudentReportCard.Rows[dataGridViewStudentReportCard.CurrentRow.Index].Cells[0].Value.ToString();
            StudentsReportCard src = new StudentsReportCard(selectedId);

            sumScolarship.Text = src.calculate().ToString();
        }

        private void calculateAndSaveButton_Click(object sender, EventArgs e)
        {

            var row = dataGridViewGrants.Rows[dataGridViewGrants.CurrentRow.Index];
            string FIO = row.Cells[0].Value.ToString();
            double sumAcadScol = Convert.ToDouble(row.Cells[1].Value);
            bool isSocScol = Convert.ToBoolean(row.Cells[2].Value);
            double sumDopScol = Convert.ToDouble(row.Cells[3].Value);


            ScolarshipReportCard csrc = new ScolarshipReportCard(FIO, sumAcadScol, isSocScol, sumDopScol);
            row.Cells[4].Value = csrc.calculate();
            csrc.Save();

            MessageBox.Show(csrc.Show());
        }
    }
}
