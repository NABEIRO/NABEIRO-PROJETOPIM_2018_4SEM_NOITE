namespace ProjetoHD.Apresentacao
{
    partial class CadastreSe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastreSe));
            this.lblLoginC = new System.Windows.Forms.Label();
            this.lblSenhaC = new System.Windows.Forms.Label();
            this.lblConfirmarSenhaC = new System.Windows.Forms.Label();
            this.txbLoginC = new System.Windows.Forms.TextBox();
            this.txbSenhaC = new System.Windows.Forms.TextBox();
            this.txbConfirmarSenhaC = new System.Windows.Forms.TextBox();
            this.btnCadastarC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginC
            // 
            this.lblLoginC.AutoSize = true;
            this.lblLoginC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginC.Location = new System.Drawing.Point(29, 36);
            this.lblLoginC.Name = "lblLoginC";
            this.lblLoginC.Size = new System.Drawing.Size(53, 16);
            this.lblLoginC.TabIndex = 0;
            this.lblLoginC.Text = "LOGIN";
            // 
            // lblSenhaC
            // 
            this.lblSenhaC.AutoSize = true;
            this.lblSenhaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaC.Location = new System.Drawing.Point(29, 131);
            this.lblSenhaC.Name = "lblSenhaC";
            this.lblSenhaC.Size = new System.Drawing.Size(60, 16);
            this.lblSenhaC.TabIndex = 1;
            this.lblSenhaC.Text = "SENHA";
            // 
            // lblConfirmarSenhaC
            // 
            this.lblConfirmarSenhaC.AutoSize = true;
            this.lblConfirmarSenhaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenhaC.Location = new System.Drawing.Point(29, 236);
            this.lblConfirmarSenhaC.Name = "lblConfirmarSenhaC";
            this.lblConfirmarSenhaC.Size = new System.Drawing.Size(153, 16);
            this.lblConfirmarSenhaC.TabIndex = 2;
            this.lblConfirmarSenhaC.Text = "CONFIRMAR SENHA";
            // 
            // txbLoginC
            // 
            this.txbLoginC.Location = new System.Drawing.Point(32, 62);
            this.txbLoginC.Name = "txbLoginC";
            this.txbLoginC.Size = new System.Drawing.Size(463, 20);
            this.txbLoginC.TabIndex = 3;
            // 
            // txbSenhaC
            // 
            this.txbSenhaC.Location = new System.Drawing.Point(32, 158);
            this.txbSenhaC.Name = "txbSenhaC";
            this.txbSenhaC.PasswordChar = '*';
            this.txbSenhaC.Size = new System.Drawing.Size(463, 20);
            this.txbSenhaC.TabIndex = 4;
            // 
            // txbConfirmarSenhaC
            // 
            this.txbConfirmarSenhaC.Location = new System.Drawing.Point(32, 262);
            this.txbConfirmarSenhaC.Name = "txbConfirmarSenhaC";
            this.txbConfirmarSenhaC.PasswordChar = '*';
            this.txbConfirmarSenhaC.Size = new System.Drawing.Size(463, 20);
            this.txbConfirmarSenhaC.TabIndex = 5;
            // 
            // btnCadastarC
            // 
            this.btnCadastarC.Location = new System.Drawing.Point(216, 330);
            this.btnCadastarC.Name = "btnCadastarC";
            this.btnCadastarC.Size = new System.Drawing.Size(102, 45);
            this.btnCadastarC.TabIndex = 6;
            this.btnCadastarC.Text = "CADASTRAR";
            this.btnCadastarC.UseVisualStyleBackColor = false;
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 406);
            this.Controls.Add(this.btnCadastarC);
            this.Controls.Add(this.txbConfirmarSenhaC);
            this.Controls.Add(this.txbSenhaC);
            this.Controls.Add(this.txbLoginC);
            this.Controls.Add(this.lblConfirmarSenhaC);
            this.Controls.Add(this.lblSenhaC);
            this.Controls.Add(this.lblLoginC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastreSe";
            this.Text = "SpyderHD Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginC;
        private System.Windows.Forms.Label lblSenhaC;
        private System.Windows.Forms.Label lblConfirmarSenhaC;
        private System.Windows.Forms.TextBox txbLoginC;
        private System.Windows.Forms.TextBox txbSenhaC;
        private System.Windows.Forms.TextBox txbConfirmarSenhaC;
        private System.Windows.Forms.Button btnCadastarC;
    }
}