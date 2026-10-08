using System.Collections;
using UnityEngine;

public class ReadNote : MonoBehaviour
{
    public GameObject noteUI;
    bool noteUiActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        noteUI.gameObject.SetActive(false);
        noteUiActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && noteUiActive == false)
        {
            noteUI.gameObject.SetActive(true);
            noteUiActive = true;
            print("collision");
            //return;

         
        }

        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.C) && noteUiActive == true)
        {
            noteUI.gameObject.SetActive(false);
            noteUiActive = false;
            print("CLOSED");
        }
    }

 
}
