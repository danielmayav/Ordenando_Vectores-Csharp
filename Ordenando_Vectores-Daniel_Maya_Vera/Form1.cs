using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenando_Vectores_Daniel_Maya_Vera
{
    public partial class frmArreglandoVec : Form
    {

        int n = 6;
        int[] arreglo;

        public frmArreglandoVec()
        {
            InitializeComponent();
        }

        private void bntLlenar_Click(object sender, EventArgs e)
        {
            arreglo = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                arreglo[i] = r.Next(1, 50);
            }

            for (int i = 0;i < n; i++)
            {
                txtLlenar.AppendText(String.Format("{0,3}", arreglo[i]));
            }
        }
    }
}
