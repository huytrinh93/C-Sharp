using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SummerBreeze
{
	public partial class Page5_OOP : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
        protected void Button1_Click(object sender, EventArgs e)
        {
            var instance = new SomeObject();
            Textbox1.Text = String.Concat(instance.method1() + " ", ddlChangeThisNameToddlsomething.Text) + ", " + String.Concat(instance.method2() + " ", txtString.Text);
        }
	}
}