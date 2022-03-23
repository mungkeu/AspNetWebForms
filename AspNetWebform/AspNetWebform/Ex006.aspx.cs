using System;

namespace AspNetWebform
{
    public partial class Ex006 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 현재 웹 폼의 서버측의 물리적 경로
            this.Label1.Text = Server.MapPath("."); // 같은 경로
            // 현재 스크립ㅌ ㅡ파일의 루트 경로
            this.Label2.Text = Request.ServerVariables["SCRIPT_NAME"];
        }
    }
}
/*
 * Server 개체
 * 1. MapPath(".")
 * - 현재 파일과 같은 경로 값 반환
 *  ",".".../" 식으로 원하는 경로의 물리적 경로를 받아 올 수 있다.
 * 2. Execute()
 * - 다른 파일 포함 후 제어권이 돌아온다.
 * 3. Transfer()
 * - 다른 파일 포함(인클루드) 후 제어권을 넘긴다.
 * 4. UrlPathEncode()
 * - 넘어온 쿼리스트링을 유니코드로 변환(한글 처리)
 * 5. ScriptTimeout
 * - 서버에서 현재 aspx 페이지를 몇 초간 처리할 건지 설정
 * 
 * URI와 URL
 * - URI 또는 URL은 인터넷에서 특정 자원에 접근할 때 사용되는 경로를 말한다.
 * UNC
 * - 로컬 네트워크 환경에서의 특정 자원에 접근할 때 사용되는 경로를 말한다.
 * - UNC:\\FileServer\Documents\FTP\Manual.txt
 */