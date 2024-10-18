using System.Collections;
using UnityEngine;
using Photon.Pun;
 
 // プレイヤーを生成するためのスクリプト
public class StickPlayerGenerator : MonoBehaviourPunCallbacks
{
    public GameObject kuma;
    public GameObject rocket;
    bool netflag;
 
    void Start()
    {
        Debug.Log("netflag:"+netflag);
        if(netflag){
            if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
            {
                kuma = PhotonNetwork.Instantiate("kuma", new Vector3(-1.5f, -3.5f, 0), Quaternion.identity);
            }
            else
            {
                rocket = PhotonNetwork.Instantiate("rocket", new Vector3(1.5f, -3.5f, 0), Quaternion.identity);
            }
        }else{
            Instantiate(kuma,new Vector3(-1.5f,-3.5f,0),Quaternion.identity);
            Instantiate(rocket, new Vector3(1.5f, -3.5f, 0), Quaternion.identity);
        }
    }
}