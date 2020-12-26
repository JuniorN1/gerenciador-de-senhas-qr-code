namespace Novo_gerenciador
{
    partial class Gerenciar_form_inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciar_form_inicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bt_Lista_Para_PDF = new System.Windows.Forms.Button();
            this.Bt_Sobre = new System.Windows.Forms.Button();
            this.Bt_Imprimir = new System.Windows.Forms.Button();
            this.Bt_Carregar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Bt_Configuracoes = new System.Windows.Forms.Button();
            this.Bt_Ver_Lista = new System.Windows.Forms.Button();
            this.Bt_Nova_Lista = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Bt_Lista_Para_PDF);
            this.panel1.Controls.Add(this.Bt_Sobre);
            this.panel1.Controls.Add(this.Bt_Imprimir);
            this.panel1.Controls.Add(this.Bt_Carregar);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Bt_Configuracoes);
            this.panel1.Controls.Add(this.Bt_Ver_Lista);
            this.panel1.Controls.Add(this.Bt_Nova_Lista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 393);
            this.panel1.TabIndex = 0;
            // 
            // Bt_Lista_Para_PDF
            // 
            this.Bt_Lista_Para_PDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bt_Lista_Para_PDF.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Lista_Para_PDF.Image = global::Novo_gerenciador.Properties.Resources.icons8_pdf_2_filled_100;
            this.Bt_Lista_Para_PDF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_Lista_Para_PDF.Location = new System.Drawing.Point(783, 25);
            this.Bt_Lista_Para_PDF.Name = "Bt_Lista_Para_PDF";
            this.Bt_Lista_Para_PDF.Size = new System.Drawing.Size(229, 148);
            this.Bt_Lista_Para_PDF.TabIndex = 8;
            this.Bt_Lista_Para_PDF.Text = "Lista Para PDF";
            this.Bt_Lista_Para_PDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_Lista_Para_PDF.UseVisualStyleBackColor = true;
            this.Bt_Lista_Para_PDF.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bt_Sobre
            // 
            this.Bt_Sobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bt_Sobre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Sobre.Image = global::Novo_gerenciador.Properties.Resources.icons8_super_homen_512;
            this.Bt_Sobre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_Sobre.Location = new System.Drawing.Point(783, 198);
            this.Bt_Sobre.Name = "Bt_Sobre";
            this.Bt_Sobre.Size = new System.Drawing.Size(229, 148);
            this.Bt_Sobre.TabIndex = 7;
            this.Bt_Sobre.Text = "Sobre";
            this.Bt_Sobre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_Sobre.UseVisualStyleBackColor = true;
            this.Bt_Sobre.Click += new System.EventHandler(this.Bt_Sobre_Click);
            // 
            // Bt_Imprimir
            // 
            this.Bt_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bt_Imprimir.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Imprimir.Image = global::Novo_gerenciador.Properties.Resources.icons8_impressão_96;
            this.Bt_Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_Imprimir.Location = new System.Drawing.Point(529, 198);
            this.Bt_Imprimir.Name = "Bt_Imprimir";
            this.Bt_Imprimir.Size = new System.Drawing.Size(229, 148);
            this.Bt_Imprimir.TabIndex = 6;
            this.Bt_Imprimir.Text = "Imprimir";
            this.Bt_Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_Imprimir.UseVisualStyleBackColor = true;
            this.Bt_Imprimir.Click += new System.EventHandler(this.Bt_Imprimir_Click);
            // 
            // Bt_Carregar
            // 
            this.Bt_Carregar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Carregar.Image = global::Novo_gerenciador.Properties.Resources.icons8_adicionar_a_lista_filled_100;
            this.Bt_Carregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_Carregar.Location = new System.Drawing.Point(277, 198);
            this.Bt_Carregar.Name = "Bt_Carregar";
            this.Bt_Carregar.Size = new System.Drawing.Size(229, 148);
            this.Bt_Carregar.TabIndex = 5;
            this.Bt_Carregar.Text = "Carregar";
            this.Bt_Carregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_Carregar.UseVisualStyleBackColor = true;
            this.Bt_Carregar.Click += new System.EventHandler(this.Bt_Carregar_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(25, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 148);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ler Qr";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Bt_Configuracoes
            // 
            this.Bt_Configuracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bt_Configuracoes.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Configuracoes.Image = global::Novo_gerenciador.Properties.Resources.icons8_configurações_4801;
            this.Bt_Configuracoes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_Configuracoes.Location = new System.Drawing.Point(529, 25);
            this.Bt_Configuracoes.Name = "Bt_Configuracoes";
            this.Bt_Configuracoes.Size = new System.Drawing.Size(229, 148);
            this.Bt_Configuracoes.TabIndex = 2;
            this.Bt_Configuracoes.Text = "Configurações";
            this.Bt_Configuracoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_Configuracoes.UseVisualStyleBackColor = true;
            this.Bt_Configuracoes.Click += new System.EventHandler(this.Bt_Configuracoes_Click);
            // 
            // Bt_Ver_Lista
            // 
            this.Bt_Ver_Lista.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Ver_Lista.Image = global::Novo_gerenciador.Properties.Resources.icons8_lista_de_verificação_90;
            this.Bt_Ver_Lista.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_Ver_Lista.Location = new System.Drawing.Point(277, 25);
            this.Bt_Ver_Lista.Name = "Bt_Ver_Lista";
            this.Bt_Ver_Lista.Size = new System.Drawing.Size(229, 148);
            this.Bt_Ver_Lista.TabIndex = 1;
            this.Bt_Ver_Lista.Text = "Ver Lista";
            this.Bt_Ver_Lista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_Ver_Lista.UseVisualStyleBackColor = true;
            this.Bt_Ver_Lista.Click += new System.EventHandler(this.Bt_Ver_Lista_Click);
            // 
            // Bt_Nova_Lista
            // 
            this.Bt_Nova_Lista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bt_Nova_Lista.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Nova_Lista.Image = global::Novo_gerenciador.Properties.Resources.icons8_código_qr_96_1_;
            this.Bt_Nova_Lista.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt_Nova_Lista.Location = new System.Drawing.Point(25, 25);
            this.Bt_Nova_Lista.Name = "Bt_Nova_Lista";
            this.Bt_Nova_Lista.Size = new System.Drawing.Size(229, 148);
            this.Bt_Nova_Lista.TabIndex = 0;
            this.Bt_Nova_Lista.Text = "Nova Lista";
            this.Bt_Nova_Lista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt_Nova_Lista.UseVisualStyleBackColor = true;
            this.Bt_Nova_Lista.Click += new System.EventHandler(this.Bt_Nova_Lista_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Gerenciar_form_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1037, 393);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1053, 432);
            this.MinimumSize = new System.Drawing.Size(1053, 432);
            this.Name = "Gerenciar_form_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Senhas ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bt_Nova_Lista;
        private System.Windows.Forms.Button Bt_Configuracoes;
        private System.Windows.Forms.Button Bt_Ver_Lista;
        private System.Windows.Forms.Button Bt_Sobre;
        private System.Windows.Forms.Button Bt_Imprimir;
        private System.Windows.Forms.Button Bt_Carregar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Bt_Lista_Para_PDF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

