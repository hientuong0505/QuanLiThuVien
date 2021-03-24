using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLíSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLSach"] == null)
            {
                frm_QLSach qlsach = new frm_QLSach();
                //Gắn con quản lí sách là con của form quản lí thư viện
                qlsach.MdiParent = this;
                qlsach.Show();
            } else
            {
                //Kích hoạt lại nếu đã có
                Application.OpenForms["frm_QLSach"].Activate();
            }
        }

        private void cấpThẻVàInThẻĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DocGia"] == null)
            {
                frm_DocGia qldocgia = new frm_DocGia();

                qldocgia.MdiParent = this;
                qldocgia.Show();
            }
            else
            {
                Application.OpenForms["frm_DocGia"].Activate();
            }
        }
    }
}
