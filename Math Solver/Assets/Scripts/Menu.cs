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
}
