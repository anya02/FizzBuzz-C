Console.WriteLine("Hello, World!");

//string[] output = new string[3];

//Console.WriteLine(output.Length);


for (int i = 1; i < 256; i++)
{
    string[] output = new string[3];
    string final;

    if (i % 3 == 0)
    {
        output[0] = "Fizz";
    }
    if (i % 5 == 0)
    {
        output[1] = "Buzz";
    }
    if (i % 7 == 0)
    {
        output[2] = "Bang";
    }
    if (i % 11 == 0)
    {
        Array.Clear(output, 0, output.Length);
        output[0] = "Bong";
    }
    if (output[0] == null)
    {
        final = i.ToString();
    } else
    {
        final = string.Join("", output);
    }

    
    Console.WriteLine(final);
} 