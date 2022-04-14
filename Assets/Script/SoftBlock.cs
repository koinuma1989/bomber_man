using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftBlock : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Explosion"){
            
            this.GetComponent<MeshRenderer>().material.color = Color.black;
            Destroy(this.gameObject, 1f);
            
            int r = Random.Range(0, 100);
            Debug.Log(r);
            if(r > 50){
                ItemGene();
            }
            

        }
    }
    
    private void ItemGene(){
        int r = Random.Range(0, 1);

        switch(r){
            case 0: //ファイア
                Debug.Log('f');
                break;
            case 1: //ボム
                Debug.Log('b');
                break;
            }
        }
}
