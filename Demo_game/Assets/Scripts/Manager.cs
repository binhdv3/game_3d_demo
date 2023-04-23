using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioClip audio;
    [SerializeField] private string sceneName;
    [SerializeField] private Text score;

    public void LoadingScene()
    {
        SoundManager.Instance.PlaySound(audio);
        Application.LoadLevel(sceneName); // goi level moi scene khác
        ScoreManager.score = 0f;// reset điểm
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + ((int)ScoreManager.score).ToString();
    }
}
