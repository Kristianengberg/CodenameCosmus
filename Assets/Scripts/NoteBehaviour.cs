using UnityEngine;
using System.Collections;

public class NoteBehaviour : MonoBehaviour
{
    private bool col = false;
    public float speed = 20;
    protected Vector3 locationPoint = new Vector3(0, 1, 0);
    protected bool waitForSound;
    protected AudioSource audi;

    protected GameObject type;
    protected GameObject soundController;
    MainSoundController sound;
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "TimeSche")
        {
            col = true;
            gameObject.transform.RotateAround(locationPoint, Vector3.up, speed*Time.deltaTime);
            sound.someMethod(Instrument());
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
        sound = soundController.GetComponent<MainSoundController>();
        sound.someMethod(Instrument());
 
    }

    protected string Instrument()
    {
        if (gameObject.name == "Ambient")
            return "Ambient";

        if (gameObject.name == "Bass")
            return "Bass";

        return null;
    }

    // Update is called once per frame
        void Update () {

        if (!col)
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            if (col)
            gameObject.transform.RotateAround(locationPoint, Vector3.up, speed * Time.deltaTime);
    }
}


