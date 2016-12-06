using UnityEngine;
using System.Collections;

public class NoteBehaviour : MonoBehaviour
{
    private bool col = false;
    public float speed = 20;
    protected Vector3 locationPoint = new Vector3(0, 1, 0);
    protected bool waitForSound;
    protected AudioSource audi;

    protected GameObject soundController;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "TimeSche")
        {
            col = true;
            gameObject.transform.RotateAround(locationPoint, Vector3.up, speed*Time.deltaTime);
            
        }
    }



   void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "TimeSche")
        {
            col = false;
        }
    }

    
    IEnumerator waitForNextSoundTreshHold()
    {
        yield return new WaitForSeconds(3);
    }

    // Use this for initialization
    void Start ()
    {
        audi = gameObject.GetComponent<AudioSource>();
        soundController = GameObject.Find("SoundController");

        MainSoundController sound = soundController.GetComponent<MainSoundController>();
        sound.Act = "Ambient";

    }


    // Update is called once per frame
        void Update () {
        //hello
            if (!col)
            {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }

            if (col)
            {
            gameObject.transform.RotateAround(locationPoint, Vector3.up, speed * Time.deltaTime);
        
        
            if (!audi.isPlaying)
            {
                // StartCoroutine(waitForNextSoundTreshHold());
                audi.Play(2 / 44100);
             }

        }
    }
}


