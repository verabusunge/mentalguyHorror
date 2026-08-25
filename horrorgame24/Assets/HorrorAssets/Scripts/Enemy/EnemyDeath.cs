using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int EnemyHealth = 20; //Eftersom vår skada är 5 måste vi då skjuta Zombien 4 ggr innan den dör
    public int StatusCheck;
    //public AudioSource JumpscareMusic;

    void DamageEnemy(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }
    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            //GetComponent<EnemyAI>().enabled = false;
            //GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            GetComponent<Animator>().Play("Die"); //namnet på din animation
            //JumpscareMusic.Stop();
        }
    }
}
