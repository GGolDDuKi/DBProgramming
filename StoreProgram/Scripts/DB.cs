using MySql.Data.MySqlClient;
using StoreDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Define;

public class DB
{
    /// <summary>
    /// id와 pw를 대조하여 계정이 확인될 경우, 계정 정보를 가져와 유저 프로그램에서 저장합니다.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="pw"></param>
    /// <param name="action"></param>
    public static void LoadUserInfo(string id, string pw, Action action = null)
    {
        if (id == "" || pw == "")
            return;

        try
        {
            using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
            {
                mysql.Open();
                string selectQuery = $"SELECT * FROM accountTBL WHERE id='{id}' AND pw='{pw}';";

                MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                MySqlDataReader reader = command.ExecuteReader();

                //데이터가 일치할 경우
                if (reader.Read())
                {
                    UserInfo.SetUserInfo(reader, Program.UserInfo);

                    if(action != null)
                        action();

                    switch (Program.UserInfo.Authority)
                    {
                        case "admin":
                            Program.loginForm.Hide();
                            Program.adminMenuForm.Show();
                            break;
                        case "user":
                            Program.loginForm.Hide();
                            Program.userMenuForm.Show();
                            break;
                    }
                }
                //데이터가 일치하지 않을 경우
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다.");
                    if (action != null)
                        action();
                }
            }
        }
        catch (Exception exc)
        {
            MessageBox.Show(exc.Message);
        }
    }

    public static void RegisterAccount(string id, string pw, string confirmPw, string name, string phoneNumber, string address, Action action = null)
    {
        #region 입력 조건 확인
        if (id.Length == 0 || pw.Length == 0 || name.Length == 0 || phoneNumber.Length == 0 || address.Length == 0)
        {
            MessageBox.Show("입력하지 않은 정보가 있습니다.");
            return;
        }

        if (pw != confirmPw)
        {
            MessageBox.Show("비밀번호가 일치하지 않습니다.");
            return;
        }

        if (phoneNumber.Contains("-"))
        {
            MessageBox.Show("전화번호 양식이 옳지 않습니다.");
            return;
        }
        #endregion

        try
        {
            using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
            {
                mysql.Open();

                string selectQuery = $"SELECT * FROM accounttbl WHERE id='{id}';";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, mysql);
                MySqlDataReader reader = selectCommand.ExecuteReader();

                //이미 존재하는 아이디일 경우
                if (reader.Read())
                {
                    MessageBox.Show("중복되는 아이디입니다.");
                    return;
                }
                reader.Close();

                //중복되지 않는 아이디일 경우
                string insertQuery = $"INSERT INTO accounttbl VALUES ('{id}', '{pw}', 'user', '{name}', '{phoneNumber}', '{address}');";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, mysql);
                if (insertCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("계정이 성공적으로 생성되었습니다.");
                else
                    MessageBox.Show("계정 생성에 실패하였습니다.\n잠시 후 다시 시도해주세요.");

                if (action != null)
                    action();

                //로그인 폼으로 돌아가기
                Program.registerForm.Hide();
                Program.loginForm.Show();
            }
        }
        catch (Exception exc)
        {
            MessageBox.Show(exc.Message);
        }
    }

    public static void ChangePrivacyInfo(string pw, string confirmPw, string name, string phoneNumber, string address, Action action = null)
    {
        #region 입력 조건 확인
        if (pw.Length == 0 || name.Length == 0 || phoneNumber.Length == 0 || address.Length == 0)
        {
            MessageBox.Show("입력하지 않은 정보가 있습니다.");
            return;
        }

        if (pw != confirmPw)
        {
            MessageBox.Show("비밀번호가 일치하지 않습니다.");
            return;
        }

        if (phoneNumber.Contains("-"))
        {
            MessageBox.Show("전화번호 양식이 옳지 않습니다.");
            return;
        }
        #endregion

        try
        {
            using (MySqlConnection mysql = new MySqlConnection(Program.connectionString))
            {
                mysql.Open();

                //기존의 개인정보 수정
                string updateQuery = $"UPDATE accountTBL SET pw='{pw}', name='{name}', phoneNumber='{phoneNumber}', address='{address}' WHERE id='{Program.UserInfo.ID}';";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, mysql);
                if (updateCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("개인정보가 변경되었습니다.");
                    try
                    {
                        string selectQuery = $"SELECT * FROM accountTBL WHERE id='{Program.UserInfo.ID}' AND pw='{pw}';";

                        MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                        MySqlDataReader reader = command.ExecuteReader();

                        //데이터가 일치할 경우
                        if (reader.Read())
                        {
                            UserInfo.SetUserInfo(reader, Program.UserInfo);

                            if (action != null)
                                action();
                        }
                        //데이터가 일치하지 않을 경우
                        else
                        {
                            MessageBox.Show("정보를 불러오는 중 오류가 발생하였습니다.");

                            if (action != null)
                                action();
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                else
                {
                    MessageBox.Show("개인정보 변경에 실패하였습니다.\n잠시 후 다시 시도해주세요.");
                    if (action != null)
                        action();
                }
            }
        }
        catch (Exception exc)
        {
            MessageBox.Show(exc.Message);
        }
    }
}