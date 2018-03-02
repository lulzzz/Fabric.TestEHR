using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR
{
    class SqlLoader
    {
        internal DataTable LoadPatient(string facilityAccountId)
        {
            var settings = ConfigurationManager.ConnectionStrings["SAM"];

            SqlConnection conn = new SqlConnection(settings.ConnectionString);

            string sql = "SELECT TOP 1 FacilityAccountID, PredictedProbNBR, Factor1TXT,Factor2TXT,Factor3TXT,LastCalculatedDTS FROM Sepsis.EWSSummaryPatientRiskBASENew where FacilityAccountID = @facilityAccountId ORDER BY LastCalculatedDTS DESC";

            SqlCommand cmdRisk = new SqlCommand(sql, conn);
            cmdRisk.Parameters.Add(new SqlParameter("@facilityAccountId", SqlDbType.VarChar));
            cmdRisk.Parameters["@facilityAccountId"].Value = facilityAccountId;

            try
            {
                //FC-6 Run the command and display the results.  
                //Open the connection.  
                conn.Open();

                //Run the command by using SqlDataReader.  
                SqlDataReader rdr = cmdRisk.ExecuteReader();

                //Create a data table to hold the retrieved data.  
                DataTable dataTable = new DataTable();

                //Load the data from SqlDataReader into the data table.  
                dataTable.Load(rdr);

                //Display the data from the data table in the data grid view.  
                //this.dgvCustomerOrders.DataSource = dataTable;

                //Close the SqlDataReader.  
                rdr.Close();

                return dataTable;
            }
            catch
            {
                //A simple catch.  
                // MessageBox.Show("The requested order could not be loaded into the form.");
            }
            finally
            {
                //Close the connection.  
                conn.Close();
            }

            return null;
        }
    }
}
