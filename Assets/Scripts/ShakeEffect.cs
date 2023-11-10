using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeEffect : MonoBehaviour
{
    private Vector3 initialPosition;

    private void Awake()
    {
        initialPosition = transform.localPosition;
    }

    public void StartShake(float offset, float duration)
    {
        StopShake();
        StartCoroutine(ShakeTime(offset, duration));
    }

    public void StopShake()
    {
        StopAllCoroutines();
        transform.localPosition = initialPosition;
    }

    private IEnumerator ShakeTime(float offset, float duration)
    {
        float durationPassed = 0f;

        while(durationPassed < duration)
        {
            Shake(offset);
            durationPassed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = initialPosition;  
    }
    
    private void Shake(float maxOffset)
    {
       
        float xOffset = Random.Range(-maxOffset, maxOffset);
        float yOffset = Random.Range(-maxOffset, maxOffset);

        transform.localPosition = initialPosition + new Vector3(xOffset, yOffset, 0f);    
    }
}
