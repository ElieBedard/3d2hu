using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int distanceZ;

    public GameObject mob1;
    public float xMinMob1;
    public float xMaxMob1;
    private GameObject ennemiChoisi;
    // Start is called before the first frame update
    void Start()
    {
        ennemiChoisi = mob1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Joueur")
        {
            Instantiate(ennemiChoisi, ennemiChoisi.transform.position + new Vector3(0, 0, distanceZ+transform.position.z), ennemiChoisi.transform.rotation);
        }
        
        //entemp.transform.parent = transform;
    }
}
