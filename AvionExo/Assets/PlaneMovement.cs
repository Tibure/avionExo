using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    protected float planeSpeed = 2000f;
    protected float planeJumpSpeed = 1f;
    private Vector3 planeDirection;
    private float planeRotation = 0.5f;
    protected Rigidbody Plane;
    public GameObject helice;
    public ParticleSystem particleEffect;

    // Start is called before the first frame update
    void Start()
    {
        Plane = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") != 0)
        {
            Plane.AddForce(transform.right * planeSpeed * Time.deltaTime);
            helice.transform.Rotate(planeSpeed,0f,0f);
            if(!particleEffect.isEmitting)
            particleEffect.Play();
        }
        else
        {
            particleEffect.Stop();
        }
        Plane.transform.Rotate(0f, Input.GetAxis("Horizontal") * planeRotation, (Input.GetAxis("Vertical") * planeRotation) *-1);

    }
}
