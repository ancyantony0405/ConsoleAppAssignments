using ConsoleAppLogin.Auth;

namespace ConsoleAppLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login loginSystem = new Login(); 
            loginSystem.StartLogin();
        }
    }
}
