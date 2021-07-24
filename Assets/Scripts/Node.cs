using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node 
{
    private ArrayList adjacencyList = new ArrayList();  
    private bool isVisited;
    private int ID;
    private Node northNode = null;
    private Node southNode = null;
    private Node eastNode = null;
    private Node westNode = null;

    public Node(int ID)
    {
        this.ID = ID;
        this.isVisited = false;
    }

    public ArrayList GetAdjacencyList()
    {
        return this.adjacencyList;
    }
    
    public void AddAdjacentNode((Node, int, string) newNode)
    {
        //Node = Node object
        //int = ID of the new Node object   
        //string = direction of the adjacent Node object
        this.adjacencyList.Add(newNode);
    }

    public bool getIsVisited()
    {
        return this.isVisited;
    }

    public void setIsVisited(bool isVisited)
    {
        this.isVisited = isVisited;
    }
    public int getID()
    {
        return this.ID;
    }

    public void setNorth(Node node)
    {
        this.northNode = node;
    }

    public void setSouth(Node node)
    {
        this.southNode = node;
    }

    public void setEast(Node node)
    {
        this.eastNode = node;
    }

    public void setWest(Node node)
    {
        this.westNode = node;
    }


}
