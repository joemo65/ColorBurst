using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstSceneManagerScript : MonoBehaviour
{
    public int Level = 1;
    public int SubLevel = 1;
    public int OrbsRemaining = 0;
    public GameObject OrbGeneratorManager;

    // Use this for initialization
    void Start () 
    {
        var orbGeneratorScript = OrbGeneratorManager.GetComponent<OrbGeneratorManagerScript>();

        orbGeneratorScript.GenerateOrbs(Level, SubLevel, 0, OrbsRemaining);
	}
}