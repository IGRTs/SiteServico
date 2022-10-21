using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class novoServico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["logado"] == null) ||
            ((int)Session["logado"] != 1))
        {
            Response.Redirect("login.aspx");
        }
        else{
            LabelMensagem.Text = "olá, " +
                Session["usuario"];

        }

    }



    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Conexao c = new Conexao();
        c.conectar();
        String nome;
        Decimal preco;
        nome = TextBoxNome.Text.Trim();
        preco = Convert.ToDecimal(TextBoxPreco.Text);
        String sql = 
            "insert into servico(nome,preco) " + 
            "values(@serv,@preco)";
        c.command.CommandText = sql;
        c.command.Parameters.Add
            ("@serv", SqlDbType.VarChar).Value = nome;
        c.command.Parameters.Add
            ("@preco", SqlDbType.Decimal).Value = preco;
        c.command.ExecuteNonQuery();
        c.fechaConexao();
    }
}