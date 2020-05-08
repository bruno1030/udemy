using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waConhecendoOsComponentes
{
    public partial class wfComponentes1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            //dlSite.Items.Add(txtSite.Text);
            ListItem item = new ListItem(txtSite.Text, dlSite.Items.Count.ToString());
            dlSite.Items.Add(item);
            txtSite.Text = "";

            item = new ListItem(txtEndereco.Text, lbEndereco.Items.Count.ToString());
            lbEndereco.Items.Add(item);
            txtEndereco.Text = "";

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSelecionar_Click(object sender, EventArgs e)
        {
            ListItem item = dlSite.SelectedItem;
            txtSite.Text = item.Text;
            item = lbEndereco.SelectedItem;
            txtEndereco.Text = item.Text;
        }
    }
}