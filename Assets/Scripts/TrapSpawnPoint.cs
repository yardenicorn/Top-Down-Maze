using UnityEngine;
using UnityEngine.UIElements;

public class TrapSpawnPoint : MonoBehaviour
{
    public Traps[] OptionalTraps;
    public Transform[] SpawnPointsArray;

    void Start()
    {
        foreach (Transform spawnPoint in SpawnPointsArray)
        {
            int randomIndex = UnityEngine.Random.Range(0, OptionalTraps.Length);
            Traps clonedTrap = Instantiate(OptionalTraps[randomIndex], spawnPoint.position, spawnPoint.rotation);
            clonedTrap.gameObject.SetActive(true);

            // Assign a specific trap type to the spawned trap based on the index
            Traps trap = clonedTrap.GetComponent<Traps>();
            switch (randomIndex)
            {
                case 0:
                    trap.trapType = Traps.TrapType.Trap1;
                    break;
                case 1:
                    trap.trapType = Traps.TrapType.Trap2;
                    break;
                case 2:
                    trap.trapType = Traps.TrapType.Trap3;
                    break;
                default:
                    break;
            }
        }
    }
}