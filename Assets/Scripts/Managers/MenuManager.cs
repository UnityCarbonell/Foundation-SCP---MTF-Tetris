using UnityEngine;
public class MenuManager : MonoBehaviour
{
    public Animator select;
    public Animator tutorial;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            HideSelect();
            HideTutorial();
        }
    }
    //Select UI
    public void SelectMode()
    {
        select.SetTrigger("ShowSelect");
    }
    public void HideSelect()
    {
        select.SetTrigger("HideSelect");
    }
    //Tutorial UI
    public void ShowTutorial()
    {
        tutorial.SetTrigger("ShowTutorial");
    }
    public void HideTutorial()
    {
        tutorial.SetTrigger("HideTutorial");
    }
}
