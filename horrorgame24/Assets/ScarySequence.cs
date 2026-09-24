using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ScarySequence : MonoBehaviour
{
    public Light lightSource;
    public GameObject ligthBulb;
    public bool hasHappened;
    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemy.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasHappened)
        {


            StartCoroutine(ScaryEventStart());
            //hasHappened = true;
            
            
        }
    }

    public IEnumerator ScaryEventStart()
    {
           

        for (int i = 0; i < 6; i++)
        {
            lightSource.intensity = 500f;
            ligthBulb.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.05f);
            lightSource.intensity = 20000f;
            ligthBulb.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.05f);
        }
        for (int i = 0; i < 2; i++)
        {
            yield return new WaitForSeconds(0.3f);
            lightSource.intensity = 500f;
            ligthBulb.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.3f);
            lightSource.intensity = 20000f;
            ligthBulb.gameObject.SetActive(true);

        }

    }
}
