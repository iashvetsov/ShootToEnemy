using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBullet : MonoBehaviour
{
    [SerializeField]
    private BulletData bulletData;
    [SerializeField]
    private Shoot shoot;

    public void ChooseSpeed()
    {
        shoot.bulletData = bulletData;
    }
}
