using UnityEngine;
using System.Collections;

public class deleteObjects : MonoBehaviour {

    protected GameObject musicBlock;
    protected GameObject[] musicBlocks;

    // Use this for initialization
    void Start()
    {
        musicBlock = GameObject.FindGameObjectWithTag("MusicBlock");
        musicBlocks = GameObject.FindGameObjectsWithTag("MusicBlock");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == musicBlock)
            Destroy(musicBlock);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            foreach (GameObject item in musicBlocks)
                Destroy(item);
    }
}