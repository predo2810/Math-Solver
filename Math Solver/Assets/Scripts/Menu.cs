using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    bool Dark;

    Picker[] Graphics;

    bool MenuActive;

    [SerializeField]
    Animator MenuObject;

    [SerializeField]
    Animator Formulas;

    [SerializeField]
    TMPro.TMP_Text WarningText;

    void Start()
    {
        Graphics = FindObjectsOfType<Picker>();
    }

    public void ToggleDarkMode()
    {
        Dark = !Dark;
    
        if (Dark)
        {
            foreach (Picker G in Graphics)
            {
                G.GetComponent<Graphic>().DOColor(G.GetComponent<Picker>().DarkColor, 1);
            }
        }
        else
        {
            foreach (Picker G in Graphics)
            {
                G.GetComponent<Graphic>().DOColor(G.GetComponent<Picker>().LightColor, 1);
            }
        }
    }

    public void Quit()
    {
        Debug.Break();
        Application.Quit();
    }

    public void ToggleMenuActive()
    {
        MenuActive = !MenuActive;

        if (MenuActive)
        MenuObject.Play("Open");
        else
        MenuObject.Play("Close");
    }

    public void SendFormula(string Formula)
    {
        bool IsFirst = Identifier.CheckEquation(Formula);
        Debug.Log("The Formula Is " + IsFirst);

        if (IsFirst)
        {
            Formulas.Play("Show");
            FindObjectOfType<FormulaMaker>().Formula = Formula;
        }
        else
        {
            WarningText.alpha = 1;
            WarningText.color = Color.red;
            WarningText.text = "Invalid Request!";
            WarningText.transform.DOShakePosition(2, 5, 40);
            WarningText.DOFade(0, 2);
        }
    }
}
