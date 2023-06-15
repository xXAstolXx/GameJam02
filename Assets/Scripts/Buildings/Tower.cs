using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : Buildings
{
    [SerializeField]
    private GameObject playerMinion;
    
    private List<GameObject> playerMinionsList;

    private UI_FindClass ui_FindClass;


    private void Awake()
    {
        ui_FindClass = new UI_FindClass();
    }
    public void CreateUnit()
    {
        Vector3 rndPos = new Vector3 (Random.Range(-1, 1), 0, Random.Range(-1, 1));
        playerMinionsList.Add(Instantiate(playerMinion, transform.position + rndPos, Quaternion.identity));
    }

    public void OnClick()
    {
        ui_FindClass.UI_WatchTowerCanvas.GetComponent<TowerWindow>().SetVisibilty(true);
        ui_FindClass.UI_WatchTowerCanvas.GetComponent<TowerWindow>().SetPosition(transform.position + (Vector3.up * 5) + Vector3.right + Vector3.forward);
        ui_FindClass.UI_WatchTowerCanvas.GetComponent<TowerWindow>().SetCalledBy(gameObject);
        
    }
}
