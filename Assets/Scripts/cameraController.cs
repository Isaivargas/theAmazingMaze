using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour  
{

    public GameObject player;

    private Vector3 off;

    // Start is called before the first frame update
    void Start()
    {
        off = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + off;
  }
}
