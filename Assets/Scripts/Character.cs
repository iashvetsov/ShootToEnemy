using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Collider[] allColliders;

    private void Awake()
    {
        allColliders = GetComponentsInChildren<Collider>(true);

        DoRagdoll(false);
    }

    public void DoRagdoll(bool isRagdoll)
    {
        GetComponent<Animator>().enabled = !isRagdoll;
    }
}
