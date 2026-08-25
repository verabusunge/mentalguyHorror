using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpPistol : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject FakePistol;
    public GameObject RealPistol;
    public GameObject GuideArrow;
    //public GameObject theJumpTrigger;
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget; //Hur långt vi är från target
    }
    private void OnMouseOver()
    {
        if (TheDistance <= 3) //Om vi är 3 eller mindre från target
        {
            ActionText.GetComponent<TextMeshProUGUI>().text = "Pick up Pistol"; //Text som berättar att vi kan ta upp pistolen
            ActionKey.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetKey(KeyCode.E)) //Om vi trycker E gör fakegun inactive och realgun active
        {
            if (TheDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                FakePistol.SetActive(false);
                RealPistol.SetActive(true);
                GuideArrow.SetActive(false);
                //theJumpTrigger.SetActive(true);
            }
        }
    }
    private void OnMouseExit()
    {
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
    }
}
