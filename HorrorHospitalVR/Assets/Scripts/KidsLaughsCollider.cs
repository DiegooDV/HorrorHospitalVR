using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidsLaughsCollider : MonoBehaviour
{
    private int count;
    public Vector3[] spawnPoints;
    public GameObject prefab;

    private void Start()
    {
        count = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(count == 1)
        {
            if (other.gameObject.tag.Equals("Player"))
            {
                count++;
                this.gameObject.GetComponent<AudioSource>().Play();
                foreach(Vector3 spawnPoint in spawnPoints)
                {
                    var go = Instantiate(prefab, spawnPoint, Quaternion.identity);
                    go.transform.Rotate(new Vector3(-95.631f, 0, 0));

                }

            }
        }

    }
}
