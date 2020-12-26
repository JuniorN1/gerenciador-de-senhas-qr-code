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
using System.Drawing.Imaging;
namespace Novo_gerenciador
{
    public partial class Listar_qr : Form
    {
        Form form1;
        public Listar_qr()
        {
            InitializeComponent();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_Ler_Click(object sender, EventArgs e)
        {
            Image qr_selected = null;
            for (int i = 0; i < Ltv_qrs.Items.Count; i++)
            {
                if (Ltv_qrs.Items[i].Selected == true)
                {
                    qr_selected = Img_list_qrs.Images[i];
                    break;
                }
            }
            if(qr_selected != null)
            {
              
                QRCodeDecoder qr = new QRCodeDecoder();
            //    string teste= (qr.Decode(new QRCodeBitmapImage(new Bitmap(qr_selected))));
             //   richTextBox1.Text = teste;
                System.Drawing.Bitmap myImg = new System.Drawing.Bitmap(qr_selected);

               // qr.Decode(myImg);
                if ( != null)
                {
                    //.. success
                }
            }
            else
            {
                MessageBox.Show("Qr Nao Selecionado!");
            }
          
          
        }

    
    }
}
 