using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShaker : MonoBehaviour
{
    public static Camera mainCam;
    private static float shakeAmount = 0;

    void Awake()
    {
        if (mainCam == null)
        {
            mainCam = Camera.main;
        }
    }
    public static void Shake()
    {
        //shakeAmount = amount;
        //InvokeRepeating("DoShake", 0f, 0.01f);
        //Invoke("StopShake", length);
    }

    public static void DoShake(float amount, float length)
    {

        if (amount > 0)
        {
            Vector3 camPos = mainCam.transform.position;
            float offsetX = Random.value * amount * 1.05f - amount;
            float offsetY = Random.value * amount * 1.05f - amount;
            camPos.x += offsetX/3;
            camPos.y += offsetY/3;
            mainCam.transform.position = camPos;
        }
    }

    static void StopShake()
    {
        //CancelInvoke("DoShake");
        mainCam.transform.localPosition = Vector3.zero;
    }
}
