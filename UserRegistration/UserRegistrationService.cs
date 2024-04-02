using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration;
using System.Linq;

public class UserRegistrationService
{
    //Lista för att lagra användarnam
    public List<string> Users { get; set; } = new List<string>();

    //Metod för att lägga till en ny användare
    public string AddUser(string username, string password, string email)
    {
        //Validera längden på användarnamnet
        if (username.Length < 5 || username.Length > 20)
        {
            Console.WriteLine("Username must be between 5 and 20 characters long.");
            return "Username must be between 5 and 20 characters long.";
        }
        if(Users.Contains(username))
        {
            Console.WriteLine("Expected user registration to fail due to invalid characters in username.");
            return "Expected user registration to fail due to invalid characters in username.";
        }
        //Kontrollera om användarnamnet redan finns
        if (Users.Contains(username))
        {
            Console.WriteLine("Username already exists.");
            return "Username already exists.";
        }
        //Validera lösenordet
        if (password.Length < 8)
            {
            Console.WriteLine("Password lenght must be over 8 characters and must include special sign");
            return "Password lenght must be over 8 characters and must include special sign";
        }
        //if (!IsValidEmail(email))
        //{
        //    Console.WriteLine("Invalid email format, must include @gmail.com.");
        //    return "Invalid email format, must include @gmail.com.";
        //}
        if (!email.EndsWith("@gmail.com"))
        {
            Console.WriteLine("Email must include @gmail.com");
            return "Email must include @gmail.com";
        }


        // //Validera email
        // /*if (CheckEmail(email))*/
        // if (email.EndsWith("@gmail.com"))
        // {
        //     Console.WriteLine("Email must include @gmail.com");
        //     return "Email must include @gmail.com";
        // }
        //// Skapa en ny användare och lägg till i listan
        ///
        //Users.Add(username);

        //Console.WriteLine("User added successfully.");
        //return "User added successfully.";
        User newUser = new User(username, password, email);
        Users.Add(username);
        Console.WriteLine("User added successfully.");
        return "User added successfully.";
    }
    //Metod för att validera lösenordet
    public bool Password(string password)
    {
        string specialCharacters = "!@#$%^&*()-_=+[]{};:'\",.<>/?\\|";
        
    if (password.Length >= 8 && (password.Any(sc => specialCharacters.Contains(sc))))
            //if (password is not null && password.Length >= 8 && CheckIsCharacterSpecial(password)) 
        {
            return true;
        }
        return false;

    }
    //Hjälp för kontroll om lösenordet innehåller ett specialtecken
    private bool CheckIsCharacterSpecial(string password)
    {
        foreach (char c in password)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return true;
            }
        }
        return false;
    }
    //Metod för kontroll ifall en sträng innehåller alfanumeriska tecken
    public bool IsAlphanumeric(string str)
    {
        return str.All(char.IsLetterOrDigit);
    }
    public bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
    //Metod för kontrollera email
    //public bool CheckEmail(string email)
    //{
    //    if (email.EndsWith("@gmail.com"))
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
}
