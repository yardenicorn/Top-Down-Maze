using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawnPoint : MonoBehaviour
{
    public BaseTrap[] OptionalTraps;
    private BaseTrap Trap;
    public Transform[] SpawnPointsArray;


    void Start()
    {
        foreach (Transform spawnPoint in SpawnPointsArray)
        {
            Trap = OptionalTraps[UnityEngine.Random.Range(0, OptionalTraps.Length)];
            BaseTrap clonedTrap = Instantiate(Trap, spawnPoint.position, spawnPoint.rotation); //Instantiate returns the new object
            clonedTrap.gameObject.SetActive(true);

        }
        
    }

}
