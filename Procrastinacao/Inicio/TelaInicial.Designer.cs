namespace Inicio
{
    partial class TelaInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTarefas = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.date4 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realizada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarefasToolStripMenuItem,
            this.calendárioToolStripMenuItem,
            this.dicasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tarefasToolStripMenuItem
            // 
            this.tarefasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
            this.tarefasToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.tarefasToolStripMenuItem.Text = "Nova Tarefa";
            this.tarefasToolStripMenuItem.Click += new System.EventHandler(this.tarefasToolStripMenuItem_Click);
            // 
            // calendárioToolStripMenuItem
            // 
            this.calendárioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.calendárioToolStripMenuItem.Name = "calendárioToolStripMenuItem";
            this.calendárioToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.calendárioToolStripMenuItem.Text = "Calendário";
            this.calendárioToolStripMenuItem.Click += new System.EventHandler(this.calendárioToolStripMenuItem_Click);
            // 
            // dicasToolStripMenuItem
            // 
            this.dicasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dicasToolStripMenuItem.Name = "dicasToolStripMenuItem";
            this.dicasToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.dicasToolStripMenuItem.Text = "Dicas";
            this.dicasToolStripMenuItem.Click += new System.EventHandler(this.dicasToolStripMenuItem_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl1.Location = new System.Drawing.Point(69, 53);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(346, 33);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "O que você faz durante o dia?";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTarefas);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.date4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.date3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.date2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.date1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 328);
            this.panel2.TabIndex = 9;
            // 
            // lblTarefas
            // 
            this.lblTarefas.AutoSize = true;
            this.lblTarefas.Font = new System.Drawing.Font("Calibri", 40.25F, System.Drawing.FontStyle.Bold);
            this.lblTarefas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTarefas.Location = new System.Drawing.Point(82, 49);
            this.lblTarefas.Name = "lblTarefas";
            this.lblTarefas.Size = new System.Drawing.Size(307, 132);
            this.lblTarefas.TabIndex = 10;
            this.lblTarefas.Text = "Você possui:\r\nN tarefas";
            this.lblTarefas.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(271, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 30);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date4
            // 
            this.date4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date4.Location = new System.Drawing.Point(359, 241);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(89, 26);
            this.date4.TabIndex = 15;
            this.date4.Value = new System.DateTime(2017, 5, 25, 8, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Horário";
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt4.Location = new System.Drawing.Point(7, 241);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(307, 26);
            this.txt4.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tarefa";
            // 
            // date3
            // 
            this.date3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date3.Location = new System.Drawing.Point(359, 175);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(89, 26);
            this.date3.TabIndex = 11;
            this.date3.Value = new System.DateTime(2017, 5, 25, 8, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Horário";
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt3.Location = new System.Drawing.Point(7, 175);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(307, 26);
            this.txt3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tarefa";
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date2.Location = new System.Drawing.Point(359, 107);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(89, 26);
            this.date2.TabIndex = 7;
            this.date2.Value = new System.DateTime(2017, 5, 25, 8, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horário";
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt2.Location = new System.Drawing.Point(7, 107);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(307, 26);
            this.txt2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tarefa";
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date1.Location = new System.Drawing.Point(359, 43);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(89, 26);
            this.date1.TabIndex = 3;
            this.date1.Value = new System.DateTime(2017, 5, 25, 8, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horário";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt1.Location = new System.Drawing.Point(7, 43);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(307, 26);
            this.txt1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarefa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número,
            this.Tarefa,
            this.Horário,
            this.Realizada});
            this.dataGridView1.Location = new System.Drawing.Point(18, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 415);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Número
            // 
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            // 
            // Tarefa
            // 
            this.Tarefa.HeaderText = "Tarefa";
            this.Tarefa.Name = "Tarefa";
            // 
            // Horário
            // 
            this.Horário.HeaderText = "Horário";
            this.Horário.Name = "Horário";
            // 
            // Realizada
            // 
            this.Realizada.HeaderText = "Realizada";
            this.Realizada.Name = "Realizada";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 464);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procrastinação";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tarefasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendárioToolStripMenuItem;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTarefas;
        private System.Windows.Forms.ToolStripMenuItem dicasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Realizada;
    }
}

