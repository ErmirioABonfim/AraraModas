using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraraModas
{
    public partial class frmCadastroDeProdutos : Form
    {
        public frmCadastroDeProdutos()
        {
            InitializeComponent();
            CriarColunas();
        }

        int iSelecionado = -1;
        private void CriarColunas()
        {
            lsbProdutos.Clear();
            lsbProdutos.Columns.Insert(0, "Nome", 250, HorizontalAlignment.Left );
            lsbProdutos.Columns.Insert(1, "Cor", 250, HorizontalAlignment.Left);
            lsbProdutos.Columns.Insert(2, "Sexo", 50, HorizontalAlignment.Left);
            lsbProdutos.Columns.Insert(3, "Tamanho", 50, HorizontalAlignment.Left);
            lsbProdutos.Columns.Insert(4, "Descrição", 350, HorizontalAlignment.Left);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {

            if (txtNomeProduto.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nome Inválido");
                txtNomeProduto.Focus();

            }

            else
            {
                ListViewItem itmx = lsbProdutos.Items.Add(txtNomeProduto.Text.Trim());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, txtCor.Text.Trim()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, cbxSexo.Text.Trim()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, cbxTamanho.Text.Trim()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, cbxDescricao.Text.Trim()));

                txtNomeProduto.Text = String.Empty;
                txtCor.Text = String.Empty;
                cbxDescricao.Text = String.Empty;
                cbxSexo.Text = String.Empty;
                cbxTamanho.Text = String.Empty;

            }



        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNomeProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInserir_Click_1(btnInserir, new EventArgs());
            }
        }

        private void txtNomeProduto_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void cbxDescricao_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (lsbProdutos.FocusedItem.Index < 0)
            {
                MessageBox.Show("Nem um item para remover");
            }
            else
            {
                iSelecionado = lsbProdutos.FocusedItem.Index;
                lsbProdutos.Items.RemoveAt(iSelecionado);
                iSelecionado = -1;

            }
            
        }

        private void lsbProdutos_Validating(object sender, CancelEventArgs e)
        {
            iSelecionado = lsbProdutos.FocusedItem.Index;
            if (iSelecionado > -1)
            {
                btnInserir.Text = ("Alterar");
            }
        }
    }
}
