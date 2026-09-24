using UnityEngine;
using UnityEngine.InputSystem;

public class openDoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Animator doorAnimator;
    public BoxCollider doorCollider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            doorAnimator.SetTrigger("OpenDoor");
            print("collision");
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            doorAnimator.SetTrigger("OpenDoor");
           // doorCollider.isTrigger = true;

        }
    }
}
