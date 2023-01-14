using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    private AudioSource _audio;
    public AudioClip clip1,clip2,clip3;
    private bool isclip1played = false;
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isclip1played)
        {
           
            _audio.PlayOneShot(clip1);
            isclip1played = true;
        }
        
    }
}
