using NTierArchitecture.UI.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierArchitecture.UI.Forms
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void kategoriTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Category fCat = new Frm_Category();

            FormKontrol(fCat);
        }

        private void FormKontrol(Form fCat)
        {
            fCat.MdiParent = this;

            if (FormUtils.IsFormOpen(fCat))
            {
                MessageBox.Show("Form zaten açık.");
            }
            else
            {
                fCat.Show();
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void ürünTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Product fProduct = new Frm_Product();
            FormKontrol(fProduct);
        }

        private void tedarikçiTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Supplier fSupplier = new Frm_Supplier();
            FormKontrol(fSupplier);
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Order fOrder = new Frm_Order();
            FormKontrol(fOrder);
        }
    }
}
