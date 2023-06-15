using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerMinion : Minion
{
    protected override void Interact(GameObject collisionObject)
    {
        if (collisionObject != null) 
        {
            if (collisionObject.GetComponent<EnemyMinion>() != null) 
            {
                Charge(collisionObject.transform.position);
            }

            if (collisionObject.GetComponent<EnemyTower>() != null)
            {
                Charge(collisionObject.transform.position);
            }
        }
    }

    private void Attack()
    {

    }

    private void Charge(Vector3 target)
    {
        MoveTowards(target);
    }

    private void Update()
    {
        MoveTowards(targetOfThisUnit * speed * Time.deltaTime);
    }
}
