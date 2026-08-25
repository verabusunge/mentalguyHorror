using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public GameObject stalkerDes; 
    private NavMeshAgent stalkerAgent; 
    public float enemySpeed = 0.01f; 
    public float attackRange = 5f; 
    private bool isAttacking = false;
    //public GameObject theFlash;

    void Start()
    {
        stalkerAgent = GetComponent<NavMeshAgent>(); 
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, stalkerDes.transform.position);

        if (distanceToPlayer <= attackRange)
        {
            enemySpeed = 0;
            stalkerAgent.isStopped = true;

            if (!isAttacking)
            {
                GetComponent<Animator>().Play("Attack");
                StartCoroutine(InflictDamage());
            }
        }
        else
        {
            enemySpeed = 0.01f;
            stalkerAgent.isStopped = false;
            stalkerAgent.SetDestination(stalkerDes.transform.position);
            GetComponent<Animator>().Play("Walk");
        }
    }

    IEnumerator InflictDamage()
    {
        isAttacking = true;
        yield return new WaitForSeconds(4f);

        float distanceToPlayer = Vector3.Distance(transform.position, stalkerDes.transform.position);
        if (distanceToPlayer <= attackRange)
        {
            //theFlash.SetActive(true);
            GlobalHealth.currentHealth -= 5;
            //yield return new WaitForSeconds(0.2f);
            //theFlash.SetActive(false);
        }

        yield return new WaitForSeconds(0.2f); 
        isAttacking = false;
    }
}