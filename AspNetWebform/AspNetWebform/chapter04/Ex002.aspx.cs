using System;

namespace AspNetWebform
{
    public partial class Ex002 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // [0] 현재 페이지를 매번 새로 읽어옴
            Response.Expires = -1;
            // [1] 버퍼링 사용
            Response.Buffer = true;
            // [2] 화면 글쓰기
            Response.Write("[1] 현재 글은 보여진다.<br />");
            // [3] 현재 버퍼에 있는 내용 출력
            Response.Flush();
            // [4] 화면 글쓰기
            Response.Write("[2] 현재 글은 안 보여진다.<br />");
            // [5] 현재 버퍼 내용 비우기
            Response.Clear();
            // [6] 문자열 출력
            Response.Write("[3] 보여진다.<br />");
            // [7] 현재 페이지 종료
            Response.End(); // Response.Flush()+End()
            // [8] 문자열 출력
            Response.Write("[4] 실행이 안된다.<br />");
        }
    }
}
/*
 * Response 개체
 * 1. Write()
  * - 페이지에 문자열을 출력한다.
 * 2. Exprires
 * - 현재 페이지와 소멸 시간을 설정한다.
 * 3. Buffer
 * - 버퍼링 사용 여부를 결정한다.
 * 4. Flush()
 * - 현재 버퍼의 내용을 출력한다.
 * 5. Clear()
 * - 현재 버퍼의 내용을 비운다.
 * 6. End()
 * - 현재 페이지를 종료한다.
 * - End() 메서드 이후의 코드는 실행하지 않는다.
 */