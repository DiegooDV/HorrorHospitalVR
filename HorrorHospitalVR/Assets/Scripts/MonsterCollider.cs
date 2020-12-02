using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollider : MonoBehaviour
{
    public GameObject enemy;
    public GameObject music;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            if(enemy)
            {
                enemy.AddComponent<MoveForward>();
                music.GetComponent<AudioSource>().Play();
            }
            
        }
    }
}
