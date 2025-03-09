using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class PathNode
{
    public GameObject tile{get; private set;}
    public List<PathConnection> connections;
    public PathNode(GameObject tile)
    {
        this.tile = tile;
        connections = new List<PathConnection>();
    }
    public void AddConection(PathConnection connection)
    {
        connections.Add(connection);
    }
}
public class PathConnection
{
    public PathNode fromNode{get; private set;}
    public PathNode toNode{get; private set;}
    public float cost{get; set;} // New tile to tile cost
    public PathConnection(PathNode from, PathNode to, float cost = 1f)
    {
        fromNode = from;
        toNode = to;
        this.cost = cost;
    }
}
public class NodeRecord
{
    public PathNode node{get; set;}
    public NodeRecord fromRecord{get; set;}
    public PathConnection pathConnection{get; set;}
    public float costSoFar {get; set;}
    public NodeRecord(PathNode node = null)
    {
        this.node = node;
        pathConnection = null;
        fromRecord = null;
        costSoFar = 0f;
    }
}
public class PathManager : MonoBehaviour
{
    public List<NodeRecord> openList;
    public List<NodeRecord> closeList;
    // the path we provide
    public List<PathConnection> path;
    public static PathManager Instance {get; private set;}
    // ------------Singleton----------------------
    void Awake()
    {
        if(Instance == null) // If gameObject/Instance doesnt exist
        {
            Instance = this;
            Initialize();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // ------------Singleton----------------------
    private void Initialize()
    {
        openList = new List<NodeRecord>();
        closeList = new List<NodeRecord>();
        path = new List<PathConnection>();
    }

    public void GetShortestPath(PathNode start, PathNode goal)
    {
        if(path.Count >0)
        {
            path.Clear();
        }
        NodeRecord currentRecord = null;
        openList.Add(new NodeRecord(start));
        while(openList.Count >0)
        {
            
        }
    }
}
