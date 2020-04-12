﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsAudioScript : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject.tag == "Player") 
        {
            Debug.Log("CoinsEnter");
        }
    }
}
