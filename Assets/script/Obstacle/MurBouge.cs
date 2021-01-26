using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurBouge : MonoBehaviour
{
    public float limitGauche;
    public float limitDroite;
    private float largeur;
    private float dirX=1;
    private float vitesse;
    public float vitMurMin;
    public float vitMurMax;
    // Start is called before the first frame update
    void Start()
    {
        largeur = gameObject.GetComponent<Renderer>().bounds.size.x / 2;
        vitesse = Random.Range(vitMurMin, vitMurMax);
    }

    // Update is called once per frame
    void Update()
    {
        //deplacement vers la gauche
        if (transform.position.x>=limitDroite-largeur)
        {
            dirX =-1;
        }
        //deplacement vers la droite
        else if (transform.position.x <= limitGauche + largeur)
        {
            dirX = 1;
        }
        transform.position +=new Vector3( dirX * vitesse * Time.deltaTime,0,0);
    }
}
