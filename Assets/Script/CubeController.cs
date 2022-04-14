using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class CubeController : MLAPI.NetworkBehaviour
{
    void FixedUpdate()
    {
        if (!this.IsOwner) return;
        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.1f, 0.0f, 0.0f);
        }
        // 右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.1f, 0.0f, 0.0f);
        }
        // 上に移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0.0f, 0.1f, 0.0f);
        }
        // 下に移動
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0.0f, -0.1f, 0.0f);
        }
    }
}