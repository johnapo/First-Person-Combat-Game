using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public const int maxHealth = 100;
    public int currentHealth = maxHealth;
    public RectTransform healthBar;
    private Animator anim;
    private SpawnEnemy enemy;
    private AudioSource audioSource;
    private string gObjName;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        enemy = GetComponent<SpawnEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" || collider.name == "Cup_L" || collider.name == "Cup_R")
        {
            audioSource.Play();
            TakeDamage(50);
            gObjName = collider.transform.parent.gameObject.name;
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            anim.SetTrigger("Dying");
            enemy.aliveEnemies--;
            StartCoroutine(WaitTime());
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSecondsRealtime(3);
        enemy.killEnemy(gObjName);
        StopCoroutine(WaitTime());
    }
}
