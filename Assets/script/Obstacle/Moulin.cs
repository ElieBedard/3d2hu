using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moulin : MonoBehaviour
{
    private float vitesseRotation;
    public float vitMoulinMin;
    public float vitMoulinMax;
    // Start is called before the first frame update
    void Start()
    {
        vitesseRotation = Random.Range(vitMoulinMin, vitMoulinMax);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( 0,0,vitesseRotation * Time.deltaTime);


    }
}
