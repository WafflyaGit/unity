using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private float speed = 0.3f;
    [SerializeField] private float posLimit = 8;      
    [SerializeField] private float scrollLimit = 4;
    private float yCameraPosition;
    private float xCameraRotation;

    private void Start()
    {
        yCameraPosition = transform.position.y;
        xCameraRotation = transform.rotation.x;
    }

    private void Update()
    {
        if (Input.mousePosition.y >= Screen.height - 10 && transform.position.z <= posLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }

        if (Input.mousePosition.y <= 10 && transform.position.z >= -posLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }

        if (Input.mousePosition.x >= Screen.width - 10 && transform.position.x <= posLimit)
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }

        if (Input.mousePosition.x <= 10 && transform.position.x >= -posLimit)
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && transform.position.y <= yCameraPosition + scrollLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            transform.Rotate(new Vector3(transform.rotation.x + speed * 2, transform.rotation.y, transform.rotation.z));
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0 && transform.position.y >= yCameraPosition - scrollLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z);
            transform.Rotate(new Vector3(transform.rotation.x - speed * 2, transform.rotation.y, transform.rotation.z));
        }
    }
}
