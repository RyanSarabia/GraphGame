using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnOrigin;
    [SerializeField] private Room roomCopy;
    [SerializeField] private List<Room> roomList;

    private Room curRoom;
    private Room nextRoom;

    // Start is called before the first frame update
    void Start()
    {
        curRoom = GameObject.Instantiate(this.roomCopy, this.transform);
        curRoom.transform.position = spawnOrigin.transform.position;
        roomList.Add(curRoom);

        for(int i=0; i<5; i++)
        {
            nextRoom = GameObject.Instantiate(this.roomCopy, this.transform);
            nextRoom.transform.position = curRoom.spawnAndGetPosition(GraphGameEventNames.LOCAL_NORTH);
            curRoom = nextRoom;
            roomList.Add(curRoom);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
