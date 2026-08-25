using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class IntroSekvenser : MonoBehaviour
{
    public GameObject ActionText;
    public GameObject dateDisplay;
    public GameObject placeDisplay;
    public GameObject Boarder;
    public AudioSource line01;
    public AudioSource line02;
    public AudioSource line03;
    public AudioSource line04;
    public AudioSource line05;
    public AudioSource thudSound;
    public GameObject allBlack;
    void Start()
    {
        StartCoroutine(SequenceBegin());
    }
    IEnumerator SequenceBegin()
    {
        yield return new WaitForSeconds(1);
        placeDisplay.SetActive(true);
        yield return new WaitForSeconds(1);
        Boarder.SetActive(true);
        yield return new WaitForSeconds(1);
        dateDisplay.SetActive(true);
        yield return new WaitForSeconds(2);
        placeDisplay.SetActive(false);
        dateDisplay.SetActive(false);
        Boarder.SetActive(false);
        ActionText.GetComponent<TextMeshProUGUI>().text = "The night of October 1981 changed me forever.";
        line01.Play();
        yield return new WaitForSeconds(2);
        ActionText.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);
        ActionText.GetComponent<TextMeshProUGUI>().text = "I headed out to investigate the haunting sounds in the woods.";
        line02.Play();
        yield return new WaitForSeconds(3);
        ActionText.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);
        ActionText.GetComponent<TextMeshProUGUI>().text = "I stumbled upon a clearing with a cabin in the distance.";
        line03.Play();
        yield return new WaitForSeconds(2);
        ActionText.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);
        ActionText.GetComponent<TextMeshProUGUI>().text = "I could hear those sounds coming from there";
        line04.Play();
        yield return new WaitForSeconds(2);
        ActionText.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);
        ActionText.GetComponent<TextMeshProUGUI>().text = "Little did I know that this was only the beginning";
        line05.Play();
        yield return new WaitForSeconds(2);
        ActionText.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);
        allBlack.SetActive(true);
        thudSound.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}
