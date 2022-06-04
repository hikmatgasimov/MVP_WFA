using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace wfa_app_mvp
{
    class Rectangle
    {

        public static SqlConnection sc = new SqlConnection();
        public SqlCommand comman = new SqlCommand();


        string connect = "Data Source=localhost;Initial Catalog= MVP;User ID=sa;Password=1";

        public void OpenConnect()
        {

            sc.ConnectionString = connect;
            if (sc.State == ConnectionState.Closed)
                try
                { sc.Open(); }
                catch (Exception ex)
                { ex.Message.ToString(); }
        }

        public DataTable FILLGRID(string JQuery)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter(JQuery, sc);
            try
            {
              
                ap.Fill(dt);
                sc.Close();

            }
            catch (Exception ex)
            { ex.Message.ToString(); }
            return dt;
        }
        public bool InsertDb(string ad, string soyad, int yas, string vezife)
        {
            bool FunctionValue = false;
            string JQuery_Insert = "insert into tblisci values('" + ad + "','" + soyad + "','" + yas + "'," + vezife + ")";
            comman = new SqlCommand(JQuery_Insert, sc);
            try
            {
                comman.ExecuteNonQuery();
                sc.Close();
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
            return FunctionValue;
        }
        public bool UpdateDb(int ID, string ad, string soyad, int yas, string vezife)
        {
            bool FunctionValue = false;
            string JQuery_Update = "update tblisci set ad='" + ad + "',soyad='" + soyad + "',yas='" + yas + "',vezife_id=" + vezife + " where id=" + ID;
            comman = new SqlCommand(JQuery_Update, sc);
            try
            {
                comman.ExecuteNonQuery();
                sc.Close();
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
            return FunctionValue;
        }
        public bool DeleteDb(int ID)
        {
            bool FunctionValue = false;
            string JQuery_Delete = "delete tblisci  where id=" + ID;
            comman = new SqlCommand(JQuery_Delete, sc);
            try
            {
                comman.ExecuteNonQuery();
                sc.Close();
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
            return FunctionValue;
        }
        public string FindCodeToName(DataTable dt, string vezife)
        {
            string ResultFunction = "";
            try
            {
                if (dt.Rows.Count != 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (vezife.Trim() == dt.Rows[i][1].ToString().Trim())
                        {
                            ResultFunction = dt.Rows[i][0].ToString().Trim();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            { ex.Message.ToString(); }

            return ResultFunction;
        }
        //-----------------------------------------------
        //-----------------------------------------------
        //-----------------------------------------------
        //public List<DataTable> FirstFillData()
        //{
        //    try
        //    {
        //        if (Table == null)
        //        {
        //            Table = new List<DataTable>();
        //            DataTable Table_info = new DataTable();
        //            DataTable Table_vezife = new DataTable();

        //            string jquery_info = "select x.id,x.ad,x.soyad,x.yas,y.vezife from info x left join pewe y on x.VID=y.id ";
        //            string jquery_Vezife = "select * from pewe";
        //            SqlDataAdapter adapt_info = new SqlDataAdapter(jquery_info,sc);
        //            adapt_info.Fill(Table_info);
        //            Table.Add(Table_info);
        //            SqlDataAdapter adapt_vezife = new SqlDataAdapter(jquery_Vezife, sc);
        //            adapt_vezife.Fill(Table_vezife );
        //            Table.Add(Table_vezife);
        //            sc.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    { ex.Message.ToString(); }
        //    return Table;
        //}
    }
}
