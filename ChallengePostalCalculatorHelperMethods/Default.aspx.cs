using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
               ViewState.Add("MyValue", "");
            }
            
        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            string value = ViewState["MyValue"].ToString();
            value = widthTextBox.Text;
            ViewState["MyValue"] = value;
            resultLabel.Text = "in width event ..." + value;
           
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            resultLabel.Text = "in ground event";
        }
                
        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            resultLabel.Text = "in air event";
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            resultLabel.Text = "length event";
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            string value = ViewState["MyValue"].ToString();
            value = heightTextBox.Text;
            ViewState["MyValue"] = value;
            resultLabel.Text = "in height event ..." + value;
        }
    }
}