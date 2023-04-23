using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform women;
    private Vector3 vectorKhoangcachCamera_nhanvat;
    
    private Vector3 vectorVitriBandau;
    
    private Vector3 vectorDichuyen;
    
    private float dieuKienDichuyen = 0;
    void Start()
    {
      
    }

    private void Awake()
    {
        women = GameObject.FindGameObjectWithTag("women").transform;
        vectorKhoangcachCamera_nhanvat = transform.position + women.position;
        vectorVitriBandau = new Vector3(0, 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        //cap nhat vi tri
        vectorDichuyen = women.position + vectorKhoangcachCamera_nhanvat;
        //cap nhat theo truc
        vectorDichuyen.x = 0;//khong di chuye camera theo truc x
        vectorDichuyen.y = Mathf.Clamp(vectorDichuyen.y, 3f, 5f);
        //cap nhat vi tri moi cho camera
        transform.position = vectorDichuyen;
        //kiem tra dieu kian di chuyen
        if (dieuKienDichuyen>1f)
        {
            transform.position = vectorDichuyen; // nhan vi tri gan nhat
        }
        else
        {
            //di chuyen 
            transform.position = Vector3.Lerp(vectorDichuyen + vectorVitriBandau,
                vectorDichuyen, dieuKienDichuyen);
        }
        //cap nhat lai dieu kien
        dieuKienDichuyen += 0.5f * Time.deltaTime;
        //follow nhan vat
        transform.LookAt(women.position);

    }
}
