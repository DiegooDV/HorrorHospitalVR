using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCollider : MonoBehaviour
{
    public GameObject[] colliders;
    public GameObject[] enemyToEnable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if(other.gameObject.tag.Equals("Player"))
        {
            foreach (var enemy in enemyToEnable)
            {
                enemy.SetActive(true);
            }
            foreach (var go in colliders)
            {
                go.SetActive(true);
            }
            Destroy(this.gameObject);
        }
    }
}
