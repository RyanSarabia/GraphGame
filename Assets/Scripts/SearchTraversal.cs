using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchTraversal : MonoBehaviour
{
    [SerializeField] GraphSpawner graphContainer;
    List<Room> searchQueue;
    int ctr = 0;
    Room firstRoom;
    List<Room> roomList;

    // Start is called before the first frame update
    void Start()
    {
        EventBroadcaster.Instance.AddObserver(GraphGameEventNames.BFS_BUTTON_CLICK, this.BFS);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(GraphGameEventNames.BFS_BUTTON_CLICK);
    }

    public void BFS()
    {
        ctr++;
        Debug.Log(ctr);
        Debug.Log(graphContainer.getFirstRoom());
        firstRoom = graphContainer.getFirstRoom();
        roomList = graphContainer.getRoomList();

        searchQueue = new List<Room>();
        searchQueue.Add(firstRoom);

        int searchQueueCtr = 0;
        Room curRoom = firstRoom;
        while(searchQueue.Count < roomList.Count)
        {
            List<Room> neighbors = curRoom.getNeighbors();
            foreach (Room neighbor in neighbors)
            {
                if (!searchQueue.Contains(neighbor))
                {
                    searchQueue.Add(neighbor);
                }
            }
            searchQueueCtr++;
            curRoom = searchQueue[searchQueueCtr];
        }

        Room lightUpRoom = searchQueue[0];

        StartCoroutine(lighterDelay(lightUpRoom));

    }

    private IEnumerator lighterDelay(Room lightUpRoom)
    {
        Debug.Log("Running Coroutine");
        lightUpRoom.lightOn();
        yield return new WaitForSeconds(1.0f);
        searchQueue.RemoveAt(0);
        
        if (searchQueue.Count > 0)
        {
            StartCoroutine(lighterDelay(searchQueue[0]));
        }
    }
}
