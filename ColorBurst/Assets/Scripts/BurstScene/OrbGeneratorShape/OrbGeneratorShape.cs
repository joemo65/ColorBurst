using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OrbGeneratorShape : MonoBehaviour, IOrbGeneratorShape
{
    protected int NumberOfWaves;
    protected int NumberOfOrbs;
    //protected List<OrbGenerationWave> Waves;

    public abstract void GenerateInitial(int numberOfUniqueOrbs);
    public void GenerateOrb(ColorOrbEnum color, int startX, int startY, Vector3 directionVelocity)
    {
        
    }
}

