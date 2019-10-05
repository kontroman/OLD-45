using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassAnim : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("GRASS");
            gameObject.GetComponent<Animator>().SetTrigger("GrassAnim");
        }
    }
}
