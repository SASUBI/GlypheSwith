using UnityEngine;
using System.Collections;
using System;
public class Testrandom : MonoBehaviour
{
    public enum Direction : int
    {
        North,
        East,
        South,
        West
    }
    private Direction RandomDirection()
    {

        return (Direction)(UnityEngine.Random.Range(0, Enum.GetNames(typeof(Direction)).Length));


    }
    void Update()
    {
        Debug.Log(RandomDirection());
    }
}