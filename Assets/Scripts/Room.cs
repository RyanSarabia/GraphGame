using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private GameObject roomLight;

    [SerializeField] private GameObject south;
    [SerializeField] private Wall northWall;
    [SerializeField] private Wall eastWall;
    [SerializeField] private Wall westWall;

    // Start is called before the first frame update
    void Start()
    {
        //roomLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 spawnAndGetPosition(string direction)
    {
        switch (direction)
        {
            case GraphGameEventNames.LOCAL_NORTH:
                northWall.openWall();
                return northWall.getNextRoomPosition();
            case GraphGameEventNames.LOCAL_EAST:
                northWall.openWall();
                return northWall.getNextRoomPosition();
            case GraphGameEventNames.LOCAL_WEST:
                northWall.openWall();
                return northWall.getNextRoomPosition();
            default: return Vector3.zero;
        }
    }

    public void lightOn()
    {
        roomLight.SetActive(true);
    }

    public void lightOff()
    {
        roomLight.SetActive(false);
    }
}
