using UnityEngine;
using System.Collections;
using System.Threading;
public class MainSoundController : MonoBehaviour
{

//    public AudioSource[] audi;
    protected string Act;

    protected AudioSource[] u2;
    protected AudioClip clip2;
    protected AudioClip clip;
   // public GameObject soundPrefab;

    public void someMethod(string s)
    {
        this.Act = s;
        u2 = GetComponents<AudioSource>(); // takes all the Audiosource components in the gameObject
        playSound(Act);
    }

    protected void playSound(string Act)
    {
        if (Act == "Ambient")
        {
            clip = (AudioClip)Resources.Load(Act);
            u2[0].PlayOneShot(clip);
        }

        if (Act == "Bass")
        {
          clip2 = (AudioClip)Resources.Load(Act);
          u2[1].PlayOneShot(clip2);
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
        //      Instantiate(soundPrefab, transform.position, transform.rotation);
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