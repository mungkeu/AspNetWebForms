using System;

namespace AspNetWebform.chapter05
{
    public partial class Ex002 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 레이블에 현재 날짜와 시간을 출력
            this.lblDateTime.Text = DateTime.Now.ToString();
        }
    }
}

/*
 * Label 컨트롤 
 * - 레이블 컨트롤은 웹 폼에 편집이 불가능한 문자열을 출력하고자 할 때 사용한다.
 * - 단지 웹 브라우저 화면에 프로그래밍 방식으로 문자열을 출력하고자 할 때 사용하는 컨트롤
 * 
 * 레이블 컨트롤의 주요 구성 요소
 * 클래스
 * - System.Web.UI.WebControls.Label 클래스
 * 속성
 * Text : 레이블 컨트롤에 들어갈 문자열 지정
 * ForeColor : 글자색: color:blue;
 * BackColor : 배경색: background-color:yello;
 * BackColor : 테두리 색상: border-color:red;
 * BorderStyle : 테두리 스타일: border-style:solid;
 * BorderWidth : 테두리 두께: border-width: 1px;
 */