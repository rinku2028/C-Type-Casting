using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace typecast1
{
    public partial class typecast1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        { 
            txtsum.Text = Convert.ToString(Convert.ToInt32(firstnum.Text) + Convert.ToInt32(secondnum.Text));
        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            txtsum.Text = Convert.ToString(Convert.ToInt32(firstnum.Text) * Convert.ToInt32(secondnum.Text));
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            txtsum.Text = Convert.ToString(Convert.ToInt32(firstnum.Text) / Convert.ToInt32(secondnum.Text));
        }
    }
}