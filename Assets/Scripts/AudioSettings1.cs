using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings1 : MonoBehaviour
{
    public AudioMixer AudioMixer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVolume(float volume)
    {
        AudioMixer.SetFloat("Volume", volume);
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}