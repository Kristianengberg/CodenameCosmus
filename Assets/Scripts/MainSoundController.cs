﻿using UnityEngine;
using System.Collections;

public class MainSoundController : MonoBehaviour
{

    public AudioSource[] audi;

    public string Act;
    // Use this for initialization
    void Start()
    {

        if (Act == "Bass")
        {
            audi[1].Play();
        }

        if (Act == "Ambient")
        {
            audi[0].Play();
        }

    }

    public MainSoundController(string s)
    {
        this.Act = s;
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.P))
        {
            foreach (AudioSource item in audi)
                item.Play();
        }

        if (Input.GetKey(KeyCode.C))
        {
            foreach (AudioSource item in audi)
                item.Stop();
        }

        if (Input.GetKey(KeyCode.C))
            audi[1].Play();

        if (Input.GetKey(KeyCode.B))
            audi[0].Play();


    }
}