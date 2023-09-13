using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffects : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject, 5);
    }
}
