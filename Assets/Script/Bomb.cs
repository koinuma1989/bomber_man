using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private int startFrame;
    public int count;
    public GameObject bombExproObj;
    public BombExpro bombExproScr;


    void Start()
    {
        startFrame = Time.frameCount;
        
        bombExproScr = bombExproObj.GetComponent<BombExpro>();
    }
    void Update()
    {
        if(count < Time.frameCount - startFrame){
            // 爆発
            bombExproScr.Exprosion(this.transform.position);
            Destroy(gameObject);
        }
    }
}
