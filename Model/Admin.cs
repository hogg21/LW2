
namespace first1 {
    public class Admin
        {
            protected string _login { get; set; }
            protected string _password { get; set; }

        string[] banwords = { "Ідіоти", "Йолопи" };
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