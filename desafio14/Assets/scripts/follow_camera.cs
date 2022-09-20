using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_camera : MonoBehaviour
{
   [SerializeField] Transform playerentity;

    public GameObject seguir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void LateUpdate()
    {
         transform.position = seguir.transform.position;
         transform.LookAt(playerentity);
    }
}
