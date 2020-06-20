using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New BulletData", menuName = "Bullet Data", order = 51)]
public class BulletData : ScriptableObject
{
    [SerializeField]
    private float bulletSpeed; //speed
    [SerializeField]
    private string bulletDesc; //description

    public float GetBulletSpeed
    {
        get
        {
            return bulletSpeed;
        }
    }

    public string GetBulletDesc
    {
        get
        {
            return bulletDesc;
        }
    }
}
