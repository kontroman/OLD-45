using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMessage : MonoBehaviour
{
    public GameObject sprite_1;
    public GameObject sprite_2;
    private void Start()
    {
        sprite_1.SetActive(false);
        sprite_2.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            sprite_1.SetActive(true);
            sprite_2.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            sprite_1.SetActive(false);
            sprite_2.SetActive(false);
        }
    }
}
