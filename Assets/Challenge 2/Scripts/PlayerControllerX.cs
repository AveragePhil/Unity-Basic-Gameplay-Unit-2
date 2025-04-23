using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float cooldown = 0f;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldown < Time.time)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = Time.time + 1.0f;
        }
    }
}
