using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WarlockSocial
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        WebService1.WebServiceFase2 conex = new WebService1.WebServiceFase2();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(TextBox1);
            string b = Convert.ToString(TextBox2);
            string c = Convert.ToString(TextBox3);
            string d = Convert.ToString(TextBox4);
            conex.RegistrarUsuario(a, b, c, d);
        }
    }
}