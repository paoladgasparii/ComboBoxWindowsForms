using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Adiciona itens manualmente no ComboBox
            cboLista.Items.Add(txtTexto.Text);

            // Exibe a quantidade de iten do ComboBox
            lblQtde.Text = cboLista.Items.Count.ToString();

            // Limpa a caixa de texto
            txtTexto.Clear();

            // Move o foco para a caixa de texto
            txtTexto.Select();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ativa a propriedade para ordenar a lista do combo
            cboLista.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                // Remove o item selecionado do combo
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);

                // Exibe a quantidade de itens do ComboBox
                lblQtde.Text = cboLista.Items.Count.ToString();

                // Limpa p texto do combo
                cboLista.ResetText();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            // Verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                // Exibe o conteúdo (texto do combo)
                txtConteudo.Text = cboLista.SelectedItem.ToString();

                // Exibe o índice (posição) do item no combo
                txtIndice.Text = cboLista.SelectedIndex.ToString();
            }
        }
    }
}
