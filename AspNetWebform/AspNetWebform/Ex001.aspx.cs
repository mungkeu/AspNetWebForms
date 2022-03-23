using System;

namespace AspNetWebform
{
    public partial class Ex001 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("안녕하세요.<br />");
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            Response.Write("<span style='color:blue;'>반갑습니다.</span><br />");
        }

        protected void btnJavaScript_Click(object sender, EventArgs e)
        {
            string strJs = @"<script language='javascript'>window.alert('안녕');</script>";
            Response.Write(strJs);
        }        
    }
}

/*
 * Response 개체
 * 1. Write()
 * - 페이지에 문자열을 출력한다.
 * - HTML을 포함해 자바스크립트를 실행할 수도 있다.
 * 2. Redirect()
 * - 저장된 페이지로 이동한다.
 * 3. Exprires
 * - 현재 페이지와 소멸 시간을 설정한다.
 * 4. Buffer
 * - 버퍼링 사용 여부를 결정한다.
 * 5. Flush()
 * - 현재 버퍼의 내용을 출력한다.
 * 6. Clear()
 * - 현재 버퍼의 내용을 비운다.
 * 7. End()
 * - 현재 페이지를 종료한다.
 * - End() 메서드 이후의 코드는 실행하지 않는다.
 * 8.WriteFile()
 * - 스트림(파일)을 출력한다.
 * 9. Cookies
 * - 쿠키를 저장한다.
 * 
 * 쿠키
 * - 웹 서버가 웹 브라우저에 보내서 저장했다가 서버의 요청이 있을 때 다시 서버로 보내주는 문자열 정보
 * - 사용자가 특정 웹 사이트에 접속했을 때 관련 기록을 남겨 놓았다가 다음에 같은 웹 사이트에 접속하면
 * - 남겨둔 기록을 읽어 이전 상태로 유지하는 역할을 한다.
 * - 쿠키는 클라이언트 컴퓨터의 웹 브라우저에서 저장하는 데이터
 * 세션
 * - 서버에 저장하는 데이터
 */