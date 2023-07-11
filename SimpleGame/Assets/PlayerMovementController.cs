using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    public float speed;
    public GameObject cameraMen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Hdirection;
        float Vdirection;

        if ((Hdirection = Input.GetAxis("Horizontal")) != 0)
        {
            transform.Translate(Hdirection * Time.deltaTime * speed, 0, 0, Space.World);
        }
        
        if((Vdirection = Input.GetAxis("Vertical")) != 0)
        {
            transform.Translate(0, 0, Vdirection * Time.deltaTime * speed, Space.World);
        }
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time.deltaTime));
        cameraMen.transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time.deltaTime));
    }
}
