using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonEnviar_Click(object sender, EventArgs e)
    {
        Conexao c = new Conexao();
        c.conectar();
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet dt = new DataSet();
        c.command.CommandText = "select * from usuario where " + 
            " login=@login and senha=@senha";
        c.command.Parameters.Add("@login", SqlDbType.VarChar).Value = TextBoxLogin.Text.Trim();
        c.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = TextBoxSenha.Text.Trim();
        dAdapter.SelectCommand = c.command;
        dAdapter.Fill(dt);
        if ((int)dt.Tables[0].DefaultView.Count == 1)
        {
            Session["logado"] = 1;
            Session["codigoUsuario"]=Convert.ToInt32(
                dt.Tables[0].
                DefaultView[0].Row["codigo"].ToString()
                );
            Session["usuario"] =
                dt.Tables[0].DefaultView[0].
                Row["login"].ToString();
            Response.Redirect("pesqServicosaspx.aspx");
        }
        else
        {
            LabelResposta.Text="Usuário incorreto";
        }
    }
}
