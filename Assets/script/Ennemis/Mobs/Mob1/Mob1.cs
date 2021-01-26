using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1 : EnnemiParent
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Mort()
    {
        Destroy(gameObject);
        //drop item
    }
}
