using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLight : MonoBehaviour
{
    public GameObject lightGO;
    // Start is called before the first frame update

    public void TurnOff()
    {
        foreach (Transform child in lightGO.transform)
        {
            child.gameObject.GetComponent<Light>().intensity = 0;
        }
    }

    public void TurnOn()
    {
        foreach (Transform child in lightGO.transform)
        {
            if(child.GetSiblingIndex() == 1)
            {
                child.gameObject.GetComponent<Light>().intensity = .24f;
            }
            else
            {
                child.gameObject.GetComponent<Light>().intensity = 1.28f;

            }
        }
    }
}
