using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float timerFloat = 1.0f;
    private float spawnWaitTime = 2.0f;

    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        timerFloat += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timerFloat > spawnWaitTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timerFloat = 0;
        }

        
    }
}
