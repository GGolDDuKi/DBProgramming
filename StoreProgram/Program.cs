using System;
using System.Windows.Forms;
using System.Drawing;
using static Define;

namespace StoreDB
{
    static class Program
    {
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

        public static string connectionString = $"Server=localhost;Port=3306;Database=storedb;Uid=DDuKi;Pwd=dduki1520310asd@";

        public static UserInfo UserInfo { get; set; } = new UserInfo();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Init();
            Application.Run(loginForm);
        }

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
