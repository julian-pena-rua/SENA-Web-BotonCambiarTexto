using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] nombres = { "julian", "andres", "sara", "ana" };
        Usuario usuario = new Usuario();
        Random random = new Random();
        usuario.Nombre = nombres[random.Next(0,4)];
        Label1.Text = usuario.Nombre;
    }
}