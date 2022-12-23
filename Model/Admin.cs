
namespace first1 {
    public class Admin
        {
            protected string _login { get; set; }
            protected string _password { get; set; }

        string[] banwords = { "Ідіоти", "Йолопи" };

        string[] users_list = { "Ivan", "Ursa", "Petya" };

        private void button_signup() {
            Admin hogg = new Admin();
            bool regAdmin = false;

            if(regAdmin == true) {
                hogg.SignAdmin("hogg", "hhhghghg");
            }
        }
        private void SignIn(string login, string password) {
            login = _login;
            password = _password;
            Console.WriteLine("Ви зареєструвалися в системі");
        }
        private void SignAdmin(string login, string password)
            {
                if (_login != login || password != _password)
                {
                    Console.WriteLine("Введений невірний логін чи пароль");
                }
                else
            {
                Console.WriteLine("Ви увійшли в систему");
                button_signup();
                Console.WriteLine("Користувачі онлайн: {users_list.Length}", users_list.Length);
            }
        }
            private void banUser(string word) {
            for (int i = 0; i < word.Length; i++) {
                if(word.IndexOf("1") == banwords.Length) {
                    Console.WriteLine("Порушення правила користування. Слідкуйте за словами");
                }
            }
            }
        }
}