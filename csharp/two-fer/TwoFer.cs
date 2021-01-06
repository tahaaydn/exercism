using System;

public static class TwoFer
{
    public static string Speak(string str = "you")
    {
        string message = "One for " + str + ", one for me.";
        return message;
    }
}
