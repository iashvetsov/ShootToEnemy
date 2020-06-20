using UnityEngine;

public class Character : MonoBehaviour
{
    private void Awake()
    {
        DoRagdoll(false);
    }

    public void DoRagdoll(bool isRagdoll)
    {
        GetComponent<Animator>().enabled = !isRagdoll;
    }
}
