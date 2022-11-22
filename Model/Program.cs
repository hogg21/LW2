namespace first {
    public class UserRegistration {
        protected string userName{ get; set; }
        protected string userPassword{ get; set; }
        protected string email{ get; set; }
        
    }
    public class Admin {
        protected string userName{ get; set; }
        protected string userPassword{ get; set; }
    }
    public class Window {
        protected int windowNum{ get; set; }
    }
    public class Products {
        protected string productTitle{ get; set; }
    }
    public class ShoppingCart {
        protected string price{ get; set; }
    }
    public class ProductItem {
        protected string product{ get; set; }
    }
    public class Login {
        protected string userName{ get; set; }

        void ChangeName(string name) {
            if(name != userName) {
                Console.WriteLine("Ім'я невірне");
            } else {
                Console.WriteLine("Ім'я вказане вірно, йде вхід у систему");
                Console.ReadLine();
            }
        }
        protected string userPassword{ get; set; }

        void ChangePassword(string password) {
            Console.WriteLine("Введіть пароль: " + password);
            Console.ReadLine();
            if(password != userPassword) {

            }
        }
    }
}