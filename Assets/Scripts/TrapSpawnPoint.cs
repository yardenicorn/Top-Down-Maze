using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawnPoint : MonoBehaviour
{
    public BaseTrap[] Traps;
    public BaseTrap TrapPoint;

    private void Start()
    {
        TrapPoint = Traps[Random.Range(0, Traps.Length)];
        TrapPoint.gameObject.SetActive(true);
    }
}
