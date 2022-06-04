using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace wfa_app_mvp.View
{
    interface IView
    {
        DataTable IPersonalDt {  set; }
        List<string> IPersonaLC {get; }
        Int32 IPersonaID { get; set; }
        String IPersonalAd { get; set; }
        String IPersonalSoyad { get; set; }
        String IPersonalYas { get; set; }
        String IPersonalForComUpdate { set; }
        String IPersonalCombo { get; set; }
        
        //List<String> IPersonalCombox { get; set; }
        //String ISet { get; set; }
        //String IPersonalD { get; }
    }
}
