using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour
{
    public Text enemyCtrText;
    public Text roundNumText;
    public GameObject[] prefabEnemies;
    public List<GameObject> currEnemies;
    public int aliveEnemies;
    private int roundNum;

    // Start is called before the first frame update
    void Start()
    {
        roundNum = 1;
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        if (aliveEnemies == 0)
        {
            new WaitForSeconds(5);
            roundNum++;
            SpawnEnemies();
        }

        // Update UI
        enemyCtrText.text = "Enemies: " + aliveEnemies.ToString();
        roundNumText.text = "Round " + roundNum.ToString();
    }

    void SpawnEnemies()
    {
        int rangeEnemies = Random.Range(5 * roundNum, 10 * roundNum);
        aliveEnemies = rangeEnemies;

        for (int x = rangeEnemies; x >= 1; x--)
        {
            int random = Random.Range(0, prefabEnemies.Length);
            var randPosition = new Vector3(Random.Range(2, 98), 11, Random.Range(2, 98));
            GameObject enemy = (GameObject)Instantiate(prefabEnemies[random], randPosition, Quaternion.identity);
            currEnemies.Add(enemy);
        }
    }
    public void killEnemy(string gObjName) 
    {
        GameObject removal = null;

        for (int i = 0; i < currEnemies.Count; i++)
            {
                if (currEnemies[i].name.Equals(gObjName))
                {
                    removal = currEnemies[i];
                }
            }

        if (removal != null)
        {
            // Remove from list.
            currEnemies.Remove(removal);

            // Destroy object.
            Destroy(removal.gameObject);
        }
    }
}

