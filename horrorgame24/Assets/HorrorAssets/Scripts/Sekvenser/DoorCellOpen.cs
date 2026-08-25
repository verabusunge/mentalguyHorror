using UnityEngine;

public class DoorCellOpen : MonoBehaviour
{
    public float theDistance; // Räknar utifrån vår raycast hur nära vi är 
    public GameObject actionKey; // Vår UI [E] text GameObject (for enabling/disabling)
    public GameObject actionText; // Vår UI instruktion using TextMeshProUGUI
    public GameObject theDoor;
    public AudioSource doorSound;
    public GameObject extraCrossHair;

    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (theDistance <= 3) // När vi är 3 eller minde bort med musen, visa actionkey och text (UI)
        {
            extraCrossHair.SetActive(true);
            actionKey.SetActive(true);
            actionText.SetActive(true);
        }
        if (Input.GetKey(KeyCode.E)) // Om spelaren trycker på E stänga av collider och UI, samt spela anim och ljudeffekt
        {
            if (theDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actionKey.SetActive(false);
                actionText.SetActive(false);
                theDoor.GetComponent<Animator>().Play("FirstDoorOpen"); // Namnet på din animation
                doorSound.Play();
            }
        }
    }

    private void OnMouseExit() // När musen lämnar området, visa inte UI
    {
        extraCrossHair.SetActive(false);
        actionKey.SetActive(false);
        actionText.SetActive(false);
    }
}