using UnityEngine;

public class Bullet : MonoBehaviour
{
    Transform target;

    public float bulletSpeed = 10f;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    private void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = bulletSpeed * Time.deltaTime;

        if(direction.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceThisFrame, Space.World);

    }

    private void HitTarget()
    {
        Destroy(gameObject);
        Time.timeScale = 0.3f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Character character = collision.gameObject.GetComponentInParent<Character>();

        if(character != null)
        {
            character.DoRagdoll(true);
        }
    }
}
