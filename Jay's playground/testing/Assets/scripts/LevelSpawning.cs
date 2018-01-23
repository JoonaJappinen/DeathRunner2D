using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawning : MonoBehaviour {


    public Transform prefab;

    public float pancake = 3;
    // Use this for initialization
    void Start ()
    {
        //Instantiate(prefab);	

        for (int i = 0; i < 3; i++)
        {
            Instantiate(prefab, new Vector3(i * 20.0F, pancake, 0), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
