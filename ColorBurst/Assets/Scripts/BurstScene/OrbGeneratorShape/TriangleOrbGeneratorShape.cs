using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleOrbGeneratorShape : OrbGeneratorShape
{
    public TriangleOrbGeneratorShape()
    {
    }

    public override void GenerateInitial(int numberOfUniqueOrbs)
    {
        var startX = 0.0;
        var startY = 0.0;
        //var color = (ColorOrbEnum)Enum.Parse(typeof(ColorOrbEnum),
        //              UnityEngine.Random.Range(1, numberofUniqueColoredOrbs).ToString());
        //GenerateOrb(color, startX, startY);
    }
}
