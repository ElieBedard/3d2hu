using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleMob1 : MonoBehaviour
{
    public int vitesse;
    public int r;

    private float h;

    private float angle = 90;
    public float vitRot;

    // Start is called before the first frame update
    void Start()
    {
        h = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //la balle suit une trajectoire cosinusoidal
        transform.localPosition = new Vector3(Mathf.Cos((Mathf.Deg2Rad * angle)) * r + h, transform.position.y, transform.position.z - Time.deltaTime * vitesse); 
        if (angle >= 360)
        {
            angle = 0;
        }
        else
        {
            angle += vitRot;
        }
    }
}
