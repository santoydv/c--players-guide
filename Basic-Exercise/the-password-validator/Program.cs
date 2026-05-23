Console.WriteLine("\n Welcome to the PassWord Validator Project \n");
while (true)
{
    Console.Write("Enter Password: ");

    string password = Console.ReadLine();

    bool isValid = PasswordValidator.Validate(password);

    if (isValid)
    {
        Console.WriteLine("Valid Password");
    }
    else
    {
        Console.WriteLine("Invalid Password");
    }

    Console.WriteLine();
}
