
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusil : MonoBehaviour
{
    public GameObject joueur;
    public GameObject emmeteur;
    public GameObject balle;
    public float tempsDestruction;
    public float forceBalle;
    public float timerBalle;
    public float distanceZ;
    private float timerTemp;
    private bool peutTirer = true;

    // Start is called before the first frame update
    void Start()
    {
        timerTemp = timerBalle;

    }

    // Update is called once per frame
    void Update()
    {
        timerTemp -= Time.deltaTime;
        if (timerTemp <= 0)
        {
            peutTirer = true;
            timerTemp = timerBalle;
        }
        if (Input.GetMouseButton(0) && peutTirer)
        {
            peutTirer = false;
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceZ);
            position = Camera.main.ScreenToWorldPoint(position);
            GameObject balleTemp = Instantiate(balle, emmeteur.transform.position, Quaternion.identity);
            Vector3 direction = position - emmeteur.transform.position;
            direction.Normalize();
            balleTemp.GetComponent<Rigidbody>().AddForce(new Vector3(direction.x, direction.y, 1) * forceBalle);
            //on met la balle child de joueur pour qu'elle avance avec le joueur
            balleTemp.transform.parent = joueur.transform.parent;
            Destroy(balleTemp, tempsDestruction);

        }
    }

}

