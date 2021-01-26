using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmetteurEnnemi : MonoBehaviour
{
    public GameObject balle;
    public float timerBalle = .5f;
    private float timer;

    void Start()
    {

        timer = timerBalle;

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            GameObject balleTemp =Instantiate(balle, transform.position, Quaternion.identity);

            timer = timerBalle;
            Destroy(balleTemp, 10.0f);
        }

    }
}
