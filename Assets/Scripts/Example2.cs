using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2 : MonoBehaviour
{
    // assign Cube1 to this gameobject before running
    public GameObject GO;

    void Awake() {
        Debug.Log("Example2.Awake() was called");
    }
    private bool activateGO = true;

    void Update() {
        if (activateGO == true)
        {
            if(Input.GetKeyDown("space"))
            {
                Debug.Log("space key was pressed");
                GO.SetActive(true);
                activateGO = false;
            }
        }
    }
}
