using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {


    [SerializeField]
    GameObject cameraTarget;
    [SerializeField]
    float offsetX;
    [SerializeField]
    float offsetY;


    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = new Vector3(offsetX, offsetY, -10);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = cameraTarget.transform.position + offset;	
	}
}
