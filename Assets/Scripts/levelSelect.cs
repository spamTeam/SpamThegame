﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelSelect : MonoBehaviour {

    public Animator transitionAnim1;
    public Animator transitionAnim2;
    public string sceneName1;
    public string sceneName2;
    public KeyCode keypresslevel1;
    public KeyCode keypresslevel2;

    //Fonction pour géré l'animation et le passage à la scène suivante
    IEnumerator LoadScene1()
    {
        transitionAnim1.SetTrigger("level1trig");
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(sceneName1);
    }

    IEnumerator LoadScene2()
    {
        transitionAnim2.SetTrigger("level1trig");
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(sceneName2);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetKeyDown(keypresslevel1))
        {
            StartCoroutine(LoadScene1()); //appel de la fonction
        }
        else if (Input.GetKeyDown(keypresslevel2))
        {
            StartCoroutine(LoadScene2()); //appel de la fonction
        }

        
    }


}
