using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteors : MonoBehaviour
{
    public GameObject meteor_prefab;
    private Vector3 position;

    private void Start()
    {
        InvokeRepeating("CreateMeteor", 1, 4f);
    }

    Vector3 GetPosition()
    {
        position = new Vector3(Random.Range(gameObject.transform.position.x - 12, gameObject.transform.position.x + 22), Random.Range(gameObject.transform.position.y, gameObject.transform.position.y + 7), transform.position.z);
        return position;
    }

    void CreateMeteor()
    {
        for(int i = 0; i<2; i++)
        {
            GameObject meteor = Instantiate(meteor_prefab, GetPosition(), Quaternion.identity);
            Destroy(meteor, 15f);
        }
    }
}
