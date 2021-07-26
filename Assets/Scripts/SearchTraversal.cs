using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchTraversal : MonoBehaviour
{
    [SerializeField] GraphSpawner graphContainer;
    List<Room> searchQueue;

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
        //Debug.Log(graphContainer);
        Debug.Log(graphContainer.getFirstRoom());
        firstRoom = graphContainer.getFirstRoom();
        roomList = graphContainer.getRoomList();

        searchQueue = new List<Room>();
        searchQueue.Add(firstRoom);

        int searchQueueCtr = 0;
        Room curRoom = firstRoom;
        while(searchQueue.Count < roomList.Count)
        {
            //Debug.Log("SearchCount:" + searchQueue.Count);
            //Debug.Log("SearchCtr:" + searchQueueCtr);
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

        while (searchQueue.Count > 0)
        {
            Room lightUpRoom = searchQueue[0];
            searchQueue.RemoveAt(0);
            //StartCoroutine(lighterDelay(lightUpRoom));
            lightUpRoom.lightOn();
        }
    }

    //private IEnumerator lighterDelay(Room lightUpRoom)
    //{
    //    yield return new WaitForSeconds(3.0f);
    //    Debug.Log("Running Coroutine");
    //}
}
