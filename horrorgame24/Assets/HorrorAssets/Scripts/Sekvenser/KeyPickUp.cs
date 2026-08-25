using UnityEngine;
using TMPro;

public class KeyPickUp : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject ExtraCross;
    public GameObject theKey;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }
    private void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<TextMeshProUGUI>().text = "Take Key";
            ActionKey.SetActive (true);
            ActionText.SetActive (true);
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (TheDistance <= 5)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                theKey.SetActive(false);
                GlobalInventory.firstDoorKey = true; 
            }
        }
    }
    private void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
    }

}
