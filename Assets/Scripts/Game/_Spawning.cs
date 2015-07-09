using UnityEngine;
using System.Collections;

public class _Spawning : MonoBehaviour {

    public GameObject[] colorCircles;
    public GameObject[] colorSpawners;
    public float spawnRate;
    public float spawnDelay;
	// Use this for initialization
	void Start () 
    {
        InvokeRepeating("SpawnCircle", spawnDelay, spawnRate); 


	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnCircle()
    {
        int ranCircle = Random.Range(0,3);
        int ranSide = Random.Range(0,3);
        GameObject spawnedCircle = (GameObject)Instantiate(colorCircles[ranCircle]);
        switch(ranSide)
        {
            case 0:
                spawnedCircle.transform.position = colorSpawners[0].transform.position;
                break;
            case 1:
                spawnedCircle.transform.position = colorSpawners[1].transform.position;
                break;
            case 2:
                spawnedCircle.transform.position = colorSpawners[2].transform.position;
                break;
        }
         
    }
}
