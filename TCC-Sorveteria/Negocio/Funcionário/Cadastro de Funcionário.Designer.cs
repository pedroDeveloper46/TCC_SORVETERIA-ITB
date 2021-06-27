namespace TCC_Sorveteria.Negocio.Funcionário
{
    partial class CadastrarFuncionário
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
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNúmero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNúmero = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtSexo = new System.Windows.Forms.Label();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblTele = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butnSalvar = new System.Windows.Forms.Button();
            this.butnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtUF.Location = new System.Drawing.Point(270, 38);
            this.txtUF.Margin = new System.Windows.Forms.Padding(2);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(62, 22);
            this.txtUF.TabIndex = 104;
            this.txtUF.TextChanged += new System.EventHandler(this.txtUF_TextChanged);
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtCEP.Location = new System.Drawing.Point(70, 38);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(159, 22);
            this.txtCEP.TabIndex = 11;
            this.txtCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCEP_MaskInputRejected);
            this.txtCEP.Leave += new System.EventHandler(this.BuscarDadosCep);
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtCidade.Location = new System.Drawing.Point(439, 36);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(330, 22);
            this.txtCidade.TabIndex = 75;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtBairro.Location = new System.Drawing.Point(70, 91);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(262, 22);
            this.txtBairro.TabIndex = 74;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtComplemento.Location = new System.Drawing.Point(342, 142);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(280, 22);
            this.txtComplemento.TabIndex = 13;
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // txtNúmero
            // 
            this.txtNúmero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtNúmero.Location = new System.Drawing.Point(70, 144);
            this.txtNúmero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNúmero.Name = "txtNúmero";
            this.txtNúmero.Size = new System.Drawing.Size(102, 22);
            this.txtNúmero.TabIndex = 12;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtLogradouro.Location = new System.Drawing.Point(435, 91);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(334, 22);
            this.txtLogradouro.TabIndex = 71;
            this.txtLogradouro.TextChanged += new System.EventHandler(this.txtLogradouro_TextChanged);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblUF.Location = new System.Drawing.Point(239, 40);
            this.lblUF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(35, 20);
            this.lblUF.TabIndex = 65;
            this.lblUF.Text = "UF:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblCEP.Location = new System.Drawing.Point(11, 40);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(45, 20);
            this.lblCEP.TabIndex = 64;
            this.lblCEP.Text = "CEP:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblCidade.Location = new System.Drawing.Point(362, 40);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 63;
            this.lblCidade.Text = "Cidade:";
            this.lblCidade.Click += new System.EventHandler(this.lblCidade_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblBairro.Location = new System.Drawing.Point(11, 91);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 62;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblComplemento.Location = new System.Drawing.Point(220, 144);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(112, 20);
            this.lblComplemento.TabIndex = 61;
            this.lblComplemento.Text = "Complemento:";
            this.lblComplemento.Click += new System.EventHandler(this.lblComplemento_Click);
            // 
            // lblNúmero
            // 
            this.lblNúmero.AutoSize = true;
            this.lblNúmero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblNúmero.Location = new System.Drawing.Point(-1, 142);
            this.lblNúmero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNúmero.Name = "lblNúmero";
            this.lblNúmero.Size = new System.Drawing.Size(69, 20);
            this.lblNúmero.TabIndex = 60;
            this.lblNúmero.Text = "Número:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblLogradouro.Location = new System.Drawing.Point(336, 91);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(95, 20);
            this.lblLogradouro.TabIndex = 59;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblNome.Location = new System.Drawing.Point(24, 35);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 58;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 440);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 66;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblRG.Location = new System.Drawing.Point(266, 74);
            this.lblRG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(38, 20);
            this.lblRG.TabIndex = 68;
            this.lblRG.Text = "RG:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtNome.Location = new System.Drawing.Point(99, 32);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(600, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(166, 436);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Mask = "(00)0-0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(154, 26);
            this.txtTelefone.TabIndex = 80;
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtRG.Location = new System.Drawing.Point(310, 72);
            this.txtRG.Margin = new System.Windows.Forms.Padding(2);
            this.txtRG.Mask = "00,000,000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(148, 22);
            this.txtRG.TabIndex = 2;
            this.txtRG.Leave += new System.EventHandler(this.txtRG_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtCPF.Location = new System.Drawing.Point(99, 72);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(148, 22);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(25, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Cargo:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblCPF.Location = new System.Drawing.Point(24, 77);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 20);
            this.lblCPF.TabIndex = 69;
            this.lblCPF.Text = "CPF:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(99, 194);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.rbMasculino.Location = new System.Drawing.Point(462, 196);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbMasculino.TabIndex = 9;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // txtSexo
            // 
            this.txtSexo.AutoSize = true;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtSexo.Location = new System.Drawing.Point(313, 198);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(49, 20);
            this.txtSexo.TabIndex = 97;
            this.txtSexo.Text = "Sexo:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.rbFeminino.Location = new System.Drawing.Point(366, 196);
            this.rbFeminino.Margin = new System.Windows.Forms.Padding(2);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rbFeminino.TabIndex = 8;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(464, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "Data de Nascimento:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblCelular.Location = new System.Drawing.Point(18, 162);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(62, 20);
            this.lblCelular.TabIndex = 102;
            this.lblCelular.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtCelular.Location = new System.Drawing.Point(99, 162);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.txtCelular.Mask = "(00)0-0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(178, 22);
            this.txtCelular.TabIndex = 5;
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblTele.Location = new System.Drawing.Point(295, 162);
            this.lblTele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(75, 20);
            this.lblTele.TabIndex = 104;
            this.lblTele.Text = "Telefone:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtTel.Location = new System.Drawing.Point(376, 162);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.Mask = "(00)0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(222, 22);
            this.txtTel.TabIndex = 6;
            this.txtTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblEmail.Location = new System.Drawing.Point(24, 120);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 106;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtEmail.Location = new System.Drawing.Point(99, 120);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(499, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.lblTele);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.lblCelular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblRG);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(788, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Pessoais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.maskedTextBox1.Location = new System.Drawing.Point(627, 70);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.Leave += new System.EventHandler(this.maskedTextBox1_Leave_1);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 187);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // butnSalvar
            // 
            this.butnSalvar.BackColor = System.Drawing.SystemColors.Info;
            this.butnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.butnSalvar.Location = new System.Drawing.Point(547, 449);
            this.butnSalvar.Name = "butnSalvar";
            this.butnSalvar.Size = new System.Drawing.Size(125, 31);
            this.butnSalvar.TabIndex = 14;
            this.butnSalvar.Text = "Incluir";
            this.butnSalvar.UseVisualStyleBackColor = false;
            this.butnSalvar.Click += new System.EventHandler(this.butnSalvar_Click);
            // 
            // butnCancelar
            // 
            this.butnCancelar.BackColor = System.Drawing.SystemColors.Info;
            this.butnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.butnCancelar.Location = new System.Drawing.Point(678, 448);
            this.butnCancelar.Name = "butnCancelar";
            this.butnCancelar.Size = new System.Drawing.Size(125, 31);
            this.butnCancelar.TabIndex = 108;
            this.butnCancelar.Text = "Cancelar";
            this.butnCancelar.UseVisualStyleBackColor = false;
            this.butnCancelar.Click += new System.EventHandler(this.butnCancelar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(547, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 31);
            this.button1.TabIndex = 109;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CadastrarFuncionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(815, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butnCancelar);
            this.Controls.Add(this.butnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CadastrarFuncionário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastar Funcionário";
            this.Load += new System.EventHandler(this.CadastrarFuncionário_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.butnSalvar, 0);
            this.Controls.SetChildIndex(this.butnCancelar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNúmero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNúmero;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblRG;
       
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label txtSexo;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butnSalvar;
        private System.Windows.Forms.Button butnCancelar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Button button1;
    }
}