using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandK.Model
{
    public class CMatchManager
    {
        //public void create(CMatch p)
        //{
        //    string sql= "INSERT INTO tMatch(";
        //    sql+="fHelpId,";
        //    sql += "fMemberId,";
        //    sql += "fPoint,";
        //    sql += "fMatchStatus,";
        //    sql += "fGrade,";
        //    sql += "fMessage";
        //    sql += ")VALUES(";
        //    sql += "@K_FHELPID";
        //    sql += "@K_FMEMBERID";
        //    sql += "@K_FPOINT";
        //    sql += "@K_FMATCHSTATUS";
        //    sql += "@K_FGRADE";
        //    sql += "@K_FMESSAGE)";

        //    SqlConnection con  = new SqlConnection();
        //    con.ConnectionString = "Data Source=.;Initial Catalog=WealthierAndKinder;Integrated Security=True;Encrypt=False";
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = sql;
        //    cmd.Parameters.Add(new SqlParameter("K_FHELPID", (object)p.fHelpId)) ;
        //    cmd.Parameters.Add(new SqlParameter("K_FMEMBERID", (object)p.fMemberId));
        //    cmd.Parameters.Add(new SqlParameter("K_FPOINT", (object)p.fPoint));
        //    cmd.Parameters.Add(new SqlParameter("K_FMATCHSTATUS", (object)p.fMatchStatus));
        //    cmd.Parameters.Add(new SqlParameter("K_FGRADE",(object)p.fGrade));
        //    cmd.Parameters.Add(new SqlParameter("K_FMESSAGE", (object)p.fMessage));

        //    cmd.ExecuteNonQuery();
        //    con.Close();



        //}
    }
}
