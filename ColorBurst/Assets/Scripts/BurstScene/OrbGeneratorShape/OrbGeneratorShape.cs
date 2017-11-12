using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OrbGeneratorShape : MonoBehaviour, IOrbGeneratorShape
{
    protected int NumberOfUniqueOrbs;
    protected int NumberOfOrbs;

    public abstract void GenerateInitial(int numberOfUniqueOrbs);


    protected void GenerateOrb(ColorOrbEnum color, Vector3 startLocation, Vector3 targetLocation)
    {
        var orb = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        var moveSpeed = 1;
        orb.AddComponent<Rigidbody>();
        orb.transform.position = startLocation;
        orb.transform.position = targetLocation * (moveSpeed * Time.deltaTime);
    }

    protected ColorOrbEnum GetRandomColor()
    {
        return (ColorOrbEnum)Random.Range(0, NumberOfUniqueOrbs);
    }
}

