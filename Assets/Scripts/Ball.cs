using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool canMove;

    public float speed;

    public GameObject vfx;

    private void Update()
    {
        if (canMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].target.position, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hgehe");
        if (collision != null) {
            if (collision.tag == "Target")
            {
                GameObject vfxExplosion = Instantiate(vfx, transform.position, Quaternion.identity);
                Destroy(vfxExplosion, 1f);

                GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].gameObjects.Remove(gameObject);
                GameManager.Instance.CheckLevelUp();
                Destroy(gameObject);
            }
        }
    }
}
