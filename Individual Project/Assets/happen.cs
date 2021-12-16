using UnityEngine;
using System.Collections;

// The velocity along the y axis is 10 units per second.  If the GameObject starts at (0,0,0) then
// it will reach (0,100,0) units after 10 seconds.

public class happen : MonoBehaviour
{
    public GameObject genBody;

    void Start()
    {
        StartCoroutine(WaitThenDie(3));
    }
    IEnumerator WaitThenDie(int lifetime)
    {
        yield return new WaitForSeconds(lifetime);
        int numberOfClassObjects = GameObject.FindObjectsOfType(typeof(GameObject)).Length;
        Instantiate(genBody, transform.position, transform.rotation);
        if (numberOfClassObjects < 34)
            StartCoroutine(WaitThenDie(3));
        else
            StartCoroutine(WaitThenDie(10));
    }

    void Update()
    {
        
    }

}