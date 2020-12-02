using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Caminar());
    }

    // Update is called once per frame
    void Update()
    {
        CaminarEnemigo();

    }

    public IEnumerator Caminar()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }

    private void CaminarEnemigo()
    {
        transform.Translate(-Time.deltaTime * 10, 0, 0);
    }
}
