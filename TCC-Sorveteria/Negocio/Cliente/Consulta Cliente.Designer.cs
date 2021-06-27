namespace TCC_Sorveteria.Negocio.Cliente
{
    partial class Consulta_Cliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desativarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ativarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbAti = new System.Windows.Forms.RadioButton();
            this.rdbIna = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.rdbIna);
            this.groupBox1.Controls.Add(this.rdbAti);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta Cliente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(434, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(72, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem,
            this.desativarToolStripMenuItem,
            this.ativarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // desativarToolStripMenuItem
            // 
            this.desativarToolStripMenuItem.Name = "desativarToolStripMenuItem";
            this.desativarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.desativarToolStripMenuItem.Text = "Desativar";
            this.desativarToolStripMenuItem.Click += new System.EventHandler(this.desativarToolStripMenuItem_Click);
            // 
            // ativarToolStripMenuItem
            // 
            this.ativarToolStripMenuItem.Name = "ativarToolStripMenuItem";
            this.ativarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ativarToolStripMenuItem.Text = "Ativar";
            this.ativarToolStripMenuItem.Click += new System.EventHandler(this.ativarToolStripMenuItem_Click);
            // 
            // rdbAti
            // 
            this.rdbAti.AutoSize = true;
            this.rdbAti.Location = new System.Drawing.Point(15, 62);
            this.rdbAti.Name = "rdbAti";
            this.rdbAti.Size = new System.Drawing.Size(62, 24);
            this.rdbAti.TabIndex = 4;
            this.rdbAti.TabStop = true;
            this.rdbAti.Text = "Ativo";
            this.rdbAti.UseVisualStyleBackColor = true;
            this.rdbAti.CheckedChanged += new System.EventHandler(this.rdbAti_CheckedChanged);
            // 
            // rdbIna
            // 
            this.rdbIna.AutoSize = true;
            this.rdbIna.Location = new System.Drawing.Point(83, 62);
            this.rdbIna.Name = "rdbIna";
            this.rdbIna.Size = new System.Drawing.Size(74, 24);
            this.rdbIna.TabIndex = 5;
            this.rdbIna.TabStop = true;
            this.rdbIna.Text = "Inativo";
            this.rdbIna.UseVisualStyleBackColor = true;
            this.rdbIna.CheckedChanged += new System.EventHandler(this.rdbIna_CheckedChanged);
            // 
            // Consulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(183)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(645, 376);
            this.Controls.Add(this.groupBox1);
            this.Name = "Consulta_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem desativarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ativarToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbIna;
        private System.Windows.Forms.RadioButton rdbAti;
    }
}