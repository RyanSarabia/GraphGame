using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{

    public int openingDirection;
    //1 = top opening
    //2 = bottom opening
    //3 = right opening
    //4 = left opening

    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;

    private void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);
    }
    void Spawn()
    {
        if (!spawned)
        {
            if (openingDirection == 1)
            {
                //add room at the top
                rand = Random.Range(0, templates.roomAtTop.Length);
                Instantiate(templates.roomAtTop[rand]);
            }
            else if (openingDirection == 2)
            {
                //add room at the bottom
                rand = Random.Range(0, templates.roomAtBottom.Length);
                Instantiate(templates.roomAtBottom[rand]);
            }
            else if (openingDirection == 3)
            {
                //add room to the right
                rand = Random.Range(0, templates.roomAtRight.Length);
                Instantiate(templates.roomAtRight[rand]);
            }
            else if (openingDirection == 4)
            {
                //add room to the left
                rand = Random.Range(0, templates.roomAtLeft.Length);
                Instantiate(templates.roomAtLeft[rand]);
            }
            spawned = true;
        }
            
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SpawnPoint") && other.GetComponent<RoomSpawner>().spawned == true)
        {
            Destroy(gameObject);
        }
    }
}
