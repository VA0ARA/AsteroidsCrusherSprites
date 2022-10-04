using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    #region public variable
    public float speed;
    #endregion
    #region private variable
    #endregion
    #region public method
    #endregion
    #region private method
    private void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
    #endregion
}
