using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] tilesPrefabs; //mang chua prefab
    private List<GameObject> activesTiles; // cac dia hinh dang duoc active
    private Transform women; // nhan vat
    private float spawnZ = 0f; //khoang cach bien doi
    private float tileLength = 44f; //chieu dai dia hinh
    private int tilesOnScreen = 4; // so dia hinh hien thi tren man hinh
    //ham tao dia hinh sau khi nhan vat di het
    private void TaoDiaHinh(int index = -1)
    {
        GameObject gameObject;//khai bao gameobject
        if (index == 0) // chi so = 0 -> thanh phan dau tien cua mang
        {
            gameObject = Instantiate(tilesPrefabs[0]); // dua dia hinh so 0 va0
        }
        else //lay ngau nhien 1 dia hinh trong mang
        {
            gameObject = Instantiate(tilesPrefabs[Random.Range(1,tilesPrefabs.Length)]); //lay ngau nhien 1 dia hinh trong mang
            
        }
        //dua dia hinh moi tao vao game
        gameObject.transform.SetParent(transform);
        //thuc hien bien doi dia hinh
        gameObject.transform.position = Vector3.forward * spawnZ;
        //xac dinh vi tri moi
        spawnZ += tileLength;
        //dua gameobject vao mang 
        activesTiles.Add(gameObject);
    }
    
    //ham xoa dia hinh
    private void xoaDiaHinh()
    {
        Destroy(activesTiles[0]); //cancel
        activesTiles.RemoveAt(0); // xoa trong mang
    }
    void Start()
    {
        //khoi tao cac bien, mang, anh xa nhanvat
        activesTiles = new List<GameObject>(); //khoi tao danh sach dia hinh
        women = GameObject.FindGameObjectWithTag("women").transform;//anh xa
        //use vong lap de tao dia hinh
        for (int i = 0; i < tilesOnScreen; i++)
        {
            if (i < 1)
            {
                TaoDiaHinh(0);
            }
            else
            {
                TaoDiaHinh(1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //tao dia hinh khi nvat den va xoa dia hinh khi nvat di qua
        //dieu kien tao dia hinh
        if ((women.position.z - tileLength) > (spawnZ - tileLength * tilesOnScreen) )
        {
            TaoDiaHinh(); //tao khi nhan vat den
            xoaDiaHinh(); //xoa khi nhan vat di qua
        }
    }
}
