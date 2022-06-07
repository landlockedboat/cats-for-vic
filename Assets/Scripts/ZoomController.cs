using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomController : MonoBehaviour
{
    [SerializeField] float _rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Vertical");
        if (horizontal > 0)
        {
            transform.Translate(transform.rotation * Vector3.forward * Time.deltaTime * _rotationSpeed * horizontal);
        }
        if (horizontal < 0)
        {
            transform.Translate(transform.rotation * -Vector3.forward * Time.deltaTime * _rotationSpeed * -horizontal);
        }
    }
}
