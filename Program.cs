using System.Net;
using ValidationPassword;


class Program
{
    static void Main(string[] args)
    {
        //SignUp signUp = new SignUp();
        //signUp.
        string Login = "kkkkkkkkkkkkkkkkkkNUIIUHUJIIOkkkkkkk";
        


        Console.WriteLine(SignUp.Authorization(Login));
        Console.WriteLine(SignUp.MaximumLengthForLogin(Login));
        Console.ReadLine();
    
    }

    

    
}


