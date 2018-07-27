﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ResetlevelTrap : MonoBehaviour {

    bool CollisionTrap = false;
    public AudioSource audioTrap;
    public AudioClip soundTrap;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
        if(CollisionTrap)
        {
            //// sound
            //if (!audioLance.isPlaying)
            //{
            //    audioLance.PlayOneShot(soundLance);
            //}
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);           
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CollisionTrap = true;
        }
    }

}
