using System;

public class ArgumentChecker 
{
    public bool CheckPositiveValue(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        return true;
    }

    public bool CompareEffectTypes(EffectTypes requiredType, EffectTypes givenType)
    {
        string exceptionMessage = $"Wrong effect type. Required: {requiredType} Given: {givenType}";

        if (requiredType != givenType)
            throw new ArgumentException(exceptionMessage);

        return true;
    }
}