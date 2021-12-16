using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitThenDie());
    }
    IEnumerator WaitThenDie()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
