using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace wfa_app_mvp.Mode
{
    class _Model : IModel
    {
        public DataTable ISetFillDt()
        {
            DataTable dt = new DataTable();
            Rectangle r = new Rectangle();
            r.OpenConnect();
            dt = r.FILLGRID("select x.id,x.ad,x.soyad,x.yas,y.vezife from tblisci x left join tblvezife y on x.vezife_id=y.id ");
            return dt;
        }
        public static DataTable Table_Vezife = null;
        public DataTable ISetFillVezife()
        {
            Table_Vezife = new DataTable();
            Rectangle r = new Rectangle();
            r.OpenConnect();
            Table_Vezife = r.FILLGRID("select * from tblvezife");
            return Table_Vezife;
        }
        public List<String> ISetInsert(string ad, string soyad, int yas, string vezife)
        {
            
            List<String> lc = new List<string>();
            Rectangle r = new Rectangle();
            r.OpenConnect();

            string vezife_code = r.FindCodeToName(Table_Vezife, vezife);

            lc.Add(ad);
            lc.Add(soyad);
            lc.Add(yas.ToString());
            lc.Add(vezife_code);

            r.InsertDb(lc[0], lc[1], int.Parse(lc[2]), lc[3]);
            return lc;
        }
        public List<String> ISetUpdate(int ID,string ad, string soyad, int yas, string vezife)
        {
          
            List<String> lc = new List<string>();
            Rectangle r = new Rectangle();
            r.OpenConnect();
            string vezife_code = r.FindCodeToName(Table_Vezife, vezife);

            lc.Add(ID.ToString());          
            lc.Add(ad);
            lc.Add(soyad);
            lc.Add(yas.ToString());
            lc.Add(vezife_code);

            r.UpdateDb(int.Parse(lc[0]), lc[1], lc[2], int.Parse(lc[3]), lc[4]);
            return lc;

        }
        public List<String> ISetDelete(int ID)
        {
            List<String> lc = new List<string>();
            Rectangle r = new Rectangle();
            r.OpenConnect();
            lc.Add(ID.ToString());
            r.DeleteDb(int.Parse(lc[0].ToString()));
            return lc;
            
        }
    }
}
