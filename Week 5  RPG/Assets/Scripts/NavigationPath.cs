using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationPath : MonoBehaviour
{
    public Transform[] Nodes;
    public int NodrCount {get { return Nodes.Length; } }

    public Vector2 GetFirstNode()
    {
        return Nodes[0].position;
    }

    public Vector2 GetNodePosition(int index)
    {
        if (index >= 0 && index < Nodes.Length)
            return Nodes[index].position;
        else
            return Vector2.zero;
    }
}
