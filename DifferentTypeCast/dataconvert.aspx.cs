using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace conversion
{
    public partial class dataconvert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtfirstnum.Text)&& (!String.IsNullOrEmpty(txtsecondnum.Text)))
            {
                int x = Convert.ToInt32(txtfirstnum.Text);
                int y = Convert.ToInt32(txtsecondnum.Text);
                int sum = x + y;
                lblmessage.Text="Sum of"+ "\t" + txtfirstnum.Text.ToString() + "\t" + "and" +"\t" + txtsecondnum.Text.ToString()+"\t" +":"+ sum.ToString();
            }
            else
            {
                lblmessage.Text = "Please enter values in the textboxes!";
                //lblmessage.Text=System.Drawing.Color.Red;

            }

        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtfirstnum.Text)&&(!String.IsNullOrEmpty(txtsecondnum.Text)))
            {
                int x = Convert.ToInt32(txtfirstnum.Text);
                int y = Convert.ToInt32(txtsecondnum.Text);
                int mul = x / y;
                lblmessage.Text = "Multipliation of" + "\t" + txtfirstnum.Text.ToString() + "\t" + "and" + "\t" + txtsecondnum.Text.ToString() + "\t" + ":" + mul.ToString();


            }
            else
            {
                lblmessage.Text = "Please enter values in the textboxes!!";
            }
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtfirstnum.Text);
            int y = Convert.ToSByte(txtsecondnum.Text);
            int div = x / y;
            if(!String.IsNullOrEmpty(txtfirstnum.Text)&& (!String.IsNullOrEmpty(txtsecondnum.Text)))
            {
                lblmessage.Text = "Divide of" + "\t" + txtfirstnum.Text.ToString() + "\t"+ "and" +"\t"+ txtsecondnum.Text.ToString() + "\t" + ":" + div.ToString();
            }
            else
            {
                lblmessage.Text = "Please enter values in the textboxes!!";
            }

        }
    }
}