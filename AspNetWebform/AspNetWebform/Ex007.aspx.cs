using System;

namespace AspNetWebform
{
    public partial class Ex007 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // [1] Application 변수 1 증가
            if(Application["Count"]==null)
            {
                Application.Lock(); // 먼저 온 사용자가 변수 수정 잠그기
                Application["Count"] = 1; // 응용 프로그램 변수 선언 및 초기화
                Application.UnLock(); // 잠금 해제 : 다른 사용자가 사용 가능
            }
            else
            {
                Application["Count"] = (int)Application["Count"] + 1;
            }
            // [2] Session 변수 1 증가
            if(Session["count"]==null)
            {
                Session["Count"] = 1; // 세션 변수 선언과 동시에 1로 초기화
            }
            else
            {
                Session["Count"] = (int)Session["Count"] + 1;
            }
            // [3] 출력
            // 누구나 다 1씩 증가
            this.lblApplication.Text = Application["Count"].ToString();
            // 현재 접속자만 1씩 증가
            this.lblSession.Text = Session["Count"].ToString();
            // 현재 접속자의 고유 접속 번호
            this.lblSessionID.Text = Session.SessionID;
            // 현재 세션의 유지 시간
            this.lblTimeout.Text = Session.Timeout.ToString();
        }
    }
}

/*
 * Application 개체 (공통 public적인 성격)
 * - 응용 프로그램 영역에서 어떤 값을 저장시켜 놓은 뒤 그 값을 웹 페이지 어느 곳에서든
 *   참조할 수 있는 기능이 있다.
 * - 응용 프료그램 레벨 변수로 주로 사용되고 Application["이름"]=값; 형식으로 값을 저장한다.
 * 
 * 1. Lock()
 * - 애플리케이션 변수를 잠그는 메서드
 * 2. UnLock()
 * - 잠긴 애플리케이션 변수를 해제하는 메서드
 * 3. Add()
 * - 애플리케이션 변수를 만들 때 사용
 * 4. Application_Start()
 * - 웹 애플리케이션이 시작될 때 발생(웹 사이트에 첫 번째 사용자가 방문할 때 발생)
 * - Global.aspx에서 설정
 * 5. Application_End()
 * - 웹 응용 프로그램이 끝날 때 발생 (웹 사이트에서 마지막 사용자가 나간 후 발생)
 * - 웹 사이트에서 마지막 사용자가 나간 후 20분 뒤에 실행되는 메서드
 * - Global.aspx에서 설정
 * 
 * Session 개체 (전용 private적인 성격)
 * - Session 개체는 단일 사용자 레벨로 어떤 값을 저장하거나 호출할 때 사용되는 개체로 사용자 한 명에 대한
 *   정보를 키와 값으로 저장할 수 있으며 서버 측 메모리에 해당 데이터를 저장한다.
 * 
 * 1. SessionID
 * - 현재 세션의 고유 번호 값 반환
 * 2. SessionTimeout
 * - 세션 시간 기록: 기본값 20분, 더 추가하거나 줄일 경우 사용한다.
 * 3. Abandon()
 * - 현재 세션 지우기
 * 4. Session_Start()
 * - 사용자(세션)한 명이 방문할 때 실행
 * 5. Session_End()
 * - 사용자 한 명이 마지막 요청(접속) 후 20분 뒤에 실행되는 메서드
 * 
 * a.aspx와 b.aspx 두 페이지 간에 데이터를 유지하고자 할 때 공통 데이터는
 * Application 개체 변수를, 전용 데이터는 Session 개체 변수를 통해 관리한다.
 */