using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomenHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float currentHealth = 100;
    private Animator amin;
    private float time;
    private AudioSource audioSource;
    public AudioClip deadSound; //am thanh khi chet
    public AudioClip hurtSound;//aam thanh khi dau
    //dinh nghia delegate: thay doi % suc khoe
    public event Action<float> OnHealthPecentChanged = delegate{};

    private void Awake()
    {
        amin = GetComponent<Animator>();//anh xa nhan vat
        audioSource = GetComponent<AudioSource>();//xanh xa am thanh
         
        
    }

    public void ModifyHeadlth(int amount)//ham thay doi suc khoe
    {
        currentHealth += amount;
        float currentHealthPecent = currentHealth / maxHealth;
        if (currentHealth > 10)
        {
            //phat ra am thanh Đau
            SoundManager.Instance.PlaySound(hurtSound);
            
        }

        OnHealthPecentChanged(currentHealthPecent); //thay doi trne man hinh

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth<0)//nhanvat chet
        {
            //su ly am thanh------
            audioSource.Pause();
            audioSource.clip = deadSound;
            audioSource.loop = false;
            audioSource.Play();
            audioSource.loop = false;
            //set trang thai chet
            amin.SetInteger("Death",1);
            GetComponent<PlayerRunning>().Dead(); //goi ham chet
            GetComponent<ScoreManager>().Dead(); //khong cong diem
            time += Time.deltaTime;
        }

        if (time>2f) //thời gian chờ để sang level
        {
            Application.LoadLevel("GameOverScene");
        }
    }
}
