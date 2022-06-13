using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake(float duracao, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float decorrido = 0.0f;

        while(decorrido < duracao)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            decorrido += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }

}
