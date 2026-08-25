using System.Collections;
using UnityEngine;
using TMPro;

public class AOpening : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject fadeScreen;
    public GameObject textBox;
    public AudioSource line01;
    public AudioSource line02;

    void Start()
    {
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        fadeScreen.SetActive(false);
        textBox.GetComponent<TextMeshProUGUI>().text = "... where am I?";
        line01.Play();
        yield return new WaitForSeconds(2);
        textBox.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(0.5f);
        textBox.GetComponent<TextMeshProUGUI>().text = "I need to get out of here";
        line02.Play();
        yield return new WaitForSeconds(2);
        textBox.GetComponent<TextMeshProUGUI>().text = "";
        thePlayer.GetComponent<PlayerMove>().enabled = true;
    }
}