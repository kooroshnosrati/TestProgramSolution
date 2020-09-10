using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WebFormApp
{
    public class Cls_RegionMNG
    {
        public void NewCountry(string CountryName)
        {
            SqlDataSource sqlDataSource = new SqlDataSource();
            sqlDataSource.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
            Parameter p = new Parameter("@Name", System.Data.DbType.String, CountryName);
            sqlDataSource.InsertParameters.Add(p);
            sqlDataSource.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqlDataSource.InsertCommand = "SP_NewCountry";
            sqlDataSource.Insert();
            sqlDataSource.Dispose();
        }

        public void UpdateCountry(int ID, string CountryName)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCountry(int ID)
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetAllCountries()
        {
            throw new System.NotImplementedException();
        }
    }
}