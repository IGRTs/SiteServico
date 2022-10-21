using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pesqServicosaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["logado"]==null) ||
            ((int)Session["logado"] != 1))
        {
            Response.Redirect("login.aspx");
        } 
    }

    protected void Pesquisa()
    {
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet dt = new DataSet();
        Conexao c = new Conexao();
        c.conectar();
        String serv = "%" + TextBoxNome.Text + "%";
        String sql = "select * from servico where " +
            "nome like @serv";
        c.command.CommandText = sql;
        c.command.Parameters.Add("@serv", SqlDbType.VarChar).Value = serv;
        dAdapter.SelectCommand = c.command;
        dAdapter.Fill(dt);
        c.fechaConexao();
        DataGrid1.DataSource = dt;
        DataGrid1.DataBind();
    }

    protected void ButtonPesquisar_Click(object sender, EventArgs e)
    {
        
        Pesquisa();
    }

    protected void DataGrid1_DeleteCommand(object source, DataGridCommandEventArgs e)
    {
        int cod= Convert.ToInt32 (e.Item.Cells[0].Text);
        Conexao c = new Conexao();
        c.conectar();
        String sql = "delete from servico where codigo=@cod";
        c.command.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
        c.command.CommandText = sql;
        c.command.ExecuteNonQuery();
        c.fechaConexao();
        Pesquisa();
    }

    protected void DataGrid1_EditCommand(object source, DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = e.Item.ItemIndex;
        Pesquisa();
    }

    protected void DataGrid1_CancelCommand(object source, DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = -1;
        Pesquisa();
    }

    protected void DataGrid1_UpdateCommand(object source, DataGridCommandEventArgs e)
    {
        String serv;
        Decimal preco;
        int cod;
        cod = Convert.ToInt32(e.Item.Cells[0].Text);
        serv = ((TextBox)Convert.ChangeType(e.Item.Cells[1].Controls[0], typeof(TextBox))).Text;
        preco = Convert.ToDecimal(((TextBox)Convert.ChangeType(e.Item.Cells[2].Controls[0], typeof(TextBox))).Text);
        String sql;
        Conexao c = new Conexao();
        c.conectar();
        sql = "update servico set nome=@serv, preco=@preco where codigo=@cod";
        c.command.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
        c.command.Parameters.Add("@serv", SqlDbType.VarChar).Value = serv;
        c.command.Parameters.Add("@preco", SqlDbType.Decimal).Value = preco;
        c.command.CommandText = sql;
        c.command.ExecuteNonQuery();
        c.fechaConexao();
        DataGrid1.EditItemIndex = -1;
        Pesquisa();

    }
}