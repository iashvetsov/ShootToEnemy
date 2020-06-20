using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProperties : MonoBehaviour
{
    float waitSec = 0.5f;

    private void Update()
    {
        if(Time.timeScale != 1.0f)
        {
            StartCoroutine(ResetTimeScale());
        }
    }

    //Get Slow motion effect
    public void SlowMotion(float timeScale)
    {
        Time.timeScale = timeScale;
    }

    IEnumerator ResetTimeScale()
    {
        yield return new WaitForSeconds(waitSec);
        Time.timeScale = 1.0f;
    }
}
