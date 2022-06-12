
while (true)
{
    Console.Write("Pls enter your data : ");
    string enteredData = Console.ReadLine();
    string ReturnDataLower = string.Empty;

    for (int i = 0; i < enteredData.Length; i++)
    {

        if (enteredData[i] >= 'A' && enteredData[i] <= 'Z')
        {
            ReturnDataLower += (char)(enteredData[i] - 'A' + 'a');
        }
        else
        {
            ReturnDataLower += enteredData[i];
        }
    }
    Console.WriteLine($"Entered data : {ReturnDataLower}");
}