using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Show info about bullet speed
public class GameText : MonoBehaviour
{
    public Shoot shoot;
    void Update()
    {
        string info = "Bullet speed: " + shoot.bulletData.GetBulletDesc;
        GetComponent<Text>().text = info;
    }
}
