namespace VisitasVidaUniversitaria
{
    partial class Mensagem
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
            this.components = new System.ComponentModel.Container();
            this.pbQuadrado = new System.Windows.Forms.PictureBox();
            this.pbMensagem = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQuadrado
            // 
            this.pbQuadrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbQuadrado.Location = new System.Drawing.Point(759, -1);
            this.pbQuadrado.Name = "pbQuadrado";
            this.pbQuadrado.Size = new System.Drawing.Size(100, 50);
            this.pbQuadrado.TabIndex = 17;
            this.pbQuadrado.TabStop = false;
            // 
            // pbMensagem
            // 
            this.pbMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMensagem.Location = new System.Drawing.Point(12, 12);
            this.pbMensagem.Name = "pbMensagem";
            this.pbMensagem.Size = new System.Drawing.Size(95, 81);
            this.pbMensagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMensagem.TabIndex = 18;
            this.pbMensagem.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Arial Black", 24F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(358, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 63);
            this.button1.TabIndex = 19;
            this.button1.Text = "Concluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbQuadrado);
            this.Controls.Add(this.pbMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mensagem";
            this.Text = "Mensagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mensagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQuadrado;
        private System.Windows.Forms.PictureBox pbMensagem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}