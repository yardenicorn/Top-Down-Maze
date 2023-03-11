using UnityEngine;

public class TrapSpawnPoint : MonoBehaviour
{
    public Traps[] OptionalTraps;
    private Traps Trap;
    public Transform[] SpawnPointsArray;

    void Start()
    {
        foreach (Transform spawnPoint in SpawnPointsArray)
        {
            Trap = OptionalTraps[UnityEngine.Random.Range(0, OptionalTraps.Length)];
            Traps clonedTrap = Instantiate(Trap, spawnPoint.position, spawnPoint.rotation); //Instantiate returns the new object
            clonedTrap.gameObject.SetActive(true);
        
        }
    }
}