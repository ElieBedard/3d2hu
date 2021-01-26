using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationTerrain : MonoBehaviour
{
    private float limitgauche = -10;
    private float limitdroite = 10;
    //utiliser local position
    public float distanceZMin;
    public float distanceZMax;

    public GameObject muret;
    private float largeurMuret;
    public float distanceMuretZ;

    public GameObject cylindre;
    public GameObject moulin;
    public GameObject murbouge;

    public GameObject spawner;
    public int distanceSpawner;

    public GameObject spawnerBoss;
    public int distanceSpawnerBosss;
    public int distancex = 70; //on change de zone à chaque boss

    public float limitgenz;
    private GameObject[] objets = new GameObject[4];
    // Start is called before the first frame update
    void Start()
    {
        largeurMuret = muret.gameObject.GetComponent<Renderer>().bounds.size.x/2;
        objets[0] = muret;
        objets[1] = cylindre;
        objets[2] = moulin;
        objets[3] = murbouge;

        //variable pour determiner si on a fini de remplir la scene
        float posz = 20f;
        //generation
        while (posz < limitgenz)
        {
            //on choisi au hasard l'objet à generer
            GameObject obstacle = objets[Random.Range(0, objets.Length)];


            //generation obstacles
            if (obstacle.name.Contains("Muret"))
            {
                Instantiate(muret, muret.transform.position+new Vector3((Random.Range(limitgauche + largeurMuret, limitdroite-largeurMuret)), 0, posz), Quaternion.identity);
                
                if (Random.Range(0, 2) == 0)//roll pour savoir si il y a un deuxieme mur
                {
                    posz += distanceMuretZ;
                    GameObject murTemp = Instantiate(muret, muret.transform.position + new Vector3(Random.Range(limitgauche + largeurMuret, limitdroite - largeurMuret), 0, posz), Quaternion.identity);
                    murTemp.transform.parent = transform;
                }

            }
            else
            {
                Instantiate(obstacle, obstacle.transform.position + new Vector3(0, 0, posz), obstacle.transform.rotation);
            }
            posz += Random.Range(distanceZMin, distanceZMax);

        }
        //generation spawner mob
        for (int i =distanceSpawner;i<limitgenz;i+=distanceSpawner)

        {
            Instantiate(spawner, transform.position + new Vector3(0,0,i),spawner.transform.rotation);

        }

        //Generation spawner boss
        int xTemp = 0;
        for (int i = distanceSpawnerBosss; i <= limitgenz; i += distanceSpawnerBosss)

        {
            //quand les boss seront programmés, les spawner ici
            xTemp += distancex;
            
            GameObject spawntemp =Instantiate(spawnerBoss, transform.position + new Vector3(0, 0, i), spawnerBoss.transform.rotation);
            
            spawntemp.GetComponent<SpawnBoss>().posJoueur += new Vector3(xTemp, 0,-spawntemp.GetComponent<SpawnBoss>().posJoueur.z);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
