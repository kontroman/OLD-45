using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMaskController : MonoBehaviour
{
    public SpriteMask mainMask;
    private Vector3 mousePosition;
    public GameObject prefabMask;
    private void Start()
    {
        InvokeRepeating("CreateNewSpriteMask", 0, 0.01f);
    }

    private void Update()
    {
        Cursor.visible = false;
        mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        mainMask.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }

    void CreateNewSpriteMask()
    {
        GameObject newMask = Instantiate(prefabMask, mainMask.transform.position, Quaternion.identity);
        Destroy(newMask, 0.5f);
    }
}
