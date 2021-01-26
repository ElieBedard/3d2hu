using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnnemiParent : MonoBehaviour
{
    public int vie;

    public abstract void Mort();

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("BalleJoueur"))
        {
            if (vie == 0)
            {
                Mort();
            }
            vie -= 1;//si on change le dmg des balles on utilisera la variable dmgballe de la balle
        }
    }



}
