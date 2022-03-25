using System;

namespace AspNetWebform
{
    public partial class Ex003 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Naver_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.naver.com/");
        }

        protected void btnYoutube_Click(object sender, EventArgs e)
        {
            string strUrl = "http://www.youtube.com";
            Response.Redirect(strUrl);
        }

        protected void btnGoogle_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string strUrl = String.Format(
                "http://{0}/{1}?{2}={3}",
                "www.google.com",
                "default.htm", "UserId", "RedPlus");
            Response.Redirect(strUrl);
        }
    }
}

/*
 * Response 개체
 * 1. Redirect()
 * - 저장된 페이지로 이동한다.
 */