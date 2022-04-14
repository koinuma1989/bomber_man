using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int bombPutNum;
    public int fireRange;
    public GameObject EnergyExplosion;
    public GameObject player;
    public GameObject mainCamera;
    public GameObject deathCamera;

    private List<GameObject> instantExps = new List<GameObject>();


    void Start()
    {
        // 初期値
        bombPutNum = 1;
        fireRange = 1;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Explosion"){
            GameObject tmpExp = Instantiate(EnergyExplosion, this.transform.position, Quaternion.identity) as GameObject;
            Destroy(tmpExp);
            Destroy(mainCamera);
            Destroy(player);
            deathCamera.SetActive(true);
        }
    }
}
