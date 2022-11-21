public class Identifier
{
    public static bool CheckEquation(string Equation)
    {
        bool IsFirst = false;

        foreach (char c in Equation)
        {
            if (c == '=')
            {
                IsFirst = true;
                break;
            }
        }

        return IsFirst;
    }
}
