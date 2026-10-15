using UnityEngine;

public class Enemy : MonoBehaviour
{
    bool active;
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
            sanitySystemCode.sanity -= 0.1f;
        }
    }
}
