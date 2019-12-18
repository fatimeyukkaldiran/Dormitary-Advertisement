using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtTanitimii
{
    class secim
    {
        public bool secımYap(ComboBox cmbsehir, ComboBox cmbtur)
        {
            if (cmbsehir.Text == "")
            {
                MessageBox.Show("Öncelikle Sehir Seçin!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (cmbsehir.Text == "")
            {
                MessageBox.Show("Tur secimi yapiniz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return true;
               
            }
            
            else
                return false;
        }
    }
}
