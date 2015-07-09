using UnityEngine;
using System.Collections;

public class CircleAttributers : MonoBehaviour {

    public float fallingSpeed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        this.gameObject.transform.Translate(Vector3.down * Time.deltaTime * fallingSpeed);
	
	}
}
