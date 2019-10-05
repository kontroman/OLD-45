using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuidoSingleton : MonoBehaviour
{
    private static AuidoSingleton _instance;

    public static AuidoSingleton instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<AuidoSingleton>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            if (this != _instance)
            {
                Destroy(this.gameObject);
            }
        }
    }
    public void Update()
    {
        if (this != _instance)
        {
            _instance = null;
        }
    }
    public void Play()
    {
        this.gameObject.GetComponent<AuidoSingleton>().Play();
    }
}