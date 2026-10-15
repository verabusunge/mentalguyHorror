using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class sanitySystem : MonoBehaviour
{
    public float sanity;
    public float maxSanity = 100;
    public float minSanity = 0;
    public Animator playerAnim;
    public GameObject deadScreen;
    public Animator gameOverPanelAnim;
    public GameObject blinkUI;
    public Animator blinkAnimator;
    
    public bool isBlinking;
    
    [SerializeField] public UnityEngine.UI.Slider sanityMeter;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sanity = maxSanity;
        deadScreen.gameObject.SetActive(false);
        isBlinking = false;
        sanityMeter.value = maxSanity;

    }

    // Update is called once per frame
    void Update()
    {
        sanityMeter.value = sanity;
        if (sanity <= minSanity)
        {
            StartCoroutine(GameOver());
        }

        if (Keyboard.current.pKey.isPressed)
        {
            StartCoroutine(GameOver());
        }

        if (Mouse.current.rightButton.isPressed)
        {
            isBlinking = true;

        }
        if (Mouse.current.rightButton.wasReleasedThisFrame)
        {
            isBlinking = false;
        }
    }


   public IEnumerator GameOver()
    {
        playerAnim.SetTrigger("GameOver");
        yield return new WaitForSeconds(2);
        gameOverPanelAnim.SetTrigger("Fade");
        yield return new WaitForSeconds(4);
        deadScreen.gameObject.SetActive(true);

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
   
    
}
