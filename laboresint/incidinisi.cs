public static char Method1(char input)
{
    // Example implementation that returns the next character in the alphabet
    if(input >= 'a' && input < 'z')
    {
        return (char)(input + 1);
    }
    else if(input >= 'A' && input < 'Z')
    {
        return (char)(input + 1);
    }
    else
    {
        // If 'z' or 'Z', wrap around to 'a' or 'A'; otherwise, return the input as is
        return input == 'z' ? 'a' : input == 'Z' ? 'A' : input;
    }
}
