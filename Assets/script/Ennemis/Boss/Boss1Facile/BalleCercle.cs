using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleCercle : MonoBehaviour
{
    public int vitesse;
    public int r;
    private float h;
    private float k;
    //private Vector3 vec;

    private float angle = 0;
    float vitRot = .5f;
    // Start is called before the first frame update
    void Start()
    {
        h = transform.transform.position.x;
        k = transform.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //la balle suit une trajectoire en cercle
        transform.localPosition = new Vector3(Mathf.Cos((Mathf.Deg2Rad * angle)) * r + h, Mathf.Sin((Mathf.Deg2Rad * angle)) * r + k, transform.position.z - Time.deltaTime * vitesse);

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
