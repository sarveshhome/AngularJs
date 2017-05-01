using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AngularjsProj
{
    public partial class angularpagebind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //string strEmailBody = prepareEmailData();

            }
        }
        protected string prepareEmailData()
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htmlTW = new HtmlTextWriter(sw);
            f.RenderControl(htmlTW);
            string strBookingData = sb.ToString();

            string strEmailHeader = "<html>";
            strBookingData = strBookingData.Replace("<form method=\"post\" action=\"./angularpagebind\" id=\"f\">", "");
            strBookingData = strBookingData.Replace("<input type=\"hidden\" name=\"__VIEWSTATE\" id=\"__VIEWSTATE\" value=\"\" />", "");
            strBookingData = strBookingData.Replace("</form>", "");

            string strEmailData = strEmailHeader.ToString() + strBookingData.ToString() + "</html>";
            return strEmailData;
        }
    }
}