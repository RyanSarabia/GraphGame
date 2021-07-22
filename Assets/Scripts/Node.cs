using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node 
{
    private (Node, int, string) adjacentList;
    private bool isVisited;

    public Node((Node, int, string) adjacentList)
    {
        if (adjacentList.Item1 != null)
            this.adjacentList = adjacentList;

        this.isVisited = false;
    }

    public (Node, int, string) GetAdjacencyList()
    {
        return this.adjacentList;
    }

    public bool getIsVisited()
    {
        return this.isVisited;
    }

    public void setIsVisited(bool isVisited)
    {
        this.isVisited = isVisited;
    }

}
