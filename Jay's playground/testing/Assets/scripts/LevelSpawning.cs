using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawning : MonoBehaviour {


    public Transform prefab;

    
    public float locationY = 0;
    public int distance = 1;
    [SerializeField]
    float locationX = 30.0f;


    // Use this for initialization
    void Start ()
    {

        Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);

        //GenerateLevel();
    }
	
    public void GenerateLevel()
    {
        Debug.Log("Hello world!");

        Instantiate(prefab, new Vector3(distance * locationX, locationY, 0), Quaternion.identity);


        /*for (int i = 1; i < 3; i++)
        {
            //locationY -= 2.5f;
            Instantiate(prefab, new Vector3(i * locationX, locationY, 0), Quaternion.identity);
        }*/
        
    }
}