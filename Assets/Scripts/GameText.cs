using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameText : MonoBehaviour
{
    public Shoot shoot;
    void Update()
    {
        string info = "Bullet speed: " + shoot.bulletData.GetBulletDesc;
        GetComponent<Text>().text = info;
    }
}
