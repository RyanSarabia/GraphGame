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

    private Room northNeighbor;
    private Room westNeighbor;
    private Room eastNeighbor;

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

    public void setNeighbor(Room neighbor, string localDirection)
    {
        switch (localDirection)
        {
            case GraphGameEventNames.LOCAL_NORTH: northNeighbor = neighbor; break;
            case GraphGameEventNames.LOCAL_EAST: eastNeighbor = neighbor; break;
            case GraphGameEventNames.LOCAL_WEST: westNeighbor = neighbor; break;
        }
    }
    public Room getNeighbor(string localDirection)
    {
        switch (localDirection)
        {
            case GraphGameEventNames.LOCAL_NORTH: return northNeighbor;
            case GraphGameEventNames.LOCAL_EAST: return eastNeighbor;
            case GraphGameEventNames.LOCAL_WEST: return westNeighbor;
            default: return null;
        }
    }

    public List<Room> getNeighbors()
    {
        List<Room> neighbors = new List<Room>();
        neighbors.Add(northNeighbor);
        neighbors.Add(eastNeighbor);
        neighbors.Add(westNeighbor);
        return neighbors;
    }
}
