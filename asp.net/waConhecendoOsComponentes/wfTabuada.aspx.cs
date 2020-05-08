using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace waConhecendoOsComponentes
{
    public partial class wfTabuada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 0; i <= 10; i++)
                {
                        dlNumbers.Items.Add(i.ToString());
                }
            }
        }

        protected void btnExecutar_Click(object sender, EventArgs e)
        {
            lbDados.Items.Clear();
            ListItem numSelecionado = dlNumbers.SelectedItem;
            int numero = Convert.ToInt32(numSelecionado.Text);
            int total = 0;
            for (int j = 0; j <= 10; j++)
            {
                total = j * numero;
                lbDados.Items.Add(j.ToString() + " x " + numero.ToString() + " = " + total);
            }
        }
    }
}