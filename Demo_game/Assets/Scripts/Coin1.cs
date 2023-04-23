using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin1 : MonoBehaviour
{
    private MeshCollider _meshCollider; //mat luoi cua coin

    private List<String> arrCoin = new List<string>();
    private void Awake()
    {
        _meshCollider = GetComponent<MeshCollider>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right,2);//coin xoay sang ben phai
    }

    public void Dead()
    {

        if (!arrCoin.Contains("Coin 1"))
        {
            
        }
        Destroy(gameObject);//xoa coin
    }
}
