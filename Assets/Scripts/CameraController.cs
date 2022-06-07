using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float _rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0)
        {
            transform.Rotate(new Vector3(0, -_rotationSpeed * Time.deltaTime * -horizontal, 0));
        }
        if (horizontal < 0)
        {
            transform.Rotate(new Vector3(0, _rotationSpeed * Time.deltaTime * horizontal, 0));
        }
    }
}
