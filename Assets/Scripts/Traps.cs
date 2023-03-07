using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Traps : MonoBehaviour
{
    public LayerMask whatIDamage;
    public abstract void StepOnTrap();
}
