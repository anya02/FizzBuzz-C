Console.WriteLine("Hello, World!");

for (int i = 1; i < 256; i++)
{
    string output = string.Empty;

    if (i % 3 == 0)
    {
        output = "Fizz";
    }
    if (i % 5 == 0)
    {
        output += "Buzz";
    }
    if (i % 7 == 0)
    {
        output += "Bang";
    }
    if (i % 11 == 0)
    {
        output = "Bong";
    }
    if (output.Length < 1)
    {
        output = i.ToString();
    }

    Console.WriteLine(output);
}