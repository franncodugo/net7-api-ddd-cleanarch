
using System.Text.RegularExpressions;

namespace Domain.ValueObjects;

public partial record PhoneNumber
{
    private const int DefaultLenght = 9;
    private const string Pattern = @"^((\(?\d{3}\)? \d{4})|(\(?\d{4}\)? \d{3})|(\(?\d{5}\)? \d{2}))-\d{4}$";
    public string Value { get; init; } // Can only be setted by Init Contructor

    // Private constructor.
    private PhoneNumber(string value) 
        => Value = value;

    public static PhoneNumber? Create(string value)
    {
        // Validation: Null, Does not comply with the reg expression, Lenght.
        if (string.IsNullOrWhiteSpace(value) || 
            !PhoneNumberRegex().IsMatch(value)||
            value.Length != DefaultLenght)
            return null;

        return new PhoneNumber(value);
    }
    
    [GeneratedRegex(Pattern)]
    private static partial Regex PhoneNumberRegex();
}