using System;

namespace AspNetWebform.chapter05
{
    public partial class Ex005 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Naver_Click(object sender, EventArgs e)
        {
            // 네이버로 이동
            Response.Redirect("http://www.naver.com/");
        }
    }
}

/*
 * LinkButton 컨트롤
 * - 모양은 하이퍼링크이지만, 기능은 버튼과 같다.
 */