using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HQ : Buildings
{
    [SerializeField]
    private int HP = 100;

    [SerializeField]
    private int damagePerHit = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColloredCell") == true)
        {
            other.GetComponent<ColoredCells>().SetField("Active");
        }
    }

    public void GetHit()
    {
        HP -= damagePerHit;
        if (HP <= 0 )
        {
            //Todo: Call UI DeathScreen
        }
    }
}
