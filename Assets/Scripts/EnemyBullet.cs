using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
   private float speed = 10;

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        
    }
}
