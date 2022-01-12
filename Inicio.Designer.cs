
namespace AnaliseDeComposicaoCorporal
{
    partial class Inicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.efetuarNovaAnaliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAnalisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarUltimaAnaliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoDeAnalisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efetuarNovaAnaliseToolStripMenuItem,
            this.registroDeAnalisesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // efetuarNovaAnaliseToolStripMenuItem
            // 
            this.efetuarNovaAnaliseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.efetuarNovaAnaliseToolStripMenuItem.Name = "efetuarNovaAnaliseToolStripMenuItem";
            this.efetuarNovaAnaliseToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.efetuarNovaAnaliseToolStripMenuItem.Text = "Efetuar Nova Analise";
            this.efetuarNovaAnaliseToolStripMenuItem.Click += new System.EventHandler(this.efetuarNovaAnaliseToolStripMenuItem_Click);
            // 
            // registroDeAnalisesToolStripMenuItem
            // 
            this.registroDeAnalisesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.registroDeAnalisesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarUltimaAnaliseToolStripMenuItem,
            this.historicoDeAnalisesToolStripMenuItem});
            this.registroDeAnalisesToolStripMenuItem.Name = "registroDeAnalisesToolStripMenuItem";
            this.registroDeAnalisesToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.registroDeAnalisesToolStripMenuItem.Text = "Registro De Analises";
            // 
            // restaurarUltimaAnaliseToolStripMenuItem
            // 
            this.restaurarUltimaAnaliseToolStripMenuItem.Name = "restaurarUltimaAnaliseToolStripMenuItem";
            this.restaurarUltimaAnaliseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.restaurarUltimaAnaliseToolStripMenuItem.Text = "Restaurar Ultima Analise";
            // 
            // historicoDeAnalisesToolStripMenuItem
            // 
            this.historicoDeAnalisesToolStripMenuItem.Name = "historicoDeAnalisesToolStripMenuItem";
            this.historicoDeAnalisesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.historicoDeAnalisesToolStripMenuItem.Text = "Historico De Analises";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 523);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historico De Analises:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(453, 498);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clique no arquivo para saber mais informações";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Historico";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 450;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analise de Composição Corporal";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem efetuarNovaAnaliseToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem registroDeAnalisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarUltimaAnaliseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoDeAnalisesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}