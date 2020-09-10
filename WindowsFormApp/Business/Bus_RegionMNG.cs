using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp.Business
{
    class Bus_RegionMNG
    {
        public void NewCountry(string CountryName)
        {
            //TestDB1Entities testDB1Entities = new TestDB1Entities();
            //Tbl_Countries tbl_Countries = new Tbl_Countries();
            //tbl_Countries.Name = CountryName;
            //testDB1Entities.Tbl_Countries.Add(tbl_Countries);
            //testDB1Entities.SaveChanges();


            //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormApp.Properties.Settings.ConnectionString"].ConnectionString);
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.Connection = sqlConnection;
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.CommandText = "SP_NewCountry";
            //SqlParameter sqlParameter = new SqlParameter("@Name", CountryName);
            //sqlCommand.Parameters.Add(sqlParameter);
            //int result = sqlCommand.ExecuteNonQuery();
            //sqlCommand.Dispose();
            //sqlConnection.Close();
            //sqlConnection.Dispose();


        }

        public List<string> GetAllCountriesd()
        {
            throw new System.NotImplementedException();
        }
    }
}
