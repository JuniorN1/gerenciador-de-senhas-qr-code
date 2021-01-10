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
using System.IO;

namespace Novo_gerenciador
{
    
    public partial class Novo_Qr : Form
    {
        public DirectoryInfo Load_diretorio = null;
        public Novo_Qr()
        {
            InitializeComponent();
        }

        private int Itens_cont=0;
        private string Dir_padrao = @"C:\Users\Junior\Desktop\Lista-1";
        private void Bt_Criar_Click(object sender, EventArgs e)
        {

            if(Load_diretorio == null)
            {
                FolderBrowserDialog diretorio = new FolderBrowserDialog();
             
                if (diretorio.ShowDialog() == DialogResult.OK) { 
                    Load_diretorio = new DirectoryInfo(diretorio.SelectedPath);
                }
                else{
                    MessageBox.Show("Diretorio nao selecionado, setaremos o diretorio em Desktop , Com nome Lista-1!");
                    if (!Directory.Exists(Dir_padrao))
                    {
                        Directory.CreateDirectory(Dir_padrao);
                    }
                    Load_diretorio = new DirectoryInfo(Dir_padrao);
                   
                }
            }
            try
            {
                QRCodeEncoder qrCodecEncoder = new QRCodeEncoder();
                /*qrCodecEncoder.QRCodeBackgroundColor = System.Drawing.Color.White;
                  qrCodecEncoder.QRCodeForegroundColor = System.Drawing.Color.Black;
                  qrCodecEncoder.CharacterSet = "UTF-8";
                  qrCodecEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                  qrCodecEncoder.QRCodeScale = 6;
                  qrCodecEncoder.QRCodeVersion = 0;
                  qrCodecEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;                 
                  /string a ser gerada*/
                Image imageQRCode;
                String dados =
               "\n______________________________\n\n" +
                "| TITULO:"+ Tb_Titulo_do_Qr.Text
                + "\n______________________________\n\n"+
                "| NICK NAME:"+ Tb_Nick_Name.Text
               + "\n______________________________\n\n" +
                "| SITE:" + Tb_Site.Text
                  + "\n______________________________\n\n" +
                "| E-MAI:" + Tb_Email.Text
                  + "\n______________________________\n\n" +
                "| SENHA:" + Tb_Senha.Text
                 + "\n______________________________\n" ;
                imageQRCode = qrCodecEncoder.Encode(dados);
                Pb_Qr_preview.BackgroundImage = imageQRCode;   
                if(Load_diretorio!=null)Pb_Qr_preview.BackgroundImage.Save(Load_diretorio.FullName+"\\"+Tb_Titulo_do_Qr.Text+".png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
