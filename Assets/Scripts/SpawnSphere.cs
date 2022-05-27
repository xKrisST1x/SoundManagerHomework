using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
     [SerializeField] private GameObject sphere;

    public void SpawnButton()
    {
        Instantiate(sphere, this.transform);
    }
}
