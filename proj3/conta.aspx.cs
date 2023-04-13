using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proj3 {
   public partial class conta : System.Web.UI.Page {
      protected void Page_Load(object sender, EventArgs e) {
        
      }

      protected void btnCriarConta_Click(object sender, EventArgs e) {
          try {
                string i = txtNum.Text;
                decimal saldo = Convert.ToDecimal(txtSaldo.Text);
                ContaBancaria cta1 = new ContaBancaria(Convert.ToInt32(i), saldo);
                Session.Add("conta", cta1);
                lblGeral.Text = "Conta Criada!";
            }
            catch (Exception ex){
                lblGeral.Text = "Erro: " + ex.Message;
            }

      }

    protected void btnDebitar_Click(object sender, EventArgs e) {
          try {
                decimal vlrMovimentacao = Convert.ToDecimal(txtMov.Text);
                ContaBancaria cta1 = (ContaBancaria)Session["conta"];
                cta1.debitar(vlrMovimentacao);
                txtSaldo.Text = cta1.Saldo.ToString();
                lblGeral.Text = "Débito Efetuado";
            }
            catch (Exception ex) {
                lblGeral.Text = "Erro: " + ex.Message;
            }
      }

      protected void btnCreditar_Click(object sender, EventArgs e)
      {
          try {
                decimal vlrMovimentacao = Convert.ToDecimal(txtMov.Text);
                ContaBancaria cta1 = (ContaBancaria)Session["conta"];
                cta1.creditar(vlrMovimentacao);
                txtSaldo.Text = cta1.Saldo.ToString();
                lblGeral.Text = "Débito Efetuado";



            }
            catch (Exception ex) {
                lblGeral.Text = "Erro: " + ex.Message;
            }
      }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            ContaBancaria cta1 = (ContaBancaria)Session["conta"];
            decimal saldo = Convert.ToDecimal(txtSaldo.Text)*0;
            txtSaldo.Text = Convert.ToString(saldo);
            txtMov.Text = Convert.ToString(0);
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            ContaBancaria cta1 = (ContaBancaria)Session["conta"];
            string i = Convert.ToString(cta1.Saldo);
            lblGeral.Text = "Saldo da conta " + i;
        }
    }
}
