using UnityEngine;
using System.Collections;

public class CollisionChecker : MonoBehaviour {

    public static bool matched;
    public static GameObject circle;
    public static GameObject notMatchingcircle;
	// Use this for initialization
	void Start () {
	
        matched = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag + "Clicker" == this.gameObject.tag)
        {
            circle = other.gameObject;
            matched = true;
        }
        else
        {
            notMatchingcircle = other.gameObject;
            matched = false;
        }


    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (!matched)
            Destroy(notMatchingcircle.gameObject);
            
    }
}
