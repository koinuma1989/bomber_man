using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BomGenerate : MonoBehaviour
{
    public GameObject bomb;
    private Vector3 bombPutPos;
    private bool isBombExist;

    private GameObject instBomb;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "TriggerBlock"){
            bombPutPos = other.transform.position;
            bombPutPos.y = 2f;
        }

        if (other.gameObject.tag == "Bomb"){
            isBombExist = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Bomb"){
            isBombExist = false;
            instBomb.GetComponent<Collider>().isTrigger = false;
        }
    }
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Z)){
            if(isBombExist){ // 既にボムが置かれてたらおけない
                return;
            }

            Vector3 pos = this.transform.position;
            instBomb = Instantiate(bomb, bombPutPos, bomb.transform.rotation) as GameObject;
            
        }
    }
}
