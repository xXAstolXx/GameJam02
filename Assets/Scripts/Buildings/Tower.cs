using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : Buildings
{
    [SerializeField]
    private GameObject playerMinion;
    
    private List<GameObject> playerMinionsList;

    public void CreateUnit()
    {
        Vector3 rndPos = new Vector3 (Random.Range(-1, 1), 0, Random.Range(-1, 1));
        playerMinionsList.Add(Instantiate(playerMinion, transform.position + rndPos, Quaternion.identity));
    }
}
