using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageKernels
{
    public partial class CustomKernel : Form
    {
        private static Principal PrincipalForm = Application.OpenForms.OfType<Principal>().FirstOrDefault();

        public CustomKernel()
        {
            InitializeComponent();
            setMatrixValues();

            toolTip1.SetToolTip(resetButton, "Regresa la matriz a sus valores por defecto");
        }

        public void setMatrixValues()
        {
            a.Text = KernelController.Personalizado[0, 0].ToString();
            b.Text = KernelController.Personalizado[0, 1].ToString();
            c.Text = KernelController.Personalizado[0, 2].ToString();
            d.Text = KernelController.Personalizado[1, 0].ToString();
            e.Text = KernelController.Personalizado[1, 1].ToString();
            f.Text = KernelController.Personalizado[1, 2].ToString();
            g.Text = KernelController.Personalizado[2, 0].ToString();
            h.Text = KernelController.Personalizado[2, 1].ToString();
            i.Text = KernelController.Personalizado[2, 2].ToString();
        }

        private void save_Click(object sender, EventArgs ex)
        {
            try
            {
                float A = (float) Convert.ToDouble(a.Text);
                float B = (float) Convert.ToDouble(b.Text);
                float C = (float) Convert.ToDouble(c.Text);
                float D = (float) Convert.ToDouble(d.Text);
                float E = (float) Convert.ToDouble(e.Text);
                float F = (float) Convert.ToDouble(f.Text);
                float G = (float) Convert.ToDouble(g.Text);
                float H = (float) Convert.ToDouble(h.Text);
                float I = (float) Convert.ToDouble(i.Text);
                
                KernelController.Personalizado = new float[,] { { A, B, C }, { D, E, F }, { G, H, I } };

                //Update Picture
                PrincipalForm.kernel.SelectedIndex = -1;
                PrincipalForm.kernel.SelectedIndex = 9;

                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Uno de los valores ingresados no es valido. Intente de nuevo.");
                Console.WriteLine(exception);
            }
        }

        private void resetButton_Click(object sender, EventArgs ex)
        {
            a.Text = "0";
            b.Text = "0";
            c.Text = "0";
            d.Text = "0";
            e.Text = "1";
            f.Text = "0";
            g.Text = "0";
            h.Text = "0";
            i.Text = "0";
        }
    }
}
