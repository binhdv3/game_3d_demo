using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    [SerializeField] private Text levelText;

    //khai bao cac bien
    public static float score = 0f;
    private int maxlevel = 10;
    private int level = 1;
    private int scoreToNextLevel = 10; //khoang cach giua cac level
    private bool isDead = false;//trang thai chet

    internal void Dead()
    {
        isDead = true;
    }
    //dinh nghia ham tang diem
    public void TangDiem(float s)
    {
        score += s;
    }
    
    //dinh nghiax ham tang level
    public void TangLevel()
    {
        if (level == maxlevel) //neu level la lon nhat
        {
            return;
        }

        scoreToNextLevel = scoreToNextLevel * 2;
        ++level;
        //thay doi toc do tam chieu den player running
        GetComponent<PlayerRunning>().SetSpeed(level);
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)//neu khong phai trang thai chet
        {
            if (score > scoreToNextLevel) //neu diem lon hon 10 thi tang level
            {
                TangLevel();
            }
            //cap nhat diem vao text
            scoreText.text = "Score: " + ((int)score).ToString();
            levelText.text = "Level:  " + level;
        }
    }
}