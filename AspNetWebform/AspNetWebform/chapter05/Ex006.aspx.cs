using System;
using System.Web.UI;

namespace AspNetWebform.chapter05
{
    public partial class Ex006 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.imgWrite.ImageUrl = "/images/btn_post.gif";
            this.imgList.ImageUrl = "./images/btn_list.gif";
        }

        protected void imgWrite_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("글쓰기 버튼 클릭됨.<br />");
        }

        protected void imgList_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("리스트 버튼 클릭됨.<br />");
        }
    }
}