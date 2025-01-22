using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController1st : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed = 5f;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position;

        
        Vector3 rotation = transform.rotation.eulerAngles;
        

        if (Input.GetKey(KeyCode.Keypad4))
        {
            rotation.y -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            rotation.y += moveSpeed * Time.deltaTime;
        }
        transform.rotation = Quaternion.Euler(rotation);
    }
}
