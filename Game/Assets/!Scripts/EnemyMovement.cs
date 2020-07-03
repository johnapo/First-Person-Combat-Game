using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private bool alive;
    private bool finishedSpawn;
    private NavMeshAgent navMesh;
    private Transform player;
    private Animator anim;
    private EnemyHealth health;
    private SpawnEnemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        navMesh = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        health = GetComponent<EnemyHealth>();
        enemy = GetComponent<SpawnEnemy>();
        finishedSpawn = false;
        alive = true;
        StartCoroutine(SpawnAnimation());
    }

    // Update is called once per frame
    void Update()
    {
        if (finishedSpawn == true & alive == true)
        {
            CheckHorizontalMovement();
            if (Mathf.Abs(Vector3.Distance(transform.position, player.transform.position)) < 2.0f)
            {
                if (health.currentHealth > 0)
                {
                    anim.SetTrigger("Punching");
                    navMesh.SetDestination(transform.position);
                }
                else
                {
                    alive = false;
                }
            }
            else
            {
                navMesh.SetDestination(player.position);
            }
        }
    }

    private void CheckHorizontalMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        anim.SetFloat("BlendX", x);
        anim.SetFloat("BlendY", y);
    }

    IEnumerator SpawnAnimation()
    {
        anim.SetTrigger("Getting Up");
        yield return new WaitForSeconds(13);
        finishedSpawn = true;
        StopCoroutine(SpawnAnimation());
    }
}
