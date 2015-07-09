using UnityEngine;
using System.Collections;
using MREngine;


public class _Clicks : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        

	
	}
    public void Clicked(int id)
    {
        switch(id)
        {
            case 0:
                GM.GetVersion();
                break;
            case 1:
            //    Debug.Log("Clicked Blue");
                if(CollisionChecker.matched)
                {
                    Destroy(CollisionChecker.circle);
                }
                break;
            case 2:
             //   Debug.Log("Clicked Green");
                if (CollisionChecker.matched)
                {
                    Destroy(CollisionChecker.circle);
                }
                break;
        }
    }
}
