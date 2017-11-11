using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGeneratorManagerScript : MonoBehaviour
{
    public GameObject OrbSpawner;

    public Dictionary<int, int> LevelDictionary 
    {
        get
        {
            PopulateLevelDictionary();
            
            return _levelDictionary;
        }
    }

    private Dictionary<int, int> _levelDictionary = new Dictionary<int, int>(); // contains how many unique orbs each level should have
   
    private void Start()
    {
        PopulateLevelDictionary();
    }

    private void PopulateLevelDictionary()
    {
        if (_levelDictionary == null)
            _levelDictionary = new Dictionary<int, int>();

        if(_levelDictionary.Count == 0)
        {
            _levelDictionary.Add(1, 4);
            _levelDictionary.Add(2, 5);
            _levelDictionary.Add(3, 6);
            _levelDictionary.Add(4, 7);
            _levelDictionary.Add(5, 8);
        }
    }

    public void GenerateOrbs(int level, int subLevel, int orbsRemaining, int turnsRemaining)
    {
        if(turnsRemaining == 0)
        {
            var numberOfUnqiueColoredOrbs = LevelDictionary[level];

            if(orbsRemaining == 0)
            {
                var shape = GetShapeFromLevel(level);
                shape.GenerateInitial(numberOfUnqiueColoredOrbs);
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
    private OrbGeneratorShape GetShapeFromLevel(int level)
    {
        OrbGeneratorShape orbShape = null;

        switch(level)
        {
            case 1:
                orbShape = new TriangleOrbGeneratorShape();
                break;
            default:
                orbShape = new TriangleOrbGeneratorShape();
                break;
        }


        return orbShape;
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