using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new irixi_mfg_module_Entities())
            {
                var login_user = db.user.FirstOrDefault(u => u.workid == txtWorkID.Value);

                if (login_user == null)
                {

                }
                else
                {
                    // check password.
                    if (login_user.password != txtPassword.Value)
                    {
                        // password is error.
                    }
                    else
                    {
                        // successful!
                        Response.Write("Login Successfully!");
                    }
                }
            }
        }
    }
}