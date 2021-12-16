using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject breakVersion;
    public AudioSource ad;
    public float bForce = 1f;
    protected Rigidbody rb;
    private int active = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(rb.velocity.magnitude > bForce && active == 0)
        {
            active++;
            Instantiate(breakVersion, transform.position, transform.rotation);
            rb.AddExplosionForce(10f, Vector3.zero, 0f);
            Destroy(gameObject);
            ad.Play();
        }
    }
}
