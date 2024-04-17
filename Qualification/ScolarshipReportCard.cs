using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using SD = System.Data;
using System.Data;
using System.Threading.Tasks;

namespace Qualification
{
    class ScolarshipReportCard
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        public string FIO;
        public double sumAcadScol;
        public bool isSocScol;
        public double sumDopScol;
        public double sumScol = 0;



        public void openConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public ScolarshipReportCard(string _FIO, double _sumAcadScol, bool _isSocScol, double _sumDopScol)
        {

            FIO = _FIO;
            sumAcadScol = _sumAcadScol;
            isSocScol = _isSocScol;
            sumDopScol = _sumDopScol;
           
        }


        public double calculate()
        {
            double sum = sumAcadScol + sumDopScol;
            if (isSocScol)
            {
                sum += 4500;
            }
            sumScol = sum;
            return sum;
        }


        public string Show()
        {

            return $"{FIO} {sumAcadScol} {isSocScol} {sumDopScol} {sumScol}";

        }

        public void Save()
        {

        }
        
    }
}
