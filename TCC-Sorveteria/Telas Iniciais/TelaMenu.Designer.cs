namespace TCC_Sorveteria.Telas_Iniciais
{
    partial class TelaMenu
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.posição1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cupomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarQRCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faleConoscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responderClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.consultarCupomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posição1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 621);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // posição1
            // 
            this.posição1.BackColor = System.Drawing.SystemColors.Control;
            this.posição1.Name = "posição1";
            this.posição1.Size = new System.Drawing.Size(27, 20);
            this.posição1.Text = "p1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(163, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(163, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.cupomToolStripMenuItem,
            this.faleConoscoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedorToolStripMenuItem1,
            this.funcionárioToolStripMenuItem1,
            this.produtoToolStripMenuItem1,
            this.loginToolStripMenuItem1,
            this.clienteToolStripMenuItem,
            this.usuárioClienteToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.fornecedorToolStripMenuItem1_Click);
            // 
            // funcionárioToolStripMenuItem1
            // 
            this.funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
            this.funcionárioToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            this.funcionárioToolStripMenuItem1.Text = "Funcionário";
            this.funcionárioToolStripMenuItem1.Click += new System.EventHandler(this.funcionárioToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            this.loginToolStripMenuItem1.Text = "Login";
            this.loginToolStripMenuItem1.Click += new System.EventHandler(this.loginToolStripMenuItem1_Click_1);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // usuárioClienteToolStripMenuItem
            // 
            this.usuárioClienteToolStripMenuItem.Name = "usuárioClienteToolStripMenuItem";
            this.usuárioClienteToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.usuárioClienteToolStripMenuItem.Text = "Usuário Cliente";
            this.usuárioClienteToolStripMenuItem.Click += new System.EventHandler(this.usuárioClienteToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedorToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.vendasToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.contasToolStripMenuItem1,
            this.usuarioClienteToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.vendasToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // contasToolStripMenuItem1
            // 
            this.contasToolStripMenuItem1.Name = "contasToolStripMenuItem1";
            this.contasToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            this.contasToolStripMenuItem1.Text = "Contas";
            this.contasToolStripMenuItem1.Click += new System.EventHandler(this.contasToolStripMenuItem1_Click);
            // 
            // usuarioClienteToolStripMenuItem
            // 
            this.usuarioClienteToolStripMenuItem.Name = "usuarioClienteToolStripMenuItem";
            this.usuarioClienteToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.usuarioClienteToolStripMenuItem.Text = "Usuario Cliente";
            this.usuarioClienteToolStripMenuItem.Click += new System.EventHandler(this.usuarioClienteToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem2,
            this.entradaDeProdutosToolStripMenuItem,
            this.contasToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.vendasToolStripMenuItem.Text = "Gestão";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem2
            // 
            this.vendasToolStripMenuItem2.Name = "vendasToolStripMenuItem2";
            this.vendasToolStripMenuItem2.Size = new System.Drawing.Size(225, 24);
            this.vendasToolStripMenuItem2.Text = "Vendas";
            this.vendasToolStripMenuItem2.Click += new System.EventHandler(this.vendasToolStripMenuItem2_Click);
            // 
            // entradaDeProdutosToolStripMenuItem
            // 
            this.entradaDeProdutosToolStripMenuItem.Name = "entradaDeProdutosToolStripMenuItem";
            this.entradaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.entradaDeProdutosToolStripMenuItem.Text = "Entrada de Produtos";
            this.entradaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProdutosToolStripMenuItem_Click);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.contasToolStripMenuItem.Text = "Contas a Pagar";
            this.contasToolStripMenuItem.Click += new System.EventHandler(this.contasToolStripMenuItem_Click);
            // 
            // cupomToolStripMenuItem
            // 
            this.cupomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarQRCodeToolStripMenuItem,
            this.consultarCupomToolStripMenuItem});
            this.cupomToolStripMenuItem.Name = "cupomToolStripMenuItem";
            this.cupomToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.cupomToolStripMenuItem.Text = "Cupom";
            // 
            // gerarQRCodeToolStripMenuItem
            // 
            this.gerarQRCodeToolStripMenuItem.Name = "gerarQRCodeToolStripMenuItem";
            this.gerarQRCodeToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.gerarQRCodeToolStripMenuItem.Text = "Gerar Cupom";
            this.gerarQRCodeToolStripMenuItem.Click += new System.EventHandler(this.gerarQRCodeToolStripMenuItem_Click);
            // 
            // faleConoscoToolStripMenuItem
            // 
            this.faleConoscoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.responderClientesToolStripMenuItem});
            this.faleConoscoToolStripMenuItem.Name = "faleConoscoToolStripMenuItem";
            this.faleConoscoToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.faleConoscoToolStripMenuItem.Text = "Fale Conosco";
            // 
            // responderClientesToolStripMenuItem
            // 
            this.responderClientesToolStripMenuItem.Name = "responderClientesToolStripMenuItem";
            this.responderClientesToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.responderClientesToolStripMenuItem.Text = "Responder Clientes";
            this.responderClientesToolStripMenuItem.Click += new System.EventHandler(this.responderClientesToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Relogio);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(911, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // consultarCupomToolStripMenuItem
            // 
            this.consultarCupomToolStripMenuItem.Name = "consultarCupomToolStripMenuItem";
            this.consultarCupomToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.consultarCupomToolStripMenuItem.Text = "Consultar Cupom";
            this.consultarCupomToolStripMenuItem.Click += new System.EventHandler(this.consultarCupomToolStripMenuItem_Click);
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::TCC_Sorveteria.Properties.Resources.Sorveteria__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem1;
        public System.Windows.Forms.ToolStripStatusLabel posição1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cupomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarQRCodeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem faleConoscoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responderClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuarioClienteToolStripMenuItem;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem usuárioClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCupomToolStripMenuItem;
    }
}