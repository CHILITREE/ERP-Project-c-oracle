using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_오전반_7조_김동희_나이키슈즈_관리시스템_장동휘__안기백__이선우_
{


    // 제품의 정보를 받는다.
    /* public class Product
     {
         public string P_ID = "상품_번호", P_NAME = "상품_이름", P_PRICE = "상품_가격", P_SIZE = "사이즈", P_COLOR = "색", P_STOCK_NUMBER = "창고_번호",
             P_STOCK_LOCATION = "창고_위치", P_AMOUNT = "재고 수량", P_CHECK = "재고 파악 확인", P_CHECKTIME = "재고 파악 시간"
             , S_NUMBER = "판매일련번호", S_PRICE = "판매 금액", S_AMOUNT = "판매 수량", R_REASON = "반품 사유", R_DATE = "반품 일자", R_AMOUNT = "반품 수량",
             PAY_NUMBER = "결제 번호", PAY_PRICE = "결제 금액", PAY_WAY = "결제 방법", PAY_DATE = "결제 일자", M_NUMBER = "회원번호", M_NAME = "회원_이름",
             M_PHONE = "회원_전화번호", M_GENDER = "회원_성별", M_BIRTH = "회원_생년월일", M_JOINDATE = "회원_가입날짜"; 

     }
    */
    // 직원의 정보를 받는다.
    /*public class Personal
    {
        public string E_NAME = "직원 이름", Year = "근속년수", E_HIREDATE = "고용 일자", E_FIREDATE = "해고 일자", Birthday = "생년월일", E_PAY = "급여", E_JUDGE = "직급",
            Charge = "담당업무", Contact = "연락처", Address = "주소", Education = "학력", Qualification = "자격사항", Other = "''",
            E_ID = "직원 번호";

    }
    */

    // 직원의 정보를 받는 구간입니다.
    /*public class Num
    {
        static public int a = 0;
        static public Personal[] num = new Personal[100];
        static public string[] numlist = new string[] { "0" };



        public Personal this[int i]
        {
            get { return num[i]; }
            set { num[i] = value; }
        }


            static class Program
        {*/
    /// <summary>
    /// 해당 애플리케이션의 주 진입점입니다.
    /// </summary>
    /*[STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MAIN());
    }
}
}*/



    // 제품의 정보를 받는 구간입니다.
    /* public class Num2
     {
         static public int a = 0;
         static public Product[] num = new Product[100];
         static public string[] numlist = new string[] { "0" };



         public Product this[int i]
         {
             get { return num[i]; }
             set { num[i] = value; }
         }*/


    static class Program
        {
            /// <summary>
            /// 해당 애플리케이션의 주 진입점입니다.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MAIN());
            }
        }
    }
