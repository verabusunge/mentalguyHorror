using System.Collections;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject RealGun;
    public GameObject MuzzleFlash;
    public AudioSource FirePistolSound;
    public bool IsFiring = false;
    //public float TargetDistance;
    //public int DamageAmount = 5;
    void Update()
    {
        if (RealGun.activeSelf && Input.GetButtonDown("Fire1")) //&& GlobalAmmo.ammoCount >= 1)
        {
            if (IsFiring == false)
            {
                //GlobalAmmo.ammoCount -= 1;
                StartCoroutine(FiringPistol());
            }
        }
    }
    IEnumerator FiringPistol()
    {
        if (!RealGun.activeSelf) yield break;
        //RaycastHit shot;
        IsFiring = true;
        /*if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out shot, 100f))
        {
            TargetDistance = shot.distance;
            shot.transform.SendMessage("DamageEnemy", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }*/
        RealGun.GetComponent<Animator>().Play("PistolShot", -1 , 0f);
        MuzzleFlash.SetActive(true);
        FirePistolSound.Play();
        yield return new WaitForSeconds(0.5f);
        MuzzleFlash.SetActive(false);
        IsFiring = false;
    }
}
