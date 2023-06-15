using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HQ : Buildings
{
    [SerializeField]
    private int HP = 100;

    [SerializeField]
    private int damagePerHit = 1;

    public void GetHit()
    {
        HP -= damagePerHit;
        if (HP <= 0 )
        {
            //Todo: Call UI DeathScreen
        }
    }
}
