using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connectionPointUpdater : MonoBehaviour {

    public LevelSpawning Spawner;

    void Awake()
    {
        Spawner.locationY -= 2.5f;
        Spawner.distance++;
        Spawner.GenerateLevel();
    }
}
