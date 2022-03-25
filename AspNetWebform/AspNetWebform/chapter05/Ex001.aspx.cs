using System;

namespace AspNetWebform.chapter05
{
    public partial class Ex001 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnHtml.Value = "HTML 서버 컨트롤 - 버튼";
            btnServer.Text = "표준 컨트롤 - 버튼";
        }
    }
}

/*
 * ASP.NET 표준 컨트롤
 * - ASP.NET으로 웹 페이지를 제작할 때 만들어지는 모든 UI를 가리켜 ASP.NET 서버 컨트롤이라고 한다.
 * - 일반적으로 많이 사용되는 컨트롤을 그룹으로 묶어서 표준(Standard Control)이라고 한다.
 * 
 * System.Web.UI.Control 클래스
 * - Control 클래스는 모든 ASP.NET 서버 컨트롤의 부모 컨트롤이면서 서버 컨트롤은 Control 클래스가 가지는
 *   멤버들을 똑같이 사용할 수 있다.
 */