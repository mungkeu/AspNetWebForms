using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AspNetWebform
{
    public partial class Ex008 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 동적으로 페이지의 제목을 변경하는 세 가지 방법
            Title = "제목이 바뀝니다.";
            Page.Title = "제목이 출력됩니다.";
            Page.Header.Title = "Page 클래스";

            // 외부 스타일시트 정의
            HtmlLink objHtmlLink = new HtmlLink();
            objHtmlLink.Href = "css/Ex001.css";
            objHtmlLink.Attributes.Add("rel", "style");
            objHtmlLink.Attributes.Add("type", "text/css");

            // Head 태그 정의, 외부스타일과 메타태그 등록
            HtmlHead objHtmlHead = Page.Header;
            objHtmlHead.Controls.Add(objHtmlLink);

            // 동적으로 페이지에 스타일시트를 적용하는 방법
            Style objButtonStyle = new Style();
            objButtonStyle.ForeColor = System.Drawing.Color.Navy;
            objButtonStyle.Font.Size = 9;
            objButtonStyle.Font.Name = "Verdana";
            Page.Header.StyleSheet.RegisterStyle(objButtonStyle, null);
            this.btnNewLoad.CssClass = objButtonStyle.RegisteredCssClass;
            this.btnPostBack.CssClass = objButtonStyle.RegisteredCssClass;

            Style objDivStyle = new Style();
            objDivStyle.ForeColor = System.Drawing.Color.Blue;
            objDivStyle.Font.Size = 9;
            objDivStyle.Font.Name = "Verdana";
            objDivStyle.Font.Italic = true;
            Page.Header.StyleSheet.CreateStyleRule(objDivStyle, null, "body, div");

            // 버튼을 클릭하면 [1][2]번 코드는 실행되지 않는다.
            if(!Page.IsPostBack)
            {
                Response.Write("[1] 폼이 처음 로드할 때에만 실행<br />");
            }
            if(Page.IsPostBack==false)
            {
                Response.Write("[2] 폼이 처음 로드할 때에만 실행<br />");
            }
            Response.Write("[3] 폼이 로드할 때마다 실행<br />");
        }

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            string strJs = @"
            <script>
            window.alert('포스트백 됨');
            </script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "MyScript", strJs);
        }

        protected void btnNewLoad_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ex008.aspx");
        }
    }
}
/*
 * Page 클래스
 * - ASP.NET 페이지는 모두 System.Web.UI.Page 클래스를 상속한다.
 * 핵심 속성 기능
 * 
 * 1. IsPostBack
 * - 현재 페이지를 처음 로드했는지, 다시 게시(포스트백) 했는지 확인한다.
 * - 웹 폼에서 서버 컨트롤의 버튼 등을 클릭했을 때 웹 페이지가 깜박 거리면서 현재 페이지가 다시 실행되는 것
 * 2. ClientScript.RegisterClientScriptBlock()
 * - 자바스크립트를 동적으로 웹 페이지에 추가한다.
 * 3. Header
 * - 현재 웹 폼의 <head> 태그 부분을 정의한다.
 * 4. Title
 * - 현재 웹 폼의 제목을 동적으로 설정하거나 가져온다.
 * 5. SetFocus()
 * - 다른 컨트롤의 ID 값을 지정해주면 웹 폼이 로드할 때 해당 컨트롤에 포커스가 지정된다.
 * 
 * Page  지시문
 * <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex008.aspx.cs" Inherits="AspNetWebform.Ex008" %>
 * 
 * 1.Page Language="C#"                      : ASP.NET의 기본 언어를 C#언어로 설정한다.
 * 2.AutoEventWireup="true"                  : ASPX 파일에서 발생한 이벤트를 ASPX.CS 파일의 이벤트 처리기에 자동으로 연결한다.
 * 3.CodeBehind="Ex008.aspx.cs"              : 현재 웹 폼 페이지의 코드를 담당하는 코드 숨김 파일을 지정한다.
 * 4.Inherits="AspNetWebform.Ex008"          : 코드 숨김 파일의 클래스 이름을 지정한다.
 * 5.Trace="true"                            : 웹 폼을 추적하는 코드를 페이지 아래에 출력한다.
 * 6.Debug="true"                            : 웹 폼 실행시 발생되는 에러 메시지를 자세하게 출력한다.
 * 7.ValidateRequest="false"                 : 웹 폼에서 입력된 HTML 태그를 서버 측으로 전송한다.(기본값은 true)
 * 8.MaintainScrollPositionOnPostback="true" : 상하 스크롤바가 생기는 페이지에서 새로 고침하거나 버튼이 클릭될 때 바로 전의 
 *                                             스크롤바 위치로 스크롤을 고정한다.
 */