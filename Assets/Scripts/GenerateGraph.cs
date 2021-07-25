using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateGraph : MonoBehaviour
{

    int nodes = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    ArrayList Generate(int nodes)
    {

        
        int i;
        ArrayList nodeList = new ArrayList();
        nodeList.Add(new Node(0));
        //Add first node

        for (i=1; i < nodes; i++)
        {
            //Create a node that is connected to ArrayList of nodes; randomize where the node is connected
        }

        return nodeList;
    }
}
