using UnityEngine;

public class FormulaMaker : MonoBehaviour
{
    [SerializeField]
    TMPro.TMP_Text FormulaText;

    public string Formula;

    void Update()
    {
        FormulaText.text = Formula;
        
        string[] FormulaParts = Formula.Split('=');
        
        if (FormulaParts.Length > 2)
        {
            Debug.Log("AAAAAAAAAAAA");
        }
        else
        {
            string Left = FormulaParts[0];
            string Right = FormulaParts[1];

            bool LeftX = false, RightX = false;

            foreach (char c in Left)
            {
                if (c.ToString().ToLower() == "x")
                {
                    LeftX = true;
                    break;
                }
            }

            foreach (char c in Right)
            {
                if (c.ToString().ToLower() == "x")
                {
                    RightX = true;
                    break;
                }
            }

            if (LeftX && RightX)
            {
                Debug.Log("Tem x demais nisso aí patrão...");
            }
        }
    }
}