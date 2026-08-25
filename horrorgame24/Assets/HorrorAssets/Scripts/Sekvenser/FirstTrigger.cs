using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FirstTrigger : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject GuideArrow;
    public AudioSource line03;

    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        ThePlayer.GetComponent<PlayerMove>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        TextBox.GetComponent<TextMeshProUGUI>().text = "Looks like a weapon on that bed.";
        line03.Play();
        yield return new WaitForSeconds(1);
        TextBox.GetComponent<TextMeshProUGUI>().text = "";
        ThePlayer.GetComponent<PlayerMove>().enabled = true;
        GuideArrow.SetActive(true);
    }
}
