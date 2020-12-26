using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Novo_gerenciador
{
    public partial class Gerenciar_form_inicial : Form
    {
        public Gerenciar_form_inicial()
        {
            InitializeComponent();
        }
        FileInfo[] Load_arquivos= null;
        DirectoryInfo Load_diretorio = null;
        Form Geral = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Nova_Lista_Click(object sender, EventArgs e)
        {
            if(Geral != null)Geral.Close();           
            Geral = new Novo_Qr();
            Geral.Show();
            (Geral as Novo_Qr).Load_diretorio = Load_diretorio;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public int compare_to(string ex)
        {            
            string[] extencoes = { ".png", ".jpg",".bmp" };
            for (int i =0;i<3;i++){
                if (ex == extencoes[i])
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            return 1;

        }
        private void Bt_Ver_Lista_Click(object sender, EventArgs e)
        {
            string extencao;
            Geral = new Listar_qr();
            Geral.Show();
            if (Load_arquivos != null){           
            int j = 0;
                foreach (FileInfo qrs in Load_arquivos)
                {                   
                    extencao = qrs.Extension;
                    if (this.compare_to(extencao) == 1)
                    {
                        (Geral as Listar_qr).Img_list_qrs.Images.Add(Image.FromFile(qrs.FullName));
                        (Geral as Listar_qr).Ltv_qrs.Items.Add(qrs.Name, j);
                        j++;
                    }
                }

            }
            else
            {
                MessageBox.Show("Nao Existe lista!");
            }
        }
         private void Bt_Configuracoes_Click(object sender, EventArgs e)
        {
            Configurações nova_configuracao = new Configurações();
            nova_configuracao.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ler_Qr a = new Ler_Qr();
            a.Show();  
        }

        private void Bt_Imprimir_Click(object sender, EventArgs e)
        {
            imprimir_lista nova_imprecao = new imprimir_lista();
            nova_imprecao.Show();
        }

        private void Bt_Sobre_Click(object sender, EventArgs e)
        {
           
        }

        private void Bt_Carregar_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog diretorio = new FolderBrowserDialog();
            diretorio.ShowDialog();
            Load_diretorio = new DirectoryInfo(diretorio.SelectedPath);
            Load_arquivos = Load_diretorio.GetFiles("*", SearchOption.TopDirectoryOnly);
          
        }
    }
}
