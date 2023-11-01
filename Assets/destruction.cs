using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruction : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //Unityちゃんとの相対距離
    private float difference;


    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんと相対距離を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        Debug.Log(difference);

        if (difference > 6.0f)
        {
            Destroy(this.gameObject);
        }

       
    }
}
