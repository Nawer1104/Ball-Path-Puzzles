using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<GameObject> gameObjects;

    public Transform target;

    public void GoToTarget()
    {
        foreach(GameObject gameObject in gameObjects)
        {
            Ball ball = gameObject.GetComponent<Ball>();
            ball.canMove = true;
        }
    }

    public static List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
