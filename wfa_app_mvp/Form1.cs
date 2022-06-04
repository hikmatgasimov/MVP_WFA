using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wfa_app_mvp.View;

using wfa_app_mvp.Presenter;

namespace wfa_app_mvp
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        public DataTable Set(DataTable dt)
        {
            dt.Rows.Add(dataGridView1.CurrentRow.Index);
            return dt;
        }
        #region MyComponent
        public DataTable IPersonalDt
        {
            set
            { dataGridView1.DataSource = value; }
        }
        public List<string> IPersonaLC
        {
            get
            {

                List<string> List = new List<string>();
                // --------------------------------------------------------------
                List.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                List.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString());
                List.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
                List.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString());
                List.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString());
                return List;

            }
        }
        public Int32 IPersonaID
        {
            get
            {
                return int.Parse(txt_users_ID.Text);
            }
            set
            {
                txt_users_ID.Text = value.ToString();
            }
        }
        public String IPersonalAd
        {
            get
            {
                return txt_users_ad.Text;
            }
            set
            {
                txt_users_ad.Text = value;
            }
        }
        public String IPersonalSoyad
        {
            get
            {
                return txt_users_soyad.Text;
            }
            set
            {
                txt_users_soyad.Text = value;
            }
        }
        public String IPersonalYas
        {
            get
            {
                return txt_users_yas.Text;
            }
            set
            {
                txt_users_yas.Text = value;
            }
        }
        public String IPersonalCombo
        {
            get
            {
                return com_users_vezife.SelectedItem.ToString();
            }
            set
            {
                com_users_vezife.Items.Add(value);
            }
        }
        public String IPersonalForComUpdate
        {
            set
            {
                com_users_vezife.SelectedItem = value;
            }
        }
        #endregion

        private void btn_users_add_Click(object sender, EventArgs e)
        {
            PRectangle p = new PRectangle(this, new wfa_app_mvp.Mode._Model());
            p.RectangleGetValueInsertDb();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PRectangle p = new PRectangle(this, new wfa_app_mvp.Mode._Model());
            p.RectangleFillValueToComponent();

        }

        private void btn_users_update_Click(object sender, EventArgs e)
        {
            PRectangle p = new PRectangle(this, new wfa_app_mvp.Mode._Model());
            p.RectangleGetValueUpdateDb();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //com_users_vezife.Items.Clear();
            PRectangle p = new PRectangle(this, new wfa_app_mvp.Mode._Model());
            p.RectanglerBindD();

        }

        private void btn_users_delete_Click(object sender, EventArgs e)
        {
            PRectangle p = new PRectangle(this, new wfa_app_mvp.Mode._Model());
            p.RectangleGetValueDeleteDb();

        }

        private void com_users_vezife_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
