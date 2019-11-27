using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SkyPixCH
{
    public class Control
    {
        public static DataSet Run(string cmd)
        {
            SqlConnection SkyCon = new SqlConnection("Data Source=.;Initial Catalog=SkyPix;Integrated Security=True");
            SkyCon.Open();
            DataSet Dt = new DataSet();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd, SkyCon);
            SDA.Fill(Dt);
            SkyCon.Close();
            return Dt;
        }
    }
}

