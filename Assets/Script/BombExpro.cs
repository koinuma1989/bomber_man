using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BombExpro : MonoBehaviour
{
    public GameObject exp;
    private List<GameObject> instantExps = new List<GameObject>();
    private bool[] isStop = new bool[]{false, false, false, false}; //左から上、下、左、右の爆発継続判定

    public void Exprosion(Vector3 pos){
        int range = 8;
        for(float f=0; f <= range; f++){
            if(!isStop[0]){
                InstantExp(new Vector3(pos.x, 0, pos.z + f), "up"); //上方向
            }
            if(!isStop[1]){
                InstantExp(new Vector3(pos.x, 0, pos.z - f), "down"); //下方向
            }
            if(!isStop[2]){
                InstantExp(new Vector3(pos.x - f, 0, pos.z), "left"); //左方向
            }
            if(!isStop[3]){
                InstantExp(new Vector3(pos.x + f, 0, pos.z), "right"); //右方向
            }
        }
        foreach (GameObject instantExp in instantExps){
            Destroy(instantExp, 1f);
        }
        instantExps.Clear();
        for(int i=0; i < 4; i++){ //爆発継続判定リセット
            isStop[i] = false;
        }
    }

    private bool InstantExp(Vector3 pos, string way){
        GameObject tmpExp = Instantiate(exp, pos, exp.transform.rotation) as GameObject;
        instantExps.Add(tmpExp);
        if(Array.IndexOf(Const.hardBlock, pos) != -1 || Const.softBlock.IndexOf(pos) != -1){
            if(way == "up"){
                isStop[0] = true;
            }
            if(way == "down"){
                isStop[1] = true;
            }
            if(way == "left"){
                isStop[2] = true;
            }
            if(way == "right"){
                isStop[3] = true;
            }

            if(Const.softBlock.IndexOf(pos) != -1){ //ソフトブロックは壊れたらリストから削除
                Const.softBlock.RemoveAt(Const.softBlock.IndexOf(pos));
            }

            return false;
        }
        return true;
    }

    
}
