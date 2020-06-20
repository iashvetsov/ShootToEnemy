using UnityEngine;

public class Character : MonoBehaviour
{
    private void Awake()
    {
        DoRagdoll(false);
    }

    //Use for Ragdoll Death
    public void DoRagdoll(bool isRagdoll)
    {
        GetComponent<Animator>().enabled = !isRagdoll;
    }
}
