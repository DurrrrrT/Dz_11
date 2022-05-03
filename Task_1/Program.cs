
int[] info = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] data = { 2, 3, 3, 1 };

int index = 0;
string numberAsString = string.Empty;

foreach (int value in data) 
{
    numberAsString = ""; 

    for (int i = 0; i < value; i++) 
    {
        numberAsString += info[index]; 
        index++; 
    }

int newNumber = Convert.ToInt32(numberAsString, 2);
Console.Write(newNumber + " ");
}