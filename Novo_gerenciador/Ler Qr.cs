using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;


namespace Novo_gerenciador
{
    public partial class Ler_Qr : Form
    {
        public Ler_Qr()
        {
            InitializeComponent();
        }

        private void Bt_Ler_Click(object sender, EventArgs e)
        {

            QRCodeDecoder qrCoderDec = new QRCodeDecoder();
            OpenFileDialog novo_im = new OpenFileDialog();
            
            novo_im.ShowDialog();            
            //string a ser gerada
            Pb_Qr_Previewer_cam.ImageLocation = novo_im.FileName;
           Rbt_Read.Text = (qrCoderDec.Decode(new QRCodeBitmapImage(new Bitmap(novo_im.FileName))));

            // Pb_Qr_preview.Image.Save("imga.png");
        }
    }
}
