

    Console.WriteLine("If you want to use this app sensitivelly use '+' else use '-' ");
    
string command = Console.ReadLine();

if (command == "-")
{ 

    while (true)
{

    Console.Write("Pls enter your data : ");
    string enteredData = Console.ReadLine();
    

    Console.Write("Pls enter your target character  : ");
    string targetChar = Console.ReadLine();

    Console.WriteLine(IsTargerCharExists(enteredData, targetChar));
   
}

}
else if (command == "+")
{
    while (true)
    {

        Console.Write("Pls enter your data : ");
        string enteredData = Console.ReadLine();
        enteredData = enteredData.ToLower();

        Console.Write("Pls enter your target character  : ");
        string targetChar = Console.ReadLine();
        targetChar = targetChar.ToLower();

        Console.WriteLine(IsTargerCharExists(enteredData, targetChar));

    }
}

else
{
    Console.WriteLine("Wrong command !!! ");
}
    static bool IsTargerCharExists(string enteredData, string targetChar)
    {
        for(int i = 0; i < enteredData.Length; i++)
        {
           if (enteredData[i] == targetChar[0])
            {
             return true;
            }
           
        }
        return false;
    }





