using UnityEngine;
using System.Collections;

public class SoundModification : MonoBehaviour
{
    public GameObject center;
    AudioSource audi;
    protected int treshold;
    protected float deAmplification;
    protected float limit;
    protected Vector3 distance;
    float soundVolume;
    float x;
    float z;

    private bool col = false;
    public float speed = 20;
    protected Vector3 locationPoint = new Vector3(0, 1, 0);
    protected bool waitForSound;
    protected AudioSource audi;


    // Use this for initialization
    void Start()
    {
        audi = gameObject.GetComponent<AudioSource>();
        audi.Play();
        treshold = 15;
        deAmplification = 10f;
        limit = 1.5f;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "TimeSche")
        {
            col = true;
            //  gameObject.transform.RotateAround(locationPoint, Vector3.up, speed * Time.deltaTime);

            x = Mathf.Sin(.2f * Mathf.PI * Time.time * 1) * 2;
            z = Mathf.Cos(.2f * Mathf.PI * Time.time * 1) * 2;
            transform.position = new Vector3(x, transform.position.y, z);
            // gameObject.transform.RotateAround( new Vector3 (0,1,0), Vector3.up, 20 * Time.deltaTime); ## Another method for circular movement

            Debug.Log("x is :" + x + " y is : " + z);
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

    // Update is called once per frame
    void Update()
    {
        pitchClarification();
        volumeClarification();
        orbit();
    }


    void orbit()
    {
        if (!col)
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

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

    void volumeClarification()
    {
        audi.volume = transform.position.y / deAmplification;
    }

    void pitchClarification()
    {
        if (soundVolume <= 0)
            soundVolume *= -1;

        if (transform.position.x <= treshold && transform.position.z <= treshold)
            soundVolume = (transform.position.x + transform.position.z) / deAmplification;

        if (-transform.position.x >= 0 && -transform.position.z >= 0)
            soundVolume = (-transform.position.x + -transform.position.z) / deAmplification;

        if (-transform.position.x >= 0 && transform.position.z >= 0)
            soundVolume = (-transform.position.x + transform.position.z) / deAmplification;

        if (transform.position.x >= 0 && -transform.position.z >= 0)
            soundVolume = (transform.position.x - transform.position.z) / deAmplification;

        audi.pitch = Mathf.Cos(soundVolume) + .5f;

        if (audi.pitch > limit)
            audi.pitch = limit;
    }
}