using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;

    public GameObject ProjectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            //shoots the gun
            Debug.Log("Mouse 0");
            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
        }
        
    }
}
