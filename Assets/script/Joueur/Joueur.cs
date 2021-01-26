using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    //public float zAcc;

    public int vie; 
    private Vector3 vecDeplacement;
    public int vitesse;
    public float graviteY;
    public int forceSaut;
    public int forceDescente;
    private bool isgrounded = true;
    private bool surMurGauche = false;
    private bool surMurDroit = false;


    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, graviteY, 0);

    }

    // Update is called once per frame
    void Update()
    {

        vecDeplacement = transform.position;
        //saut
        if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * forceSaut, ForceMode.Impulse);
        }
        //descendre
        else if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.down * forceDescente, ForceMode.Impulse);
        }
        //gauche
        if (!surMurGauche && Input.GetKey(KeyCode.A))
        {
            vecDeplacement.x += -Time.deltaTime * vitesse;
        }
        //droite
        if (!surMurDroit && Input.GetKey(KeyCode.D))
        {
            vecDeplacement.x += Time.deltaTime * vitesse;
        }

        transform.position = vecDeplacement;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("mur gauche"))
        {
            surMurGauche = true;
        }
        else if (collision.gameObject.name.Contains("mur droit"))
        {
            surMurDroit = true;
        }

        if (collision.gameObject.name.Contains("Terrain"))
        {
            isgrounded = true;
        }
        if (collision.gameObject.name.Contains("Ennemi"))
        {
            if (vie == 0)
            {
                Application.LoadLevel(0);
            }
            vie -= 1;//dans le futur j'ajouterai un dommage spécifique selon l'ennemi
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.Contains("mur gauche"))
        {
            surMurGauche = false;
        }
        else if (collision.gameObject.name.Contains("mur droit"))
        {
            surMurDroit = false;
        }

        if (collision.gameObject.name.Contains("Terrain"))
        {
            isgrounded = false;
        }
    }
}

