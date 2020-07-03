using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    public GameObject cutsceneCamera;
    public GameObject mainCamera;
    public GameObject player;
    public GameObject healthUI;

    // Start is called before the first frame update
    void Start()
    {
        cutsceneCamera.SetActive(true);
        mainCamera.SetActive(false);
        StartCoroutine(PlayCutscene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PlayCutscene()
    {
        yield return new WaitForSeconds(20);
        cutsceneCamera.SetActive(false);
        mainCamera.SetActive(true);
        healthUI.SetActive(true);
    }
}
