using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject audioItem_01;
    public GameObject audioItem_02;
    public GameObject audioItem_03;
    public GameObject audioItem_04;
    public GameObject audioItem_05;

    public int choosenAudio;
    public int lineAudio;
    private void OnEnable()
    {
        GameEvents.pieceLanded += ChooseAudio;
    }
    private void OnDisable()
    {
        GameEvents.pieceLanded -= ChooseAudio;
    }
    void ChooseAudio()
    {
        choosenAudio = Random.Range(1, 4);

        switch (choosenAudio)
        {
            case 1:
                Destroy(
         Instantiate(audioItem_01, this.gameObject.transform.position, Quaternion.identity),
         1.5f);
                break;
            case 2:
                Destroy(
         Instantiate(audioItem_02, this.gameObject.transform.position, Quaternion.identity),
         1.5f);
                break;
            case 3:
                Destroy(
         Instantiate(audioItem_03, this.gameObject.transform.position, Quaternion.identity),
         1.5f);
                break;
        }
    }
}