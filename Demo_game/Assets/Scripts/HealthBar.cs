using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthImage;
    [SerializeField] private float updateSpeed = 1f;//co the thay doi

    private void Awake()
    {
        GetComponentInParent<WomenHealth>().OnHealthPecentChanged += HandleHealthChanged;
    }

    private void HandleHealthChanged(float pecent)
    {
        StartCoroutine(ChangePercent(pecent));
    }

    private IEnumerator ChangePercent(float per)
    {
        float perChanged = healthImage.fillAmount;//dien vao man hinh tich mai 100%
        float time_lapse = 0f;
        while (time_lapse< updateSpeed)
        {
            time_lapse += Time.deltaTime;
            //tinh taon de hoen thi % tren man hinh tich mau
            healthImage.fillAmount = Mathf.Lerp(perChanged, per, time_lapse / updateSpeed);
            yield return null;
        }

        healthImage.fillAmount = per;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
