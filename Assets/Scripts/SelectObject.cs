using UnityEngine;
using System.Collections;

public class SelectObject : MonoBehaviour
{
    private RaycastHit rayHit;
    private bool hit;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
	    {
            rayHit = new RaycastHit();
            hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit);

	        if (hit)
	        {
	            Debug.Log("Hit " + rayHit.transform.gameObject.name);
	            if (rayHit.transform.gameObject.tag == "MusicBlock")
	                Debug.Log("I b work!");
            }
        }

    }
}
