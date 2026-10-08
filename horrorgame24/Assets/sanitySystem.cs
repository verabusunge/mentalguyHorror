using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class sanitySystem : MonoBehaviour
{
    public float sanity;
    public float maxSanity = 100;
    public float minSanity = 0;
    public Animator playerAnim;
    public GameObject deadScreen;
    public Animator gameOverPanelAnim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sanity = maxSanity;
        deadScreen.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (sanity <= minSanity)
        {
            StartCoroutine(GameOver());
        }
    }


   public IEnumerator GameOver()
    {
        playerAnim.SetTrigger("GameOver");
        yield return new WaitForSeconds(2);
        gameOverPanelAnim.SetTrigger("Fade");
        yield return new WaitForSeconds(3);
        deadScreen.gameObject.SetActive(true);

    }
   
}
