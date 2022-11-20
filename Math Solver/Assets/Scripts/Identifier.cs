using UnityEngine;

public class Identifier : MonoBehaviour
{
    [SerializeField]
    string Equation;

    void Start()
    {
        Debug.Log(CheckEquation(Equation));
    }

    public bool CheckEquation(string Equation)
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
