using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static SoundManager Instance { get; set; }
    private AudioSource audioSource;
    void Start()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlaySound(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
    void Update()
    {
        
    }
}
