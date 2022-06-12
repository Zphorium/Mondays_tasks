
while (true)
{
    Console.Write("Pls enter your data : ");
    string enteredData = Console.ReadLine();
    string ReturnDataUpper = string.Empty;

    for (int i = 0; i < enteredData.Length; i++)
    {

        if (enteredData[i] >= 'a' && enteredData[i] <= 'z')
        {
            ReturnDataUpper +=(char)(enteredData[i]-32);
        }
        else
        {
            ReturnDataUpper += enteredData[i];
        }
    }
    Console.WriteLine($"Entered data : {ReturnDataUpper}");

}