using System;

public class ArgumentChecker 
{
    public bool CheckPositiveValue(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        return true;
    }
}