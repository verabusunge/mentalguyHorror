using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Enemy : MonoBehaviour
{
    public bool active;
    public sanitySystem sanitySystemCode;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        active = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (active == true & sanitySystemCode.isBlinking == false)
        {
            sanitySystemCode.sanity -= 10f * Time.deltaTime;
            print(sanitySystemCode.sanity);
        }
    }
}
