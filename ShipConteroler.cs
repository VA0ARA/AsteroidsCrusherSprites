using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipConteroler : MonoBehaviour
{
    
    public float _Speed = 0.01f;
    
    void Start()
    {
        
    }
    void Update()
    {
        // you can not intiallize variable in unity directly you need to use vectore3 var for intiallize them...
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.position += new Vector3( h,v, 0f)*Time.deltaTime;
        if (transform.position.x < -8.12f)
        {
            Vector3 SaveDataOfMinNegspos= transform.position;
            SaveDataOfMinNegspos.x = -8.12f;
            transform.position = SaveDataOfMinNegspos;
        }
        if (transform.position.x > 8.17f)
        {
            Vector3 SaveDataOfMaxPosespos = transform.position;
            SaveDataOfMaxPosespos.x = 8.17f;
            transform.position = SaveDataOfMaxPosespos;
        }


        
    }
}//class
