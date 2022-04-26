using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGene : MonoBehaviour
{
    public GameObject bombPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bombPrefab, this.transform.position, Quaternion.identity);
            Debug.Log(this.transform.position);
        }
    }
}
