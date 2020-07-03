using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    private int invincibility;
    private AudioSource audioSource;
    public Slider healthPoints;
    public GameObject deathUI;

    // Start is called before the first frame update
    void Start()
    {
        health = 500;
        invincibility = 0;
        healthPoints.value = health;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (invincibility > 0)
        {
            invincibility--;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Enemy" || collider.name == "hand.L" || collider.name == "hand.R" && invincibility == 0)
        {
            audioSource.Play();
            health -= 50;
            invincibility = 30;
            healthPoints.value = health;
            if (health <= 0)
            {
                health = 0;
                FreezeGame();
            }
        }
    }

    private void FreezeGame()
    {
        Time.timeScale = 0;
        deathUI.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
