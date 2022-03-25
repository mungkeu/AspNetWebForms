using System;
using System.Web.UI;

namespace AspNetWebform.chapter05
{
    public partial class Ex004 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 처음 로드할 때만 0으로 초기
            if(!Page.IsPostBack)
            {
                txtNum.Text = "0"; 
            }
        }

        protected void btnUp_Click(object sender, EventArgs e)
        {
            txtNum.Text = Convert.ToString(Convert.ToInt32(txtNum.Text)+1);
        }

        protected void btnDown_Click(object sender, EventArgs e)
        {
            txtNum.Text = Convert.ToString(int.Parse(txtNum.Text)-1);
        }
    }
}
/*
 * 버튼 컨트롤
 * 클래스
 * - System.Web.UI.WebControls.Button 클래스
 * 속성
 * - Text : 버튼 컨트롤에 쓰여질 문자열 지정
 * - PostBackUrl : 현재 버튼에 대한 이벤트 처리기를 다른 웹 폼에서 처리하고자 할 때
 *                 웹 폼의 경로 지정
 *                 
 * 서버 컨트롤의 이름 짓는 규칙
 * - 레이블 : lbl
 * - 텍스트박스 : txt
 * - 버튼 : btn, cmd
 * - 콤보박스(드롭다운리스트) : cmb
 */