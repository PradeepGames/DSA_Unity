using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WebReq : MonoBehaviour
{
   
    void Start()
    {
        StartCoroutine(Upload());
    }


    private IEnumerator Upload()
    {
        MachineData machineData = new MachineData();
        machineData.machinemacid = "047c16483e2b";
        machineData.project_id = "lnt-mahim-2hozh";

        string url = "https://5b43-27-107-128-100.ngrok-free.app/v/machine/machine-login";
        string contentJson = JsonUtility.ToJson(machineData);
        Debug.Log(contentJson);

        using (UnityWebRequest www = UnityWebRequest.Post(url, contentJson, "application/json"))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success){
                Debug.LogError(www.error);
            }else{
                Debug.Log("Form upload complete = " + www.downloadHandler.text);
            }
        }
    }
}

[Serializable]
public class MachineData
{
   public string machinemacid;
   public string project_id;
}