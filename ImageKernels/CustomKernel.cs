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
                double A = Convert.ToDouble(a.Text);
                double B = Convert.ToDouble(b.Text);
                double C = Convert.ToDouble(c.Text);
                double D = Convert.ToDouble(d.Text);
                double E = Convert.ToDouble(e.Text);
                double F = Convert.ToDouble(f.Text);
                double G = Convert.ToDouble(g.Text);
                double H = Convert.ToDouble(h.Text);
                double I = Convert.ToDouble(i.Text);


                KernelController.Personalizado = new double[,] { { A, B, C }, { D, E, F }, { G, H, I } };

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
    }
}
