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

    GameObject[] MusicBlocks;

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
            Audio[0].clip = clip;
            Audio[0].volume = volume;
            Audio[0].Play();
        }

        if (Act == "Bass")
        {
            clip2 = (AudioClip)Resources.Load(Act);
            Audio[1].clip = clip2;
            Audio[1].volume = volume;
            Audio[1].Play();
        }

    }

    // Use this for initialization
    void Start()
    {
        establishAudioSources();
    }

    protected void establishAudioSources()
    {
        MusicBlocks = GameObject.FindGameObjectsWithTag("MusicBlock");
        // Do this method instead when a proper reference is established

        foreach (GameObject gameobject in MusicBlocks)
        {
            gameObject.AddComponent<AudioSource>();
        }
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

    public void StopPlayMusic(bool bol)
    {
        if (!bol)
        {

            foreach (AudioSource item in Audio)
            {
                item.Play();
            }
        }

        if (bol)
        {

               foreach (AudioSource item in Audio)
            {
                item.Stop();
            }

        }
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