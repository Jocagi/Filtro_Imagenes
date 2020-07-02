using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageKernels
{
    public partial class Principal : Form
    {
        private readonly float[,] Difuminado = {{0.0625f, 0.125f, 0.0625f}, {0.125f, 0.25f, 0.125f}, {0.0625f, 0.125f, 0.0625f}};
        private readonly float[,] Realzar = { { -2, -1, 0 }, { -1, 1, 1 }, { 0, 1, 2 } };
        private readonly float[,] Sobel_Inferior = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
        private readonly float[,] Sobel_Superior = { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
        private readonly float[,] Sobel_Izquierdo = { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
        private readonly float[,] Sobel_Derecho = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
        private readonly float[,] Contorno = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
        private readonly float[,] Afilar = { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
        private readonly float[,] Original = { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
        
        private Bitmap actualImage;
        private Color[][] actualPixels;

        public Principal()
        {
            InitializeComponent();
            hideComponents();
        }

        private void hideComponents()
        {
            label2.Visible = false;
            label3.Visible = false;
            filter.Visible = false;
            kernel.Visible = false;
            picture1.Visible = false;
            picture2.Visible = false;
            download.Visible = false;
            editKernel.Visible = false;
            DefaultPictureBox.Visible = true;
        }

        private void showComponents()
        {
            label2.Visible = true;
            label3.Visible = true;
            filter.Visible = true;
            kernel.Visible = true;
            picture1.Visible = true;
            picture2.Visible = true;
            download.Visible = true;
            DefaultPictureBox.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = @"Imagen|*.jpg;*.jpeg;*.jpe;*.jfif;*.png;*.gif;*.ico;*.tif;*.tiff;*.bmp";
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); 
            fileDialog.Title = @"Porfavor seleccione una imagen.";
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                actualImage = (Bitmap) Image.FromFile(fileDialog.FileName);
                actualPixels = KernelController.GetBitMapColorMatrix(actualImage);
                picture1.Image = Image.FromFile(fileDialog.FileName);
                picture2.Image = Image.FromFile(fileDialog.FileName);
                
                kernel.SelectedIndex = 8;
                filter.SelectedIndex = 0;

                showComponents();
                fileLabel.Text = fileDialog.SafeFileName;
            }
            else
            {
                MessageBox.Show(@"Error al leer el archivo.");
            }
        }

        public static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats
            var codecs = ImageCodecInfo.GetImageEncoders();
            // Find the correct image codec
            return codecs.FirstOrDefault(t => t.MimeType == mimeType);
        }

        private void download_Click(object sender, EventArgs e)
        {
            const double quality = 1;
            var d = new SaveFileDialog { Filter = @"png files|*.png" };
            try
            {
                if (d.ShowDialog() != DialogResult.OK)
                    return;
                var bmp = picture2.Image;
                var qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality,
                    (long)(quality * 75));

                var pngCodec = GetEncoderInfo("image/png");
                if (pngCodec == null)
                    return;
                var encoderParams = new EncoderParameters(1) { Param = { [0] = qualityParam } };
                bmp.Save(d.FileName, pngCodec, encoderParams);

                MessageBox.Show(@"Archivo guardado exitosamente.");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = filter.SelectedIndex;

            //Select filter

            // 0 -> Default
            // 1 -> Black and White
            // 2 -> Sepia

            switch (selectedIndex)
            {
                case 0:
                    picture2.Image = actualImage;
                    break;
                case 1:
                    picture2.Image = PictureController.convertToGrayScale(actualImage);
                    break;
                case 2:
                    picture2.Image = PictureController.convertToSepia(actualImage);
                    break;
                default:
                    picture1.Image = actualImage;
                    picture2.Image = actualImage;
                    break;
            }

            actualPixels = KernelController.GetBitMapColorMatrix((Bitmap) picture2.Image);

            kernel.SelectedIndex = 8;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            editKernel.Visible = false;

            //Select kernel

            // 0 -> Difuminado
            // 1 -> Realzar
            // 2 -> Sobel Inferior
            // 3 -> Sobel Superior
            // 4 -> Sobel Izquierdo
            // 5 -> Sobel Derecho
            // 6 -> Contorno
            // 7 -> Afilar
            // 8 -> Original
            // 9 -> Personalizado

            int selectedIndex = kernel.SelectedIndex;
            Color[][] picture = actualPixels;

            switch (selectedIndex)
            {
                case 0:
                    picture2.Image =
                        KernelController.applyKernel(picture, Difuminado);
                    break;
                case 1:
                    picture2.Image =
                        KernelController.applyKernel(picture, Realzar);
                    break;
                case 2:
                    picture2.Image =
                        KernelController.applyKernel(picture, Sobel_Inferior);
                    break;
                case 3:
                    picture2.Image =
                        KernelController.applyKernel(picture, Sobel_Superior);
                    break;
                case 4:
                    picture2.Image =
                        KernelController.applyKernel(picture, Sobel_Izquierdo);
                    break;
                case 5:
                    picture2.Image =
                        KernelController.applyKernel(picture, Sobel_Derecho);
                    break;
                case 6:
                    picture2.Image =
                        KernelController.applyKernel(picture, Contorno);
                    break;
                case 7:
                    picture2.Image =
                        KernelController.applyKernel(picture, Afilar);
                    break;
                case 8:
                    picture2.Image =
                        KernelController.applyKernel(picture, Original);
                    break;
                case 9:
                    editKernel.Visible = true;
                    picture2.Image =
                        KernelController.applyKernel(picture, KernelController.Personalizado);
                    break;
                default:
                    picture2.Image = picture1.Image;
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomKernel k = new CustomKernel();
            k.Visible = true;
        }
    }
}
