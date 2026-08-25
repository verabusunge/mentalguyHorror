using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CellExitDoor : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject ExtraCross;
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }
    private void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionText.GetComponent<TextMeshProUGUI>().text = "Open Door";
            ExtraCross.SetActive(true);
            ActionKey.SetActive (true);
            ActionText.SetActive (true);
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (TheDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                StartCoroutine(FadeToExit());
            }
        }
    }
    private void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
    }
    IEnumerator FadeToExit()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
}
