using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject targetObject = null;

    void Start()
    {
        targetObject = GameObject.FindGameObjectWithTag("Player") as GameObject;
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetObject.transform);
        transform.eulerAngles = new Vector3(-90, transform.eulerAngles.y, 0);

    }

}
