using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleOrbGeneratorShape : OrbGeneratorShape
{
    public TriangleOrbGeneratorShape(int numberOfUniqueOrbs)
    {
        NumberOfUniqueOrbs = numberOfUniqueOrbs;
    }

    public override void GenerateInitial(int numberOfUniqueOrbs)
    {        
        GenerateWave1();
        GenerateWave2();
        GenerateWave3();
    }

    private void GenerateWave1()
    {
        GenerateOrb(GetRandomColor(), new Vector3(-1, -10), new Vector3(0, 0));
        GenerateOrb(GetRandomColor(), new Vector3(0, -10), new Vector3(0, 0));
        GenerateOrb(GetRandomColor(), new Vector3(1, -10), new Vector3(0, 0));

        GenerateOrb(GetRandomColor(), new Vector3(-10, 0), new Vector3(0, 0));
        GenerateOrb(GetRandomColor(), new Vector3(10, 0), new Vector3(0, 0));

        GenerateOrb(GetRandomColor(), new Vector3(-1, 10), new Vector3(0, 0));
        GenerateOrb(GetRandomColor(), new Vector3(0, 10), new Vector3(0, 0));
        GenerateOrb(GetRandomColor(), new Vector3(1, 10), new Vector3(0, 0));
    }

    private void GenerateWave2()
    {
        GenerateOrb(GetRandomColor(), new Vector3(-10, -10), new Vector3(0, 0));
        GenerateOrb(GetRandomColor(), new Vector3(-10, -10), new Vector3(0, 0));

        GenerateOrb(GetRandomColor(), new Vector3(10, -10), new Vector3(0, 0));
        GenerateOrb(GetRandomColor(), new Vector3(10, -10), new Vector3(0, 0));
    }

    private void GenerateWave3()
    {
        GenerateOrb(GetRandomColor(), new Vector3(1, 10), new Vector3(0, 0));

        GenerateOrb(GetRandomColor(), new Vector3(-10, -10), new Vector3(0, 0));

        GenerateOrb(GetRandomColor(), new Vector3(10, -10), new Vector3(0, 0));
    }
}
