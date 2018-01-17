using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpAndDmg : MonoBehaviour {

    [SerializeField]
    private int hp;
    private int dmg;

    bool isAlive = true;

	// Use this for initialization
	void Start ()
    {
        hp = 3;
        dmg = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(hp <= 0)
        {
            isAlive = false;
        }

        if(isAlive == false)
        {
            Destroy(gameObject);
        }

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "killBox")
        {
            hp -= dmg;
            Debug.Log("HP: " + hp);
        }
    }
}
