using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerWindow : UI_Window
{
    private Button destroyTowerBtn;

    private Button attackBtn;
    private Button createBtn;

    private void Awake()
    {
        destroyTowerBtn = GameObject.Find("DestroyWatchTowerBtn").GetComponent<Button>();
        destroyTowerBtn.onClick.AddListener(DestroyWatchTower);

        attackBtn = GameObject.Find("AttackBtn").GetComponent<Button>();
        attackBtn.onClick.AddListener(Attack);

        createBtn = GameObject.Find("CreateMinionsBtn").GetComponent <Button>();
        createBtn.onClick.AddListener(CreateMinions);


    }

    public void DestroyWatchTower()
    {
        calledBy.GetComponent<Tower>().DeleteSelf();
    }

    public void Attack()
    {
        Debug.Log("Attack");
    }

    public void CreateMinions()
    {
        Debug.Log("Create");
    }
}
