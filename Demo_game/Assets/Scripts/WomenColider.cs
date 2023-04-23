using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class WomenColider : MonoBehaviour
{
    [SerializeField] private Text locationText;
    public AudioClip collectSound; //xu ly am thanh khi va cham

    private bool isHitStone = true; //trang thai va cham voi đá 

    // private AudioSource anXU;
    private Text showtextCoin;
    private List<String> arrCoin = new List<string>();
    private String textShow = "";
    private float time;

    void Start()
    {
        //anXU = GetComponent<AudioSource>();
        showtextCoin = GameObject.FindWithTag("textCoin").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    //ham su ly va cham
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag.Equals("Coin")) //neu nhan vat va cham voi coin 
        {
            //xy ly am thanh
            SoundManager.Instance.PlaySound(collectSound);
            // anXU.Play();
            //---
            hit.gameObject.GetComponent<Coin1>().Dead(); //truy nhap ham Dead() tu Coin1
            //tang 1 diem
            GetComponent<ScoreManager>().TangDiem(1);
            GetComponent<WomenHealth>().ModifyHeadlth(1);
        }

        if (hit.gameObject.tag.Equals("Stone")) //neu va cham voi da thi tru diem
        {
            if (isHitStone)
            {
                GetComponent<WomenHealth>().ModifyHeadlth(-10); //va cham da -10 diem
                //tru diem
                StartCoroutine(EnabaleCollider(hit, 1)); //gioong thread

                hit.gameObject.GetComponent<Stone>().Hanhdong();
            }
        }

        //update len text cua canvas 
        if (hit.gameObject.tag.Equals("MushroomLocation"))
        {
            locationText.text = "MushroomLocation";
        }

        if (hit.gameObject.tag.Equals("StoneLocation"))
        {
            locationText.text = "StoneLocation";
        }

        if (hit.gameObject.tag.Equals("FireLocation"))
        {
            locationText.text = "FireLocation";
        }

        if (hit.gameObject.tag.Equals("HouseLocation"))
        {
            locationText.text = "HouseLocation";
        }

        if (arrCoin.Count == 6)
        {
            time += Time.deltaTime;

            if (time > 5f)
            {
                arrCoin.Sort();
                textShow = "";

                for (int i = 0; i < arrCoin.Count; i++)
                {
                    textShow = textShow + ", " + arrCoin[i];
                }

                showtextCoin.text = " " + textShow;
            }
        }


        if (hit.gameObject.tag.Equals("coin1")) //neu nhan vat va cham voi coin 1
        {
            //xy ly am thanh
            SoundManager.Instance.PlaySound(collectSound);
            // anXU.Play();
            //---
            hit.gameObject.GetComponent<Coin1>().Dead(); //truy nhap ham Dead() tu Coin1
            //tang 1 diem
            GetComponent<ScoreManager>().TangDiem(1);
            GetComponent<WomenHealth>().ModifyHeadlth(1);

            if (!arrCoin.Contains("Coin1"))
            {
                arrCoin.Add("Coin1");
                textShow = "";

                for (int i = 0; i < arrCoin.Count; i++)
                {
                    textShow = textShow + ", " + arrCoin[i];
                }

                showtextCoin.text = textShow;
            }
        }


        if (hit.gameObject.tag.Equals("coin2")) //neu nhan vat va cham voi coin 1
        {
            //xy ly am thanh
            SoundManager.Instance.PlaySound(collectSound);
            // anXU.Play();
            //---
            hit.gameObject.GetComponent<Coin1>().Dead(); //truy nhap ham Dead() tu Coin1
            //tang 1 diem
            GetComponent<ScoreManager>().TangDiem(1);
            GetComponent<WomenHealth>().ModifyHeadlth(1);

            if (!arrCoin.Contains("Coin2"))
            {
                arrCoin.Add("Coin2");
                textShow = "";

                for (int i = 0; i < arrCoin.Count; i++)
                {
                    textShow = textShow + ", " + arrCoin[i];
                }

                showtextCoin.text = textShow;
            }
        }

        if (hit.gameObject.tag.Equals("coin3")) //neu nhan vat va cham voi coin 1
        {
            //xy ly am thanh
            SoundManager.Instance.PlaySound(collectSound);
            // anXU.Play();
            //---
            hit.gameObject.GetComponent<Coin1>().Dead(); //truy nhap ham Dead() tu Coin1
            //tang 1 diem
            GetComponent<ScoreManager>().TangDiem(1);
            GetComponent<WomenHealth>().ModifyHeadlth(1);

            if (!arrCoin.Contains("Coin3"))
            {
                arrCoin.Add("Coin3");
                textShow = "";

                for (int i = 0; i < arrCoin.Count; i++)
                {
                    textShow = textShow + ", " + arrCoin[i];
                }

                showtextCoin.text = textShow;
            }
        }


        if (hit.gameObject.tag.Equals("coin4")) //neu nhan vat va cham voi coin 1
        {
            //xy ly am thanh
            SoundManager.Instance.PlaySound(collectSound);
            // anXU.Play();
            //---
            hit.gameObject.GetComponent<Coin1>().Dead(); //truy nhap ham Dead() tu Coin1
            //tang 1 diem
            GetComponent<ScoreManager>().TangDiem(1);
            GetComponent<WomenHealth>().ModifyHeadlth(1);

            if (!arrCoin.Contains("Coin4"))
            {
                arrCoin.Add("Coin4");
                textShow = "";

                for (int i = 0; i < arrCoin.Count; i++)
                {
                    textShow = textShow + ", " + arrCoin[i];
                }

                showtextCoin.text = textShow;
            }
        }

        if (hit.gameObject.tag.Equals("coin5")) //neu nhan vat va cham voi coin 1
        {
            //xy ly am thanh
            SoundManager.Instance.PlaySound(collectSound);
            // anXU.Play();
            //---
            hit.gameObject.GetComponent<Coin1>().Dead(); //truy nhap ham Dead() tu Coin1
            //tang 1 diem
            GetComponent<ScoreManager>().TangDiem(1);
            GetComponent<WomenHealth>().ModifyHeadlth(1);

            if (!arrCoin.Contains("Coin5"))
            {
                arrCoin.Add("Coin5");
                textShow = "";

                for (int i = 0; i < arrCoin.Count; i++)
                {
                    textShow = textShow + ", " + arrCoin[i];
                }

                showtextCoin.text = textShow;
            }
        }

        if (hit.gameObject.tag.Equals("coin6")) //neu nhan vat va cham voi coin 1
        {
            //xy ly am thanh
            SoundManager.Instance.PlaySound(collectSound);
            // anXU.Play();
            //---
            hit.gameObject.GetComponent<Coin1>().Dead(); //truy nhap ham Dead() tu Coin1
            //tang 1 diem
            GetComponent<ScoreManager>().TangDiem(1);
            GetComponent<WomenHealth>().ModifyHeadlth(1);

            if (!arrCoin.Contains("Coin6"))
            {
                arrCoin.Add("Coin6");
                textShow = "";

                for (int i = 0; i < arrCoin.Count; i++)
                {
                    textShow = textShow + ", " + arrCoin[i];
                }

                showtextCoin.text = textShow;
            }
        }

        if (hit.gameObject.tag.Equals("coin7")) //neu nhan vat va cham voi coin 1
        {
            //xy ly am thanh
            SoundManager.Instance.PlaySound(collectSound);
            // anXU.Play();
            //---
            hit.gameObject.GetComponent<Coin1>().Dead(); //truy nhap ham Dead() tu Coin1
            //tang 1 diem
            GetComponent<ScoreManager>().TangDiem(1);
            GetComponent<WomenHealth>().ModifyHeadlth(1);

            if (arrCoin.Count > 6)
            {
                if (!arrCoin.Contains("Coin7"))
                {
                    arrCoin.Add("Coin7");
                    
                    arrCoin.Sort();
                    arrCoin.Reverse();
                    textShow = "";
                    
                    // dao nguoc chuoi

                    for (int i = 0; i < arrCoin.Count; i++)
                    {
                        textShow = textShow + ", " + arrCoin[i];
                    }

                    showtextCoin.text = textShow;
                }
            }
        }
        
        if (hit.gameObject.tag.Equals("coin8")) //neu nhan vat va cham voi coin 1
        {
            //xy ly am thanh
            SoundManager.Instance.PlaySound(collectSound);
            // anXU.Play();
            //---
            hit.gameObject.GetComponent<Coin1>().Dead(); //truy nhap ham Dead() tu Coin1
            //tang 1 diem
            GetComponent<ScoreManager>().TangDiem(1);
            GetComponent<WomenHealth>().ModifyHeadlth(1);

            if (arrCoin.Count > 6)
            {
                   
                arrCoin.Sort();
                arrCoin.Reverse(); // dao nguoc chuoi
            }
            
            if (!arrCoin.Contains("Coin8"))
            {
                arrCoin.Add("Coin8");
                textShow = "";
                
                for (int i = 0; i < arrCoin.Count; i++)
                {
                    textShow = textShow + ", " + arrCoin[i];
                }

                showtextCoin.text = textShow;
            }
        }
    }

    private IEnumerator EnabaleCollider(ControllerColliderHit hit, float second)
    {
        isHitStone = false;
        yield return new WaitForSeconds(second);
        isHitStone = true;
    }
}