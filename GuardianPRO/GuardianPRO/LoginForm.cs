using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GuardianPRO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=GuardianPRO;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UserID, FullName, Role FROM Users WHERE Login = @login AND Password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        CurrentUser.ID = reader["UserID"].ToString();
                        CurrentUser.Name = reader["FullName"].ToString().Trim();
                        CurrentUser.Role = reader["Role"].ToString().ToLower().Trim();

                        MessageBox.Show($"Добро пожаловать, {CurrentUser.Name}!", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        switch (CurrentUser.Role)
                        {
                            case "user":
                                new UserDashboardForm().Show();
                                break;
                            case "inspector":
                                new InspectorDashboardForm().Show();
                                break;
                            case "admin":
                                new AdminDashboardForm().Show();
                                break;
                            default:
                                MessageBox.Show($"Неизвестная роль: {CurrentUser.Role}. Обратитесь к администратору.", "Ошибка роли", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }


                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void LoginForm_Load(object sender, EventArgs e) { }
    }
}


