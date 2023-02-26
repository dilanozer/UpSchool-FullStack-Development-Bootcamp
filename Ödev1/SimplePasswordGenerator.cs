// Author: Dilan OZER
// Description: Random password generator, based on user's choices

namespace DefaultNamespace;
public class SimplePasswordGenerator
{
    List<char> chars = new List<char>();

    Console.WriteLine("Do you want to include numbers?");
    String numberOption = Console.ReadLine();
        
    Console.WriteLine("OK! How about lowercase characters?");
    String lowercaseOption = Console.ReadLine();
        
    Console.WriteLine("Very nice! How about uppercase characters?");
    String uppercaseOption = Console.ReadLine();
        
    Console.WriteLine("All right! We are almost done. Would you also want to add special characters?");
    String specialOption = Console.ReadLine();
        
    Console.WriteLine("Great! Lastly. How long do you want to keep your password length?");
    int passwordLength = Convert.ToInt16(Console.ReadLine());
    
    CharSet(ref chars);
        
    Console.WriteLine(PasswordGenerator(passwordLength));

    String PasswordGenerator(int passwordLength)
    {
        StringBuilder sb = new StringBuilder();
        Random rand = new Random();
    
        for (int i = 0; i < passwordLength; i++)
        {
            sb.Append(chars[rand.Next(0, chars.Count)]);
        }
    
        return sb.ToString();
    }
    
    void CharSet(ref List<char> chars)
    {
        if (numberOption.Substring(0,1).ToLower() == "y")
        {
            for (char number = '0'; number <= '9'; number++)
            {
                chars.Add(number);
            }
        }

        if (lowercaseOption.Substring(0, 1).ToLower() == "y")
        {
            for (char lowercase = 'a'; lowercase <= 'z'; lowercase++)
            {
                chars.Add(lowercase);
            }
        }

        if (uppercaseOption.Substring(0,1).ToLower() == "y")
        {
            for (char uppercase = 'A'; uppercase <= 'Z'; uppercase++)
            {
                chars.Add(uppercase);
            }
        }

        if (specialOption.Substring(0,1).ToLower() == "y")
        {
            for (char special = '!'; special <= '?'; special++)
            {
                chars.Add(special);
            }
        }
        
    }
}