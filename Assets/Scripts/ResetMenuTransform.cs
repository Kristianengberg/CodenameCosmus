using UnityEngine;
using System.Collections;

public class ResetMenuTransform : MonoBehaviour {


    ////Creating beatbutton gameobjects in order to ref the objects in Assets/Resources
    GameObject beatButton, beatButton2, beatButton3, beatButton4, beatButton5;
    //Creating shiftpagebutton gameobjects in order to ref the objects in Assets/Resources
    GameObject beatPageButton, synthPageButton;
    ////Creating synthButton gameobjects in order to ref the objects in Assets/Resources
    GameObject synthButton, synthButton2, synthButton3, synthButton4, synthButton5;

    GameObject LeftHandPalm;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        beatPageButton = GameObject.FindWithTag("BeatPageButton");
        beatButton = GameObject.FindWithTag("BeatButton");
        beatButton2 = GameObject.FindWithTag("BeatButton2");
        beatButton3 = GameObject.FindWithTag("BeatButton3");
        beatButton4 = GameObject.FindWithTag("BeatButton4");
        beatButton5 = GameObject.FindWithTag("BeatButton5");

        synthPageButton = GameObject.FindWithTag("SynthPageButton");
        synthButton = GameObject.FindWithTag("SynthButton");
        synthButton2 = GameObject.FindWithTag("SynthButton2");
        synthButton3 = GameObject.FindWithTag("SynthButton3");
        synthButton4 = GameObject.FindWithTag("SynthButton4");
        synthButton5 = GameObject.FindWithTag("SynthButton5");



        LeftHandPalm = GameObject.FindWithTag("RightIndex");

        if (LeftHandPalm == null)
        {
            beatPageButton.transform.position = new Vector3(0, 70, 0);
            beatButton.transform.position = new Vector3(0, 70, 0);
            beatButton2.transform.position = new Vector3(0, 70, 0);
            beatButton3.transform.position = new Vector3(0, 70, 0);
            beatButton4.transform.position = new Vector3(0, 70, 0);
            beatButton5.transform.position = new Vector3(0, 70, 0);

            synthPageButton.transform.position = new Vector3(0,70,0);
            synthButton.transform.position = new Vector3(0,70,0);
            synthButton2.transform.position = new Vector3(0, 70, 0);
            synthButton3.transform.position = new Vector3(0, 70, 0);
            synthButton4.transform.position = new Vector3(0, 70, 0);
            synthButton5.transform.position = new Vector3(0, 70, 0);
        }

    }
}
