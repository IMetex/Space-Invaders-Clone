using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens : MonoBehaviour
{
    public int scoreValue;
    public GameObject explosion;
    public void Kill()
    {
        UIManager.UpdateScore(scoreValue);
        AlienMaster.allAliens.Remove(gameObject);
        Instantiate(explosion,transform.position,Quaternion.identity);
        gameObject.SetActive(false);

    }

}
