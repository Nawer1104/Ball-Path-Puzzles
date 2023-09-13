using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ballPrefab;

    public int maxCap = 20;

    private float maxX = 2f;
    private float maxY = 4.5f;
    private float minX = -2f;
    private float minY = -4.5f;

    private void Start()
    {
        for(int i = 0; i < maxCap; i++)
        {
            GameObject ball = Instantiate(ballPrefab, new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity);
            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].gameObjects.Add(ball);
        }
    }
}
