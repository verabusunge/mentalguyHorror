using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    public GameObject ammoPanel;
    private void OnTriggerEnter(Collider other)
    {
        ammoPanel.SetActive(true);
        GlobalAmmo.ammoCount += 12; 
        gameObject.SetActive(false);
    }
}