using UnityEngine;
using System.Collections;

public class deleteObjects : MonoBehaviour {

    protected GameObject musicBlock;
    protected GameObject[] musicBlocks;

    // Use this for initialization
    void Start()
    {
     //     musicBlocks = GameObject.FindGameObjectsWithTag("MusicBlock");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MusicBlock")
            Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
 /*       if (Input.GetKey(KeyCode.A))
            foreach (GameObject item in musicBlocks)
                Destroy(item);
   */ }
}