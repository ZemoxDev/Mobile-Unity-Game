using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public Animator camAnim;
    public Animator camAnim1;

    public void CamShake()
    {
        int rand = Random.Range(0, 5);
        if (rand == 0)
        {
            camAnim.SetTrigger("shake");
        }
        else if (rand == 1)
        {
            camAnim.SetTrigger("shake");
        }
        else if (rand == 2)
        {
            camAnim.SetTrigger("shake");
        }
        else if (rand == 3)
        {
            camAnim.SetTrigger("shake01");
        }
        else if (rand == 4)
        {
            camAnim.SetTrigger("shake01");
        }
        else if (rand == 5)
        {
            camAnim.SetTrigger("shake01");
        }
    }
    public void ObstacleShake()
    {
        camAnim.SetTrigger("shakeObstacle");
    }
}
