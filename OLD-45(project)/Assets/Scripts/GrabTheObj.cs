using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabTheObj : MonoBehaviour
{
    private bool isGrabbing = false;
    private bool canGrab = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canGrab && !isGrabbing)
            {
                isGrabbing = true;
                gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>());
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isGrabbing)
            {
                gameObject.transform.parent = null;
                isGrabbing = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            canGrab = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            canGrab = false;
    }
}
