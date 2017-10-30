using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGeneratorManagerScript : MonoBehaviour
{
    public GameObject LeftOrbSpawner;
    public GameObject RightOrbSpawner;
    public GameObject TopOrbSpawner;
    public GameObject BottomOrbSpawner;


    private Dictionary<int, int> LevelDictionary = new Dictionary<int, int>(); // contains how many unique orbs each level should have

    private void Start()
    {
        PopulateLevelDictionary();
    }

    private void PopulateLevelDictionary()
    {
        if (LevelDictionary == null)
            LevelDictionary = new Dictionary<int, int>();

        if(LevelDictionary.Count == 0)
        {
            LevelDictionary.Add(1, 4);
            LevelDictionary.Add(2, 5);
            LevelDictionary.Add(3, 6);
            LevelDictionary.Add(4, 7);
            LevelDictionary.Add(5, 8);
        }
    }

    public void GenerateOrbs(int level, int subLevel, int orbsRemaining, int turnsRemaining)
    {
        if(turnsRemaining == 0)
        {
            var numberOfUnqiueColoredOrbs = LevelDictionary[level];

            if(orbsRemaining == 0)
            {
                var shape = (ShapeEnum)Enum.Parse(typeof(ShapeEnum), subLevel.ToString());
                GenerateInitial(numberOfUnqiueColoredOrbs, shape);
            }
            else
            {
                GenerateRandom(numberOfUnqiueColoredOrbs);
            }
        }
    }

    /// <summary>
    /// Generates orbs for the start of a new level.
    /// </summary>
    /// <param name="numberOfUniqueColoredOrbs">Number of unique colored orbs.</param>
    /// <param name="shape">Shape.</param>
    private void GenerateInitial(int numberOfUniqueColoredOrbs, ShapeEnum shape)
    {
        switch(shape)
        {
            case ShapeEnum.Triangle:
                GenerateTriangle(numberOfUniqueColoredOrbs);
                break;
            case ShapeEnum.Square:
                GenerateSquare(numberOfUniqueColoredOrbs);
                break;
            case ShapeEnum.Pentagon:
                GeneratePentagon(numberOfUniqueColoredOrbs);
                break;
            case ShapeEnum.Hexagon:
                GenerateHexagon(numberOfUniqueColoredOrbs);
                break;
            case ShapeEnum.Octagon:
                GenerateOctagon(numberOfUniqueColoredOrbs);
                break;
        }
    }

    private void GenerateTriangle(int numberofUniqueColoredOrbs)
    {
        var numberOfRows = 7;
        var startX = 0.0f;
        var startY = 0.0f;

        for (int i = 0; i < numberOfRows; i++)
        {
            var startOfRowX = startX;

            for (int j = 0; j < i+1; j++)
            {
                var color = (ColorOrbEnum)Enum.Parse(typeof(ColorOrbEnum),
                                  UnityEngine.Random.Range(1, numberofUniqueColoredOrbs).ToString());
                
                GenerateOrb(color, startX, startY);

                startX += 10.0f;
            }

            //reset the startX out a little bit further than before
            startX = startOfRowX - 10.0f;
            startY += 10.0f;
        }
    }

    private void GenerateSquare(int numberofUniqueColoredOrbs)
    {

    }

    private void GeneratePentagon(int numberofUniqueColoredOrbs)
    {

    }

    private void GenerateHexagon(int numberofUniqueColoredOrbs)
    {

    }

    private void GenerateOctagon(int numberofUniqueColoredOrbs)
    {
        
    }

    /// <summary>
    /// Generates additional orbs which occur if a user has not destroyed all initial orbs 
    /// successfully.
    /// </summary>
    /// <param name="numberOfUniqueColoredOrbs">Number of unique colored orbs.</param>
    private void GenerateRandom(int numberOfUniqueColoredOrbs)
    {
        
    }

    private void GenerateOrb(ColorOrbEnum color, float startX, float startY)
    {
        switch(color)
        {
            case ColorOrbEnum.Red:
                var sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = new Vector3(startX, startY);
                break;
            default:
                GameObject.CreatePrimitive(PrimitiveType.Sphere);
                break;
        }
    }
}

public enum ShapeEnum
{
    Triangle = 1,
    Square = 2,
    Pentagon = 3, 
    Hexagon = 4,
    Octagon = 5
}

public enum ColorOrbEnum
{
    Red = 1,
    Blue = 2,
    Yellow = 3,
    Green = 4,
    Orange = 5,
    Purple = 6,
    Pink = 7,
    LightBlue = 8
}