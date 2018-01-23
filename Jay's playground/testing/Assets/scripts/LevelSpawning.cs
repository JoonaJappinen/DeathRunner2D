using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawning : MonoBehaviour {


    public Transform prefab;
    // Use this for initialization
    void Start ()
    {
        Instantiate(prefab);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
