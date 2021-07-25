using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private GameObject roomLight;

    [SerializeField] private Wall upWall;
    [SerializeField] private Wall downWall;
    [SerializeField] private Wall rightWall;
    [SerializeField] private Wall leftWall;

    private Vector2 coordinate = new Vector2();

    private Room upNeighbor;
    private Room rightNeighbor;
    private Room leftNeighbor;
    private Room downNeighbor;

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
            case GraphGameEventNames.DIRECTION_UP:
                upWall.openWall();
                return upWall.getNextRoomPosition();
            case GraphGameEventNames.DIRECTION_DOWN:
                downWall.openWall();
                return downWall.getNextRoomPosition();
            case GraphGameEventNames.DIRECTION_LEFT:
                leftWall.openWall();
                return leftWall.getNextRoomPosition();
            case GraphGameEventNames.DIRECTION_RIGHT:
                rightWall.openWall();
                return rightWall.getNextRoomPosition();
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

    public void setCoordinate(Vector2 newCoor)
    {
        coordinate = newCoor;
    }
    public Vector2 getCoordinate()
    {
        return coordinate;
    }

    public void setNeighbor(Room neighbor, string localDirection)
    {
        switch (localDirection)
        {
            case GraphGameEventNames.DIRECTION_UP: upNeighbor = neighbor; break;
            case GraphGameEventNames.DIRECTION_DOWN: downNeighbor = neighbor; break;
            case GraphGameEventNames.DIRECTION_LEFT: leftNeighbor = neighbor; break;
            case GraphGameEventNames.DIRECTION_RIGHT: leftNeighbor = neighbor; break;
        }
    }
    public Room getNeighbor(string localDirection)
    {
        switch (localDirection)
        {
            case GraphGameEventNames.DIRECTION_UP: return upNeighbor; 
            case GraphGameEventNames.DIRECTION_DOWN: return downNeighbor; 
            case GraphGameEventNames.DIRECTION_LEFT: return leftNeighbor; 
            case GraphGameEventNames.DIRECTION_RIGHT: return rightNeighbor; 
            default: return null;
        }
    }

    public List<Room> getNeighbors()
    {
        List<Room> neighbors = new List<Room>();
        neighbors.Add(upNeighbor);
        neighbors.Add(downNeighbor);
        neighbors.Add(leftNeighbor);
        neighbors.Add(rightNeighbor);
        return neighbors;
    }
}
