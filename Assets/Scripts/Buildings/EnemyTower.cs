using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTower : Buildings
{
    [SerializeField]
    private int HP = 100;

    [SerializeField]
    private int damagePerHit;

    [SerializeField]
    private GameObject enemyMinion;

    private List<GameObject> enemyMinionsList;

    public void CreateUnit()
    {
        Vector3 rndPos = new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1));
        enemyMinionsList.Add(Instantiate(enemyMinion, transform.position + rndPos, Quaternion.identity));
    }
    
    public void TakeDamage()
    {
        HP -= damagePerHit;
        if (HP < 0)
        {
            DeleteSelf();
        }
    }
}
