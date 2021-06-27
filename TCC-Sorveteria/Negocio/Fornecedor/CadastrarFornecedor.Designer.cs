namespace TCC_Sorveteria.Negocio.Fornecedor
{
    partial class CadastrarFornecedor
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
            this.btnNome = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblNúmero = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNúmero = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNome
            // 
            this.btnNome.AutoSize = true;
            this.btnNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.btnNome.Location = new System.Drawing.Point(4, 85);
            this.btnNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(121, 20);
            this.btnNome.TabIndex = 58;
            this.btnNome.Text = "Nome Fantasia:";
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblCelular.Location = new System.Drawing.Point(31, 163);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(62, 20);
            this.lblCelular.TabIndex = 66;
            this.lblCelular.Text = "Celular:";
            this.lblCelular.Click += new System.EventHandler(this.lblCelular_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblCPF.Location = new System.Drawing.Point(31, 125);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(53, 20);
            this.lblCPF.TabIndex = 69;
            this.lblCPF.Text = "CNPJ:";
            this.lblCPF.Click += new System.EventHandler(this.lblCPF_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtNome.Location = new System.Drawing.Point(129, 83);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(568, 22);
            this.txtNome.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Info;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.btnSalvar.Location = new System.Drawing.Point(483, 435);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(125, 31);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Incluir";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.Leave += new System.EventHandler(this.BuscarDadosCep);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.btnCancelar.Location = new System.Drawing.Point(614, 435);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 31);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtCelular.Location = new System.Drawing.Point(129, 165);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtCelular.Mask = "(00)0-0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(165, 22);
            this.txtCelular.TabIndex = 4;
            this.txtCelular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtCNPJ.Location = new System.Drawing.Point(129, 123);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtCNPJ.Mask = "00,000,000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(163, 22);
            this.txtCNPJ.TabIndex = 2;
            this.txtCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCNPJ_MaskInputRejected);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(316, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtEmail.Location = new System.Drawing.Point(377, 123);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.txtRazao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblWeb);
            this.groupBox1.Controls.Add(this.txtWeb);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCNPJ);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.lblCelular);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.btnNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(732, 233);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtRazao
            // 
            this.txtRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazao.Location = new System.Drawing.Point(129, 43);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(568, 22);
            this.txtRazao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Razão Social:";
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(15, 195);
            this.lblWeb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(78, 20);
            this.lblWeb.TabIndex = 89;
            this.lblWeb.Text = "Web Site:";
            // 
            // txtWeb
            // 
            this.txtWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtWeb.Location = new System.Drawing.Point(129, 195);
            this.txtWeb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(466, 22);
            this.txtWeb.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtTelefone.Location = new System.Drawing.Point(377, 163);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtTelefone.Mask = "(00)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(195, 22);
            this.txtTelefone.TabIndex = 5;
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(298, 165);
            this.lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(75, 20);
            this.lblTel.TabIndex = 86;
            this.lblTel.Text = "Telefone:";
            this.lblTel.Click += new System.EventHandler(this.lblTel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Controls.Add(this.txtUF);
            this.groupBox2.Controls.Add(this.lblNúmero);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.txtNúmero);
            this.groupBox2.Controls.Add(this.lblCidade);
            this.groupBox2.Controls.Add(this.lblBairro);
            this.groupBox2.Controls.Add(this.lblLogradouro);
            this.groupBox2.Controls.Add(this.lblComplemento);
            this.groupBox2.Controls.Add(this.lblUF);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.txtCEP);
            this.groupBox2.Controls.Add(this.lblCEP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox2.Location = new System.Drawing.Point(7, 250);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox2.Size = new System.Drawing.Size(732, 177);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtLogradouro.Location = new System.Drawing.Point(430, 89);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(284, 22);
            this.txtLogradouro.TabIndex = 71;
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtUF.Location = new System.Drawing.Point(266, 40);
            this.txtUF.Margin = new System.Windows.Forms.Padding(2);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(61, 22);
            this.txtUF.TabIndex = 104;
            // 
            // lblNúmero
            // 
            this.lblNúmero.AutoSize = true;
            this.lblNúmero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblNúmero.Location = new System.Drawing.Point(1, 138);
            this.lblNúmero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNúmero.Name = "lblNúmero";
            this.lblNúmero.Size = new System.Drawing.Size(69, 20);
            this.lblNúmero.TabIndex = 60;
            this.lblNúmero.Text = "Número:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtComplemento.Location = new System.Drawing.Point(325, 136);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(280, 22);
            this.txtComplemento.TabIndex = 10;
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtBairro.Location = new System.Drawing.Point(74, 89);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(253, 22);
            this.txtBairro.TabIndex = 74;
            // 
            // txtNúmero
            // 
            this.txtNúmero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtNúmero.Location = new System.Drawing.Point(74, 136);
            this.txtNúmero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNúmero.Name = "txtNúmero";
            this.txtNúmero.Size = new System.Drawing.Size(102, 22);
            this.txtNúmero.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblCidade.Location = new System.Drawing.Point(354, 43);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 63;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblBairro.Location = new System.Drawing.Point(15, 91);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 62;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblLogradouro.Location = new System.Drawing.Point(331, 91);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(95, 20);
            this.lblLogradouro.TabIndex = 59;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblComplemento.Location = new System.Drawing.Point(209, 136);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(112, 20);
            this.lblComplemento.TabIndex = 61;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblUF.Location = new System.Drawing.Point(227, 43);
            this.lblUF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(35, 20);
            this.lblUF.TabIndex = 65;
            this.lblUF.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtCidade.Location = new System.Drawing.Point(430, 41);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(284, 22);
            this.txtCidade.TabIndex = 75;
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtCEP.Location = new System.Drawing.Point(74, 41);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(145, 22);
            this.txtCEP.TabIndex = 8;
            this.txtCEP.Leave += new System.EventHandler(this.BuscarDadosCep);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblCEP.Location = new System.Drawing.Point(15, 43);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(45, 20);
            this.lblCEP.TabIndex = 64;
            this.lblCEP.Text = "CEP:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Info;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(354, 435);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(125, 31);
            this.btnAlterar.TabIndex = 107;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // CadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(747, 497);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CadastrarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedor";
            this.Load += new System.EventHandler(this.CadastrarFornecedor_Load);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnNome;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblNúmero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNúmero;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label label2;
    }
}