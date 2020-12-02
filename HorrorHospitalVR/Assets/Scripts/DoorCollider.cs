using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollider : MonoBehaviour
{
    public GameObject door;
    public GameObject music;


    private IEnumerator openDoor()
    {
        yield return new WaitForSeconds(10f);
        music.GetComponent<AudioSource>().Stop();
        door.GetComponent<Animator>().SetBool("closeDoor", false);
        GetComponent<TurnOffLight>().TurnOn();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if (door)
            {
                GetComponent<TurnOffLight>().TurnOff();
                door.GetComponent<Animator>().SetBool("closeDoor", true);
                door.GetComponent<AudioSource>().Play();
                music.GetComponent<AudioSource>().Play();
                gameObject.GetComponent<BoxCollider>().enabled = false;
                StartCoroutine(openDoor());
            }

        }
    }
}
