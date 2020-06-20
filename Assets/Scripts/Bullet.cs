using UnityEngine;

public class Bullet : MonoBehaviour
{
    Transform target;

    public float bulletSpeed = 10f;

    GameProperties gameProperties;

    float timeScale = 0.4f;

    private void Start()
    {
        gameProperties = GameObject.Find("GameProperties").GetComponent<GameProperties>();
    }

    //Seek target
    public void Seek(Transform _target)
    {
        target = _target;
    }

    private void Update()
    {
        //If not a target destroy bullet
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

        //Bullet mooving 
        transform.Translate(direction.normalized * distanceThisFrame, Space.World);

    }

    private void HitTarget()
    {
        Destroy(gameObject);
        //Do slow motion effect
        gameProperties.SlowMotion(timeScale);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Character character = collision.gameObject.GetComponentInParent<Character>();

        //Do Enemy Ragdoll
        if(character != null)
        {
            character.DoRagdoll(true);
        }
    }
}
