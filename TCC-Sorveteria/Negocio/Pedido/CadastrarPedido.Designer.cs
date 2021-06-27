namespace TCC_Sorveteria.Negocio.Pedido
{
    partial class CadastrarPedido
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
            this.lblFuncionário = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigoFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreço = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudQuant = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListaInativo = new System.Windows.Forms.CheckBox();
            this.chkListaAtivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncionário
            // 
            this.lblFuncionário.AutoSize = true;
            this.lblFuncionário.Font = new System.Drawing.Font("Lucida Bright", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionário.Location = new System.Drawing.Point(309, 9);
            this.lblFuncionário.Name = "lblFuncionário";
            this.lblFuncionário.Size = new System.Drawing.Size(122, 36);
            this.lblFuncionário.TabIndex = 5;
            this.lblFuncionário.Text = "Pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.chkListaInativo);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.chkListaAtivo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCodigoFunc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPreço);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudQuant);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 322);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancelar.Location = new System.Drawing.Point(541, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 42);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Info;
            this.btnSalvar.Location = new System.Drawing.Point(410, 274);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(125, 42);
            this.btnSalvar.TabIndex = 80;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(114, 64);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(275, 179);
            this.txtDescricao.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(79, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 30);
            this.txtNome.TabIndex = 14;
            // 
            // txtCodigoFunc
            // 
            this.txtCodigoFunc.Location = new System.Drawing.Point(605, 64);
            this.txtCodigoFunc.Name = "txtCodigoFunc";
            this.txtCodigoFunc.Size = new System.Drawing.Size(82, 30);
            this.txtCodigoFunc.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Código Funcionario:";
            // 
            // txtPreço
            // 
            this.txtPreço.Location = new System.Drawing.Point(476, 23);
            this.txtPreço.Mask = "$ 00.00";
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(100, 30);
            this.txtPreço.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preço:";
            // 
            // nudQuant
            // 
            this.nudQuant.Location = new System.Drawing.Point(133, 260);
            this.nudQuant.Name = "nudQuant";
            this.nudQuant.Size = new System.Drawing.Size(43, 30);
            this.nudQuant.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // chkListaInativo
            // 
            this.chkListaInativo.AutoSize = true;
            this.chkListaInativo.Checked = true;
            this.chkListaInativo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkListaInativo.Location = new System.Drawing.Point(482, 146);
            this.chkListaInativo.Name = "chkListaInativo";
            this.chkListaInativo.Size = new System.Drawing.Size(93, 26);
            this.chkListaInativo.TabIndex = 90;
            this.chkListaInativo.Text = "Inativo";
            this.chkListaInativo.UseVisualStyleBackColor = true;
            this.chkListaInativo.Visible = false;
            // 
            // chkListaAtivo
            // 
            this.chkListaAtivo.AutoSize = true;
            this.chkListaAtivo.Checked = true;
            this.chkListaAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkListaAtivo.Location = new System.Drawing.Point(482, 114);
            this.chkListaAtivo.Name = "chkListaAtivo";
            this.chkListaAtivo.Size = new System.Drawing.Size(78, 26);
            this.chkListaAtivo.TabIndex = 89;
            this.chkListaAtivo.Text = "Ativo";
            this.chkListaAtivo.UseVisualStyleBackColor = true;
            this.chkListaAtivo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 88;
            this.label6.Text = "Status:";
            // 
            // CadastrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFuncionário);
            this.Name = "CadastrarPedido";
            this.Text = "Cadastar Pedido";
            this.Controls.SetChildIndex(this.lblFuncionário, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncionário;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtPreço;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigoFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.CheckBox chkListaInativo;
        public System.Windows.Forms.CheckBox chkListaAtivo;
        private System.Windows.Forms.Label label6;
    }
}