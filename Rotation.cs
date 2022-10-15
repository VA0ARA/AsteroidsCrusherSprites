using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    #region public variable
    public Vector3 Speed;
    #endregion
    #region private variable
    #endregion
    #region public Method
    #endregion
    #region private Method
    private void Update()
    {
        transform.Rotate( Speed * Time.deltaTime);
    }
    #endregion

}
