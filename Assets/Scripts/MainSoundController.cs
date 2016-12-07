using UnityEngine;
using System.Collections;
using System.Threading;
public class MainSoundController : MonoBehaviour
{

    protected string Act;
    protected AudioSource[] Audio;
    protected AudioClip clip2;
    protected AudioClip clip;

    protected float volume;

    protected string modification;

    public void someMethod(string instrument, string volumeRegulation)
    {
        this.modification = volumeRegulation;
        this.Act = instrument;
        Debug.Log(modification);
        Audio = GetComponents<AudioSource>(); // takes all the Audiosource components in the gameObject
        volumeModification(modification);
        playSound(Act);

    }

    protected void playSound(string Act)
    {
        if (Act == "Ambient")
        {
            clip = (AudioClip)Resources.Load(Act);
            Audio[0].PlayOneShot(clip,volume);
            Debug.Log("Playing with the following volume :" + volume);
        }

        if (Act == "Bass")
        {
          clip2 = (AudioClip)Resources.Load(Act);
          Audio[1].PlayOneShot(clip2, volume);
            Debug.Log("Playing with the following volume :" + volume);
        }

        
        /* u = gameObject.AddComponent<AudioSource>();
        clip = (AudioClip)Resources.Load(Act);
        u.PlayOneShot(clip);
        */
    }

    // Use this for initialization
    void Start()
    {
        // Do this method instead when a proper reference is established
        /*        foreach (GameObject gameobject in audioBlocks)
                {
                        gameObject.AddComponent<AudioSource>();
                }
          */
        gameObject.AddComponent<AudioSource>(); // Used for Ambient
        gameObject.AddComponent<AudioSource>(); // Used for Bass


    }

    protected float volumeModification(string modification)
    {



        if (modification == "Outer")
        {
            volume = 1;
            return volume;
        }

        else if (modification == "Middle")
        {
            volume = .66f;
            return volume;
        }

        else if (modification == "Inner")
        {
            volume = .33f;
            return volume;
        }
        else return volume;
    }



    protected void pitchModification()
    {
    }

    // Update is called once per frame
    void Update()
    {



        // Stop and play music ***********************

        /*  if (Input.GetKey(KeyCode.P))
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
              */

    }
}