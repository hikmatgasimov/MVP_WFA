using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wfa_app_mvp.Presenter;
using wfa_app_mvp.View;
using wfa_app_mvp.Mode;
using System.Data;

namespace wfa_app_mvp.Presenter
{
    class PRectangle
    {
        IView Iview;
        IModel Imodel;
        public PRectangle()
        { }
        public PRectangle(IView _Iview, IModel _Imodel)
        {
            this.Iview = _Iview;
            this.Imodel = _Imodel;
        }
        public void RectanglerBindD()
        {           
            Iview.IPersonalDt = Imodel.ISetFillDt();
            DataTable dt = Imodel.ISetFillVezife();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Iview.IPersonalCombo = dt.Rows[i][1].ToString();
            }          
        }
        public void RectangleGetValueInsertDb()
        {
            List<string> lc = new List<string>();
            lc.Add(Iview.IPersonalAd.ToString());
            lc.Add(Iview.IPersonalSoyad.ToString());
            lc.Add(Iview.IPersonalYas.ToString());
            lc.Add(Iview.IPersonalCombo.ToString());
            Imodel.ISetInsert(lc[0], lc[1], int.Parse(lc[2]), lc[3]);
            Iview.IPersonalDt = Imodel.ISetFillDt();
        }

        public void RectangleFillValueToComponent()//get from grid
        {        
         //------------------------------------------------------------
            List<string> l = Iview.IPersonaLC;
            Iview.IPersonaID = int.Parse(l[0]);
            Iview.IPersonalAd = l[1];
            Iview.IPersonalSoyad = l[2];
            Iview.IPersonalYas = l[3];
            Iview.IPersonalForComUpdate = l[4];
            l.Clear();
           
         //-------------------------------------------------------------
        }
        public void  RectangleGetValueUpdateDb()
        {
            List<string> lc = new List<string>();
            lc.Add(Iview.IPersonaID.ToString());
            lc.Add(Iview.IPersonalAd.ToString());
            lc.Add(Iview.IPersonalSoyad.ToString());
            lc.Add(Iview.IPersonalYas.ToString());
            lc.Add(Iview.IPersonalCombo.ToString());
            Imodel.ISetUpdate(int.Parse(lc[0]), lc[1], lc[2], int.Parse(lc[3]), lc[4]);
            Iview.IPersonalDt = Imodel.ISetFillDt();
        }
        public void RectangleGetValueDeleteDb()
        {
            int ID = Iview.IPersonaID;
            Imodel.ISetDelete(ID);
            Iview.IPersonalDt = Imodel.ISetFillDt();
        }
    }
}
