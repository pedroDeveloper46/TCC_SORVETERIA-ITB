namespace TCC_Sorveteria.Negocio.Categoria
{
    partial class CadCategoria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butnSalvar = new System.Windows.Forms.Button();
            this.butnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(388, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(102, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(273, 22);
            this.txtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Categoria:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // butnSalvar
            // 
            this.butnSalvar.BackColor = System.Drawing.SystemColors.Info;
            this.butnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.butnSalvar.Location = new System.Drawing.Point(143, 80);
            this.butnSalvar.Name = "butnSalvar";
            this.butnSalvar.Size = new System.Drawing.Size(125, 31);
            this.butnSalvar.TabIndex = 15;
            this.butnSalvar.Text = "Incluir";
            this.butnSalvar.UseVisualStyleBackColor = false;
            this.butnSalvar.Click += new System.EventHandler(this.butnSalvar_Click);
            // 
            // butnCancelar
            // 
            this.butnCancelar.BackColor = System.Drawing.SystemColors.Info;
            this.butnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.butnCancelar.Location = new System.Drawing.Point(274, 80);
            this.butnCancelar.Name = "butnCancelar";
            this.butnCancelar.Size = new System.Drawing.Size(125, 31);
            this.butnCancelar.TabIndex = 109;
            this.butnCancelar.Text = "Cancelar";
            this.butnCancelar.UseVisualStyleBackColor = false;
            this.butnCancelar.Click += new System.EventHandler(this.butnCancelar_Click);
            // 
            // CadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(410, 123);
            this.Controls.Add(this.butnCancelar);
            this.Controls.Add(this.butnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Categoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butnSalvar;
        private System.Windows.Forms.Button butnCancelar;
    }
}