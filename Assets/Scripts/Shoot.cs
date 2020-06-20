using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Transform target;

    public GameObject bulletPrefab;

    public BulletData bulletData;

    private bool isZombie;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Find target
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits = Physics.RaycastAll(ray);

            foreach(RaycastHit hit in hits)
            {
                target = hit.collider.transform;
                if(hit.collider.tag == "notZombie")
                {
                    isZombie = false;
                }
                else
                {
                    isZombie = true;
                }
            }

            if(isZombie)
                //Shoot
                FireBullet();
        }
    }

    private void FireBullet()
    {
        GameObject bulletGameObject = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
        Bullet bullet = bulletGameObject.GetComponent<Bullet>();
        bullet.bulletSpeed = bulletData.GetBulletSpeed;

        if(bullet != null)
        {
            //Transfer the target to the bullet
            bullet.Seek(target);
        }
    }
}
