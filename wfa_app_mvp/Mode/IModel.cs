using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace wfa_app_mvp.Mode
{
    interface IModel
    {
        DataTable ISetFillDt();
        DataTable ISetFillVezife();

        List<String> ISetInsert(string ad, string soyad, int yas, string vezife);
        List<String> ISetUpdate(int ID, string ad, string soyad, int yas, string vezife);
        List<String> ISetDelete(int ID);
    }
}
