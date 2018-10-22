using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Umit_AKINCI_KutuphaneProjesi.Models
{
    public class DbHelper
    {
        private SqlConnection _baglanti;

        public DbHelper()
        {
          
            _baglanti = new SqlConnection("Data Source=arge_dev2008;Initial Catalog=stajyer;User Id=stajyer;Password=stajyer;");
        }


        public DataTable GetDataTable(string sql)
        {
            _baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, _baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _baglanti.Close();

            return dt;
        }

        public int Execute(string query)
        {

            _baglanti.Open();
            SqlCommand komut = new SqlCommand(query, _baglanti);

            var result = komut.ExecuteNonQuery();
            _baglanti.Close();

            return result;
        }

        public int Execute(string query,Dictionary<string,object> parameters )
        {
            _baglanti.Open();
            SqlCommand komut = new SqlCommand(query, _baglanti);
            if (parameters!=null && parameters.Count>0)
            {
                foreach (KeyValuePair<string, object> par in parameters)
                {
                    komut.Parameters.AddWithValue(par.Key, par.Value);
                }
            }

            var result = komut.ExecuteNonQuery();
            _baglanti.Close();

            return result;
        }


        public int ExecuteScalar(string query, Dictionary<string, object> parameters)
        {
            _baglanti.Open();
            SqlCommand komut = new SqlCommand(query, _baglanti);
            if (parameters != null && parameters.Count > 0)
            {
                foreach (KeyValuePair<string, object> par in parameters)
                {
                    komut.Parameters.AddWithValue(par.Key, par.Value);
                }
            }

            int result = (int)komut.ExecuteScalar();
            _baglanti.Close();

            return result;
        
        }

    }
}
