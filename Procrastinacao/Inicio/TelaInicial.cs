using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class TelaInicial : Form
    {

        private int i = 0, j = 1;
        private int tarefa = 0;

        public TelaInicial()
        {
            InitializeComponent();
        }
        
        //botão salvar
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(txt1.Text != "")
            {
                adicionarValores(txt1.Text, date1.Text); 
            }
            if (txt2.Text != "")
            {
                adicionarValores(txt2.Text, date2.Text);
            }
            if (txt3.Text != "")
            {
                adicionarValores(txt3.Text, date3.Text);
            }
            if (txt4.Text != "")
            {
                adicionarValores(txt4.Text, date4.Text);
            }

            EsconderComponentes();
            lblTarefas.Text = "Você possui:\n" + tarefa + " Tarefas";
            lblTarefas.Visible = true;
            limparCampos();
        }

        private void adicionarValores(String txt, String date)
        {
            tarefa++;
            dataGridView1.Rows.Insert(i, j++, txt, date, "Não");
            i++;
        }

        private void EsconderComponentes()
        {
            lbl1.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;
            date1.Visible = false;
            date2.Visible = false;
            date3.Visible = false;
            date4.Visible = false;
            btnCancelar.Visible = false;
            button1.Visible = false;
            
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            
        }

        private void ExibirComponentes()
        {
            lbl1.Visible = true;
            txt1.Visible = true;
            txt2.Visible = true;
            txt3.Visible = true;
            txt4.Visible = true;
            date1.Visible = true;
            date2.Visible = true;
            date3.Visible = true;
            date4.Visible = true;
            btnCancelar.Visible = true;
            button1.Visible = true;

            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            dataGridView1.Visible = false;
        }

        private void limparCampos()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void dicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acesse calendário para ver suas tarefas!!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new Time(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).ShowDialog();
            dataGridView1.Rows[e.RowIndex].Cells[3].Value = "Sim";
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirComponentes();
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EsconderComponentes();
            lblTarefas.Visible = false;
            dataGridView1.Visible = true;
        }
    }
}
