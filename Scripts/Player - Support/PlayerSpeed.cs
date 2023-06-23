using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeed : MonoBehaviour
{
    private bool isSpeedChanging;
    private bool isErrorTouching;
    private bool isIncrease;

    public void IncreaseSpeed(float multiplier, float duration)
    {
        if (!isSpeedChanging && !isErrorTouching)
        {
            isSpeedChanging = true; 
            isIncrease = true;
            GameManager.instance.speed *= multiplier;
            StartCoroutine(RestoreSpeed(multiplier, duration));
        }
    }

    public void DecreaseSpeed(float multiplier, float duration)
    {
        if (!isSpeedChanging && !isErrorTouching)
        {
            isSpeedChanging = true; 
            isIncrease = false;
            GameManager.instance.speed /= multiplier;
            StartCoroutine(RestoreSpeed(multiplier, duration));
        }
    }

    private IEnumerator RestoreSpeed(float multiplier, float duration)
    {
        yield return new WaitForSeconds(duration);

        if (isIncrease)
        {
            GameManager.instance.speed /= multiplier;
        }
        else
        {
            GameManager.instance.speed *= multiplier;
        }

        isSpeedChanging = false;
        isErrorTouching = false;
    }
}
