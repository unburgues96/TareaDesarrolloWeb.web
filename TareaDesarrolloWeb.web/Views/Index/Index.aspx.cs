using System;

namespace TareaDesarrolloWeb.web.Views.Index
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["SessionUser"] == null)
                {
                    Response.Redirect("../Login/Login.aspx");
                }
            }
        }
    }
}