using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeCode : MonoBehaviour
{
    public int code;
    public InputField _field;
    public void CheckCode()
    {
        string codeText = code.ToString();
        if (_field.text == codeText)
        {
            GameController.FinishScene();
        }
        else
        {
            CamShaker.DoShake(3, 0.5f);
        }
    }
}
