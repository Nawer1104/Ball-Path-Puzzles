using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{
    public bool isCorrect;

    public GameObject vfx;
    private void OnMouseDown()
    {
        GameObject vfxExplosion = Instantiate(vfx, transform.position, Quaternion.identity);
        Destroy(vfxExplosion, 1f);

        if (isCorrect)
        {
            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].GoToTarget();
        }
    }
}
