using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class MLAPI_GUI : MonoBehaviour
{
    void OnGUI()
    {
        if(Input.GetKeyDown(KeyCode.K)){
            NetworkManager.Singleton.StartHost();
        }
        if(Input.GetKeyDown(KeyCode.L)){
            NetworkManager.Singleton.StartClient();
        }
        
        if (GUI.Button(new Rect(20, 20, 100,50),"StartHost"))
        {
            NetworkManager.Singleton.StartHost();
        };
        if (GUI.Button(new Rect(20, 70, 100, 50), "StartClient"))
        {
            NetworkManager.Singleton.StartClient();
        };
    }
}
