using System;

namespace AspNetWebform.chapter05
{
    public partial class Ex003 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string strName = this.txtSingleLine.Text;
            string strIntro = this.txtMultiLine.Text; ;
            string strPassword = this.txtPassword.Text;
            Response.Write(strName + "<br />" + strIntro + "<br />" + strPassword + "<br />");
        }
    }
}
/*
 * TextBox
 * - SingleLine 텍스트박스, Password 텍스트박스, MultiLine 텍스트박스
 * 클래스
 * - TextBox : System.Web.UI.WebControls.Text 클래스
 * 속성
 * - TextMode
 *   * 텍스트, 암호, 멀티라인 텍스트 결정
 *   * HTML5의 주요 텍스트박스(Color, Email, DateTime, Phone등) 모양을 제공
 * - ReadOnly : 읽기 전용 텍스트박스 생성
 */