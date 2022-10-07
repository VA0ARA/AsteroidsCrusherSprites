using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipConteroler : MonoBehaviour
{
    #region public variable
    public float _Speed = 0.01f;
    public GameObject BulletPrefabs;
    public GameObject Gun;

    #endregion
    #region private variable
    #endregion


    #region private Method
    private void Start()
    {

    }
    private void Update()
    {
        // you can not intiallize variable in unity directly you need to use vectore3 var for intiallize them...
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.position += new Vector3(h, v, 0f) * _Speed * Time.deltaTime;
        //using Calm for limitiation Code
        CkeckSpaceShipOutOfBound();
      if ( Input.GetKeyDown(KeyCode.Space)){
            // instance object that call Bullte
            Instantiate(BulletPrefabs,Gun.transform.position,Quaternion.identity);

        }
    }

    private void CkeckSpaceShipOutOfBound()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.12f, 8.17f)
            , Mathf.Clamp(transform.position.y, -4.14f, 4.23f), transform.position.z);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collision happen");
    }

    #endregion


}//class
