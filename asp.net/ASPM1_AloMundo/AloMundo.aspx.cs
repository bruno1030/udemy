using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPM1_AloMundo
{
    public partial class AloMundo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btExecutar_Click(object sender, EventArgs e)
        {
            if (msgText.Text == "")
            {
                lMsg.Text = "<h1>Alo Mundo - Aula 1</h1>";
            }
            else
            {
                lMsg.Text = "<h1>" + msgText.Text + "</h1>";
            }
        }
    }
}