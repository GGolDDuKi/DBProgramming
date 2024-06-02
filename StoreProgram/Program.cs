using System;
using System.Windows.Forms;
using System.Drawing;
using static Define;

namespace StoreDB
{
    static class Program
    {
        //각 메뉴(폼)은 수시로 전환될 수 있기 때문에, 생성과 파괴를 반복하는 것보다는
        //전역 변수로 선언하여 드러내고, 숨기는 방식으로 구현하였습니다.
        public static Store_Login loginForm;
        public static Store_Register registerForm;
        public static Store_UserMenu userMenuForm;
        public static Store_PrivacySetting privacySettingForm;
        public static Store_AdminMenu adminMenuForm;
        public static Store_ManageItems manageItemForm;
        public static Store_ManageUsers manageUsersForm;
        public static Store_ManageOrders manageOrdersForm;
        public static Store_BuyItems buyItemsForm;
        public static Store_CheckOrder checkOrderForm;  

        //로컬 내의 DB에 접근하기 위한 연결문을 쉽게 접근하기 위해 전역 변수로 선언하였습니다.
        public static string connectionString = $"Server=localhost;Port=3306;Database=storedb;Uid=DDuKi;Pwd=dduki1520310asd@";

        public static UserInfo UserInfo { get; set; } = new UserInfo();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Init();
            //가장 먼저 로그인폼이 실행됩니다.
            Application.Run(loginForm);
        }

        //각 폼의 객체를 생성하여 초기화 해줍니다.
        static void Init()
        {
            loginForm = new Store_Login();
            registerForm = new Store_Register();
            userMenuForm = new Store_UserMenu();
            privacySettingForm = new Store_PrivacySetting();
            adminMenuForm = new Store_AdminMenu();
            manageItemForm = new Store_ManageItems();
            manageUsersForm = new Store_ManageUsers();
            manageOrdersForm = new Store_ManageOrders();
            buyItemsForm = new Store_BuyItems();
            checkOrderForm = new Store_CheckOrder();
        }
    }
}
