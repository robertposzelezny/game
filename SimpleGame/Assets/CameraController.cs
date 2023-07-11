using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject cube;
    public Vector3 distance;
    public float lookup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cube.transform.position + distance;
        transform.LookAt(cube.transform.position);
        transform.Rotate(-lookup,0,0);
    }
}
