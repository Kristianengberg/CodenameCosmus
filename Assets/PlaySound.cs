using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {
    protected AudioSource u;
    protected AudioClip clip;

    // Use this for initialization
    void Start () {
        u = gameObject.AddComponent<AudioSource>();
        clip = (AudioClip)Resources.Load("Ambient");
      //  u.PlayOneShot(clip);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
