using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleJoueur : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //le parent de la balle est le joueur, on enleve le parent lors de la collision pour que la balle arrete d'avancer avec le joueur
        transform.parent = null;
    }
}
