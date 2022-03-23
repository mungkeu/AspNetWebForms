using System;

namespace AspNetWebform
{
    public partial class Ex005 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 웹 폼에서 현재 접속자의 IP 주소 얻기
            this.Label1.Text = Request.UserHostAddress; // 추천
            this.Label2.Text = Request.ServerVariables["REMOTE_HOST"];
            this.Label3.Text = Request.ServerVariables["REMOTE_ADDR"];

        }
    }

    /*
     * Request 개체
     * 1. UserHostAddress
     * - 현재 접속자의 IP 주소 문자열을 반환한다.
     * 2. ServerVariables[]
     * - 현재 접속자의 주요 서버 환경 변숫값을 알려 준다.
     */
}