using System.Collections;
using UnityEngine;

public class CrateBreak : MonoBehaviour
{
    public GameObject wholeCrate;
    public GameObject brokenCrate;
    public GameObject explodeEffect;
    public GameObject keyObject;
    public GameObject keyTrigger;

    public void Start()
    {
        brokenCrate.SetActive(false);
    }
    public void DamageEnemy(int DamageAmount)
    {
        StartCoroutine(BreakCrate());
    }
    IEnumerator BreakCrate()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        keyObject.SetActive(true);
        keyTrigger.SetActive(true);
        wholeCrate.SetActive(false);
        brokenCrate.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        explodeEffect.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        explodeEffect.SetActive(false);
    }
}
