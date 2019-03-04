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
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        if(Nodes != null)
        {
            for(int i = 0;i < Nodes.Length;i++)
            {
                if(i +1 < Nodes.Length)
                {
                    Gizmos.DrawLine(Nodes[i].position, Nodes[i + 1].position);
                }
                else
                {
                    Gizmos.DrawLine(Nodes[i].position, Nodes[0].position);
                }
            }
        }
    }

}
