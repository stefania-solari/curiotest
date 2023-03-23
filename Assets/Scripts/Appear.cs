using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    public float sec = 14f;
    public GameObject objectToActivate;

    private void Start()
    {
        objectToActivate.SetActive(false);
        StartCoroutine(Accendi());

    }

    IEnumerator Accendi()
    {
        //Wait for 14 secs.
        yield return new WaitForSeconds(sec);

        objectToActivate.SetActive(true);
        yield return null;

    }
}
