using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour
{
    [SerializeField]
    protected float speed = 3.0f;

    [HideInInspector]
    public Vector3 targetOfThisUnit;

    public void MoveTowards(Vector3 target)
    {
        targetOfThisUnit = target;
    }

    public void OnTriggerEnter(Collider other)
    {
        Interact(other.gameObject);
    }

    protected virtual void Interact(GameObject collisionObject) { }
}
