using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebform
{
    public partial class Ex004 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserId = "";
            string strPassword = String.Empty;
            string strName = "";
            string strAge = String.Empty;

            // [1] Request 객체의 QueryString 컬렉션
            strUserId = Request.QueryString["UserID"];
            // [2] Request 객체의 Params 컬렉션
            strPassword = Request.Params["Password"];
            // [3] Request 객체의 Form 컬렉션
            strName = Request.Form["Name"];
            // [4] Request 객체 자체로 받기
            strAge = Request["Age"];

            string strMsg = String.Format(
                "입력하신 아이디는 {0}이고<br />"
                + "암호는 {1}입니다.<br />"
                + "이름은 {2}이고,<br />"
                + "나이는 {3}살 입니다.<br />",
                strUserId, strPassword, strName, strAge);
            Response.Write(strMsg);
        }

        protected void btnSubmet_Click(object sender, EventArgs e)
        {
            // ASP.NET에서는 Request 개체보다는 컨트롤의 속성을 사용해서 값을 받는다.
            string name = Name.Text;
            int age = Convert.ToInt16(Age.Text);
        }

        protected void UserID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Name_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
 * Request 개체
 * 1. QueryString[]
 * - Get 방식으로 넘어온 쿼리스트링 값인key와 value를 받고자 할 때 사용한다.
 * 2. Form[]
 * - Post 방식으로 넘어온 key와 value 값을 받고자 할 때 사용한다.
 * 3. Params[]
 * - 사용자에게 전송된 Get/Post 방식을 모두 받고자 할 때 사용한다.
 * 4. UserHostAddress
 * - 현재 접속자의 IP 주소 문자열을 반환한다.
 * 5. ServerVariables[]
 * - 현재 접속자의 주요 서버 환경 변숫값을 알려 준다.
 * 6. Cookies[]
 * - 저장된 쿠키 값을 읽어 온다.
 * 7. Url
 * - 현재 웹 페이지의 URL을 반환한다.
 * 8. PhysicalApplicationPath
 * - 현재 웹 사이트의 가상 디렉터리의 물리적인 경로를 알려 준다.
 */