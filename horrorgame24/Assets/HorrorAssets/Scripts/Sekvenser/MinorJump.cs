using System.Collections;
using UnityEngine;

public class MinorJump : MonoBehaviour
{
    public GameObject cupObject;
    public GameObject jumpActivator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            jumpActivator.SetActive(true);
            StartCoroutine(DeactivateSphere());
        }
    }
    IEnumerator DeactivateSphere()
    {
        yield return new WaitForSeconds(0.5f);
        jumpActivator.SetActive(false);
    }
}
