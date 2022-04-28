using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public float transitionTime;
    public Animator transition;

    public GameEvents ge;
    public void Menu()
    {
        ge.POff();
        StartCoroutine(ChangeScreen(0));
    }
    public void Tetris()
    {
        StartCoroutine(ChangeScreen(1));
    }
    public void PentaTetris()
    {
        StartCoroutine(ChangeScreen(2));
    }
    public void ChaosTetris()
    {
        StartCoroutine(ChangeScreen(3));
    }
    IEnumerator ChangeScreen(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
    public void Close()
    {
        Application.Quit();
    }
}
