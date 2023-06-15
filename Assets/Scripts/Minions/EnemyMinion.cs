using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMinion : Minion
{
    protected override void Interact(GameObject collisionObject)
    {
        if (collisionObject != null)
        {
            if (collisionObject.GetComponent<PlayerMinion>() != null)
            {
                Charge(collisionObject.transform.position);
            }

            if (collisionObject.GetComponent<HQ>() != null)
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
