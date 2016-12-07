using UnityEngine;
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;

public class HandMenu : MonoBehaviour
{

    ////Creating beatbutton gameobjects in order to ref the objects in Assets/Resources
    GameObject beatButton, beatButton2, beatButton3, beatButton4, beatButton5;
    //Creating shiftpagebutton gameobjects in order to ref the objects in Assets/Resources
    GameObject beatPageButton, synthPageButton;
    ////Creating synthButton gameobjects in order to ref the objects in Assets/Resources
    GameObject synthButton, synthButton2, synthButton3, synthButton4, synthButton5;

    GameObject RightIndex;


    //GameObject synthButton;
    //GameObject beat;
    //GameObject synth;


    float xPos;
    float yPos;
    float zPos;

    // Use this for initialization
    void Start()
    {

        beatPageButton = Instantiate(Resources.Load("BeatPageButton"), new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
        synthPageButton = Instantiate(Resources.Load("SynthPagebutton"), new Vector3(xPos, yPos, zPos), Quaternion.Euler(90f, 0f, 0f)) as GameObject;

        beatButton = Instantiate(Resources.Load("BeatButton"), new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
        beatButton2 = Instantiate(Resources.Load("BeatButton2"), new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
        beatButton3 = Instantiate(Resources.Load("BeatButton3"), new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
        beatButton4 = Instantiate(Resources.Load("BeatButton4"), new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
        beatButton5 = Instantiate(Resources.Load("BeatButton5"), new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;

        synthButton = Instantiate(Resources.Load("SynthButton"), new Vector3(xPos, yPos, zPos), Quaternion.Euler(90f, 0f, 0f)) as GameObject;
        synthButton2 = Instantiate(Resources.Load("SynthButton2"), new Vector3(xPos, yPos, zPos), Quaternion.Euler(90f, 0f, 0f)) as GameObject;
        synthButton3 = Instantiate(Resources.Load("SynthButton3"), new Vector3(xPos, yPos, zPos), Quaternion.Euler(90f, 0f, 0f)) as GameObject;
        synthButton4 = Instantiate(Resources.Load("SynthButton4"), new Vector3(xPos, yPos, zPos), Quaternion.Euler(90f, 0f, 0f)) as GameObject;
        synthButton5 = Instantiate(Resources.Load("SynthButton5"), new Vector3(xPos, yPos, zPos), Quaternion.Euler(90f, 0f, 0f)) as GameObject;

        RightIndex = GameObject.FindGameObjectWithTag("RightIndex");
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.Find("CapsuleHand_L") != null)
        {
            xPos = GameObject.FindWithTag("LeftHandPalm").transform.position.x;
            yPos = GameObject.FindWithTag("LeftHandPalm").transform.position.y;
            zPos = GameObject.FindWithTag("LeftHandPalm").transform.position.z;
        }
        else
        {
            xPos = 0;
            yPos = 70;
            zPos = 0;
        }
        


    }

    float beatPageButtonX = 17f, beatPageButtonY = -0.20f, beatPageButtonZ = 0.1f;
    float synthPageButtonX = 14f, synthPageButtonY = -5f, synthPageButtonZ = 0.1f;

    float beatButtonX = 10f, beatButtonY = -3.5f, beatButtonZ = 0.1f;
    float beatButton2X = 12f, beatButton2Y = -0f, beatButton2Z = 0.1f;
    float beatButton3X = 14f, beatButton3Y = 3.5f, beatButton3Z = 0.1f;
    float beatButton4X = 15f, beatButton4Y = 7.5f, beatButton4Z = 0.1f;
    float beatButton5X = 14f, beatButton5Y = 11f, beatButton5Z = 0.1f;

    float synthButtonX = 10f, synthButtonY = -3.5f, synthButtonZ = 0.1f;
    float synthButton2X = 12f, synthButton2Y = -0f, synthButton2Z = 0.1f;
    float synthButton3X = 14f, synthButton3Y = 3.5f, synthButton3Z = 0.1f;
    float synthButton4X = 15f, synthButton4Y = 7.5f, synthButton4Z = 0.1f;
    float synthButton5X = 14f, synthButton5Y = 11f, synthButton5Z = 0.1f;

    int colorSwitch = 0;

    void FixedUpdate()
    {

        beatPageButton.GetComponent<Rigidbody>().position = new Vector3(xPos + beatPageButtonX, yPos + beatPageButtonY, zPos + beatPageButtonZ);
        synthPageButton.GetComponent<Rigidbody>().position = new Vector3(xPos + synthPageButtonX, yPos + synthPageButtonY, zPos + synthPageButtonZ);

        beatButton.GetComponent<Rigidbody>().position = new Vector3(xPos + beatButtonX, yPos + beatButtonY, zPos + beatButtonZ);
        beatButton2.GetComponent<Rigidbody>().position = new Vector3(xPos + beatButton2X, yPos + beatButton2Y, zPos + beatButton2Z);
        beatButton3.GetComponent<Rigidbody>().position = new Vector3(xPos + beatButton3X, yPos + beatButton3Y, zPos + beatButton3Z);
        beatButton4.GetComponent<Rigidbody>().position = new Vector3(xPos + beatButton4X, yPos + beatButton4Y, zPos + beatButton4Z);
        beatButton5.GetComponent<Rigidbody>().position = new Vector3(xPos + beatButton5X, yPos + beatButton5Y, zPos + beatButton5Z);

        synthButton.GetComponent<Rigidbody>().position = new Vector3(xPos + synthButtonX, yPos + synthButtonY, zPos + synthButtonZ);
        synthButton2.GetComponent<Rigidbody>().position = new Vector3(xPos + synthButton2X, yPos + synthButton2Y, zPos + synthButton2Z);
        synthButton3.GetComponent<Rigidbody>().position = new Vector3(xPos + synthButton3X, yPos + synthButton3Y, zPos + synthButton3Z);
        synthButton4.GetComponent<Rigidbody>().position = new Vector3(xPos + synthButton4X, yPos + synthButton4Y, zPos + synthButton4Z);
        synthButton5.GetComponent<Rigidbody>().position = new Vector3(xPos + synthButton5X, yPos + synthButton5Y, zPos + synthButton5Z);



        if (GameObject.FindWithTag("LeftArm").transform.rotation.z <= 0.69)
        {
            

            beatPageButton.GetComponent<Renderer>().material.color = Color.clear;
            synthPageButton.GetComponent<Renderer>().material.color = Color.clear;



            beatButton.GetComponent<Renderer>().material.color = Color.clear;
            beatButton2.GetComponent<Renderer>().material.color = Color.clear;
            beatButton3.GetComponent<Renderer>().material.color = Color.clear;
            beatButton4.GetComponent<Renderer>().material.color = Color.clear;
            beatButton5.GetComponent<Renderer>().material.color = Color.clear;

            synthButton.GetComponent<Renderer>().material.color = Color.clear;
            synthButton2.GetComponent<Renderer>().material.color = Color.clear;
            synthButton3.GetComponent<Renderer>().material.color = Color.clear;
            synthButton4.GetComponent<Renderer>().material.color = Color.clear;
            synthButton5.GetComponent<Renderer>().material.color = Color.clear;


        }


        if (GameObject.FindWithTag("LeftArm").transform.rotation.z >= 0.70 )
        {

           // print("LeftArm Rotated");

            beatPageButton.GetComponent<Renderer>().material.color = Color.gray;
            synthPageButton.GetComponent<Renderer>().material.color = Color.gray;

            switch (colorSwitch)
            {

                case 1:
                    {

                        beatPageButton.GetComponent<Renderer>().material.color = Color.white;
                        synthPageButton.GetComponent<Renderer>().material.color = Color.gray;


                        beatButton.GetComponent<Renderer>().material.color = Color.red;
                        beatButton2.GetComponent<Renderer>().material.color = Color.magenta;
                        beatButton3.GetComponent<Renderer>().material.color = Color.blue;
                        beatButton4.GetComponent<Renderer>().material.color = Color.green;
                        beatButton5.GetComponent<Renderer>().material.color = Color.yellow;
                        
                        synthButton.GetComponent<Renderer>().material.color = Color.clear;
                        synthButton2.GetComponent<Renderer>().material.color = Color.clear;
                        synthButton3.GetComponent<Renderer>().material.color = Color.clear;
                        synthButton4.GetComponent<Renderer>().material.color = Color.clear;
                        synthButton5.GetComponent<Renderer>().material.color = Color.clear;

                        break;
                    }
                case 2:
                    {
                        beatPageButton.GetComponent<Renderer>().material.color = Color.gray;
                        synthPageButton.GetComponent<Renderer>().material.color = Color.white;

                        synthButton.GetComponent<Renderer>().material.color = Color.red;
                        synthButton2.GetComponent<Renderer>().material.color = Color.magenta;
                        synthButton3.GetComponent<Renderer>().material.color = Color.blue;
                        synthButton4.GetComponent<Renderer>().material.color = Color.green;
                        synthButton5.GetComponent<Renderer>().material.color = Color.yellow;

                        beatButton.GetComponent<Renderer>().material.color = Color.clear;
                        beatButton2.GetComponent<Renderer>().material.color = Color.clear;
                        beatButton3.GetComponent<Renderer>().material.color = Color.clear;
                        beatButton4.GetComponent<Renderer>().material.color = Color.clear;
                        beatButton5.GetComponent<Renderer>().material.color = Color.clear;

                        break;
                    }
                default:
                    {

                        beatButton.GetComponent<Renderer>().material.color = Color.clear;
                        beatButton2.GetComponent<Renderer>().material.color = Color.clear;
                        beatButton3.GetComponent<Renderer>().material.color = Color.clear;
                        beatButton4.GetComponent<Renderer>().material.color = Color.clear;
                        beatButton5.GetComponent<Renderer>().material.color = Color.clear;

                        synthButton.GetComponent<Renderer>().material.color = Color.clear;
                        synthButton2.GetComponent<Renderer>().material.color = Color.clear;
                        synthButton3.GetComponent<Renderer>().material.color = Color.clear;
                        synthButton4.GetComponent<Renderer>().material.color = Color.clear;
                        synthButton5.GetComponent<Renderer>().material.color = Color.clear;




                        break;
                    }


            }//End Colorswitch

        }// End If-Arm rotated
       
    }//End Fixed Update






    GameObject beat, beat2, beat3, beat4, beat5;
    GameObject synth, synth2, synth3, synth4, synth5;

    bool buttonNotPressed = true;
    int caseSwitch = 1;

    void OnTriggerEnter(Collider other)
    {


        if (GameObject.FindWithTag("LeftArm").transform.rotation.z >= 0.70)
        {
            
            if (other.tag == "BeatPageButton" && gameObject.tag == "RightIndex")
            {


                /* GameObject.Find("SynthButton").GetComponent<Renderer>().material.color = Color.clear;
                 GameObject.Find("SynthButton2").GetComponent<Renderer>().material.color = Color.clear;
                 GameObject.Find("SynthButton3").GetComponent<Renderer>().material.color = Color.clear;
                 GameObject.Find("SynthButton4").GetComponent<Renderer>().material.color = Color.clear;
                 GameObject.Find("SynthButton5").GetComponent<Renderer>().material.color = Color.clear;*/

                caseSwitch = 1;
                colorSwitch = 1;

            }

            if (other.tag == "SynthPageButton" && gameObject.tag == "RightIndex")
            {
                /* GameObject.Find("BeatButton").GetComponent<Renderer>().material.color = Color.clear;
                 GameObject.Find("BeatButton2").GetComponent<Renderer>().material.color = Color.clear;
                 GameObject.Find("BeatButton3").GetComponent<Renderer>().material.color = Color.clear;
                 GameObject.Find("BeatButton4").GetComponent<Renderer>().material.color = Color.clear;
                 GameObject.Find("BeatButton5").GetComponent<Renderer>().material.color = Color.clear;*/

                caseSwitch = 2;
                colorSwitch = 2;
            }


            switch (caseSwitch)
            {
                case 1:
                    {

                        if (other.tag == "BeatButton" && gameObject.tag == "RightIndex" && buttonNotPressed == true)
                        {
                            beat = Instantiate(Resources.Load("Beat"), new Vector3(25f, 5f, -12f), Quaternion.Euler(0, 100, 0)) as GameObject;
                           // print("Beat Instantiatet");
                            buttonNotPressed = false;
                        }

                        if (other.tag == "BeatButton2" && gameObject.tag == "RightIndex" && buttonNotPressed == true)
                        {
                            beat2 = Instantiate(Resources.Load("Beat2"), new Vector3(25f, 5f, -12f), Quaternion.Euler(0, 100, 0)) as GameObject;
                           // print("Beat2 Instantiatet");
                            buttonNotPressed = false;
                        }

                        if (other.tag == "BeatButton3" && gameObject.tag == "RightIndex" && buttonNotPressed == true)
                        {
                            beat3 = Instantiate(Resources.Load("Beat3"), new Vector3(25f, 5f, -12f), Quaternion.Euler(0, 100, 0)) as GameObject;
                           // print("Beat3 Instantiatet");
                            buttonNotPressed = false;
                        }

                        if (other.tag == "BeatButton4" && gameObject.tag == "RightIndex" && buttonNotPressed == true)
                        {
                            beat4 = Instantiate(Resources.Load("Beat4"), new Vector3(25f, 5f, -12f), Quaternion.Euler(0, 100, 0)) as GameObject;
                          //  print("Beat4 Instantiatet");
                            buttonNotPressed = false;
                        }

                        if (other.tag == "BeatButton5" && gameObject.tag == "RightIndex" && buttonNotPressed == true)
                        {
                            beat5 = Instantiate(Resources.Load("Beat5"), new Vector3(25f, 5f, -12f), Quaternion.Euler(0, 100, 0)) as GameObject;
                          //  print("Beat5 Instantiatet");
                            buttonNotPressed = false;
                        }

                        break;
                    }

                case 2:
                    {

                        if (other.tag == "SynthButton" && gameObject.tag == "RightIndex" && buttonNotPressed == true)
                        {
                            synth = Instantiate(Resources.Load("Synth"), new Vector3(25f, 5f, -12f), Quaternion.Euler(0, 100, 0)) as GameObject;
                          //  print("synth Instantiatet");
                            buttonNotPressed = false;
                        }

                        if (other.tag == "SynthButton2" && gameObject.tag == "RightIndex" && buttonNotPressed == true)
                        {
                            synth2 = Instantiate(Resources.Load("Synth2"), new Vector3(25f, 5f, -12f), Quaternion.Euler(0, 100, 0)) as GameObject;
                          //  print("synth2 Instantiatet");
                            buttonNotPressed = false;
                        }

                        if (other.tag == "SynthButton3" && gameObject.tag == "RightIndex" && buttonNotPressed == true)
                        {
                            synth3 = Instantiate(Resources.Load("Synth3"), new Vector3(25f, 5f, -12f), Quaternion.Euler(0, 100, 0)) as GameObject;
                         //   print("synth3 Instantiatet");
                            buttonNotPressed = false;
                        }

                        if (other.tag == "SynthButton4" && gameObject.tag == "RightIndex" && buttonNotPressed == true)
                        {
                            synth4 = Instantiate(Resources.Load("Synth4"), new Vector3(25f, 5f, -12f), Quaternion.Euler(0, 100, 0)) as GameObject;
                          //  print("synth4 Instantiatet");
                            buttonNotPressed = false;
                        }

                        if (other.tag == "SynthButton5" && gameObject.tag == "RightIndex" && buttonNotPressed == true)
                        {
                            synth5 = Instantiate(Resources.Load("Synth5"), new Vector3(25f, 5f, -12f), Quaternion.Euler(0, 100, 0)) as GameObject;
                          //  print("synth5 Instantiatet");
                            buttonNotPressed = false;
                        }

                        break;
                    }

                default:
                    {
                        //Console.WriteLine("Default case");
                        break;
                    }

            }//End switch

        }//End If leftArmRotated      

      }//End OnTriggerEnter



    void OnTriggerExit(Collider other)
    {
        buttonNotPressed = true;

    }



    /*void OnGUI()
    {


		if (GUI.Button(new Rect(GameObject.Find("Beat").transform.position.x, GameObject.Find("Beat").transform.position.y, 100,100), "Beat"))
        {
            print("BottonHasBeenPressed");

            beat = Instantiate(Resources.Load("Beat"), new Vector3(0, 0, 2), Quaternion.Euler(0,100,0)) as GameObject;
        }


        if (GUI.Button(new Rect(200, 100, 100, 100), "Synth"))
        {
            print("BottonHasBeenPressed");

            synth = Instantiate(Resources.Load("Synth"), new Vector3(1, 0, 2), Quaternion.Euler(0,100,0)) as GameObject;
        }

    }*/
}
