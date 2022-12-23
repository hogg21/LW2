namespace first
{
    public class User
    {
        protected string _name { get; set; }
        protected string _email { get; set; }
        protected string _password { get; set; }

        private void button_registration() {
            User user = new User();
            if(this._email == "hhhhh@gmail.com" && this._name == "Denys" && this._password == "123123") {
                user.SignIn();
                user.checkTasks();
            }
        }

        // Перевірка чи є користувач у БД системи.
        private void button_signup() {
            User user = new User();
            bool regUser = false;

            if(regUser == true) {
                user.SignUp("Denys", "123123");
            } else {
                user.SignIn();
            } 
        }
        public void SignIn()
        {
            string email, name, password;
            Console.WriteLine("Введіть дані для реєстрації");
            email = _email;
            name = _name;
            password = _password;
            Console.ReadLine();
            Console.WriteLine("Вітаю, ви зареєструвались в системі");
        }
        protected void checkTasks() {
            string[] tasks = { "Зробити уроки", "Вигуляти собаку" };
            for (int i = 0; i < tasks.Length; i++) {
                Console.ReadKey();
            }
        }
        public void SignUp(string name, string password)
        {
            if (name != _name || password != _password)
            {
                Console.WriteLine("Введені невірні дані, спробуйте знову!");
                SignIn();
            }
            else
            {
                Console.WriteLine("Ви увійшли в систему");
                checkTasks();
            }
        }
    }
}