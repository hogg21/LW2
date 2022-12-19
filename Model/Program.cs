namespace first
{
    public class User
    {
        protected string _name { get; set; }
        protected string _email { get; set; }
        protected string _password { get; set; }
        public void SignIn(string password, string name, string email)
        {
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
                SignIn("123123", "Denys", "d.invas@gmail.com");
            }
            else
            {
                Console.WriteLine("Ви увійшли в систему");
                checkTasks();
            }
        }
    }
}