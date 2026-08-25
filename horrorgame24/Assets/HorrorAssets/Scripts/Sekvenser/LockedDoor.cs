using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LockedDoor : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject ExtraCross;
    public AudioSource lockedDoor;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ExtraCross.SetActive(true);
            ActionKey.SetActive (true);
            ActionText.SetActive (true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (TheDistance <= 3)
            {
                ActionKey.SetActive(false);
                ExtraCross.SetActive(false);
                StartCoroutine(DoorReset());
            }
        }
    }
    private void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
    }
    IEnumerator DoorReset()
    {
        if (GlobalInventory.firstDoorKey == false)
        {
            lockedDoor.Play();
            ActionText.SetActive(true);
            ActionText.GetComponent<TextMeshProUGUI>().text = "Needs a key";
            yield return new WaitForSeconds(2);
            this.GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            ActionText.GetComponent<TextMeshProUGUI>().text = "Door Open";
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(4);
        }
    }
}
