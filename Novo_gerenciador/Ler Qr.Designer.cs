namespace Novo_gerenciador
{
    partial class Ler_Qr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pb_Qr_Previewer_cam = new System.Windows.Forms.PictureBox();
            this.Bt_Ler = new System.Windows.Forms.Button();
            this.Rbt_Read = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Qr_Previewer_cam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Pb_Qr_Previewer_cam);
            this.panel1.Controls.Add(this.Bt_Ler);
            this.panel1.Controls.Add(this.Rbt_Read);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Favor posicionar a web sobre o qr code que deseja ler;";
            // 
            // Pb_Qr_Previewer_cam
            // 
            this.Pb_Qr_Previewer_cam.BackgroundImage = global::Novo_gerenciador.Properties.Resources.icons8_imagem_filled_100;
            this.Pb_Qr_Previewer_cam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pb_Qr_Previewer_cam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_Qr_Previewer_cam.ErrorImage = null;
            this.Pb_Qr_Previewer_cam.InitialImage = null;
            this.Pb_Qr_Previewer_cam.Location = new System.Drawing.Point(12, 35);
            this.Pb_Qr_Previewer_cam.Name = "Pb_Qr_Previewer_cam";
            this.Pb_Qr_Previewer_cam.Size = new System.Drawing.Size(285, 231);
            this.Pb_Qr_Previewer_cam.TabIndex = 2;
            this.Pb_Qr_Previewer_cam.TabStop = false;
            // 
            // Bt_Ler
            // 
            this.Bt_Ler.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Ler.Location = new System.Drawing.Point(12, 284);
            this.Bt_Ler.Name = "Bt_Ler";
            this.Bt_Ler.Size = new System.Drawing.Size(285, 43);
            this.Bt_Ler.TabIndex = 1;
            this.Bt_Ler.Text = "Ler";
            this.Bt_Ler.UseVisualStyleBackColor = true;
            this.Bt_Ler.Click += new System.EventHandler(this.Bt_Ler_Click);
            // 
            // Rbt_Read
            // 
            this.Rbt_Read.Location = new System.Drawing.Point(316, 35);
            this.Rbt_Read.Name = "Rbt_Read";
            this.Rbt_Read.Size = new System.Drawing.Size(472, 364);
            this.Rbt_Read.TabIndex = 0;
            this.Rbt_Read.Text = "";
            // 
            // Ler_Qr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Ler_Qr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ler_Qr";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Qr_Previewer_cam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox Rbt_Read;
        private System.Windows.Forms.PictureBox Pb_Qr_Previewer_cam;
        private System.Windows.Forms.Button Bt_Ler;
        private System.Windows.Forms.Label label1;
    }
}