using UserRegistrationProject;

Console.WriteLine("Enter user name:");
string userName = Console.ReadLine();
Registration UName = new Registration();
if (UName.ValidateFirstName(userName)==true)
    Console.WriteLine("User name accepted");
else
    Console.WriteLine("Invalid!!First letter must be capital and minimum 3 characters requiered!!");