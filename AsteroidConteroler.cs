using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidConteroler : MonoBehaviour
{
    #region public variabels
    public float Speed;
    public float RotationSpeed;
    public float health;
    #endregion
    #region private variabels 
    #endregion
    #region public Method
    #endregion
    #region private Method 
    private void Update()
    {
        // move a long a Y axes
        transform.position += Vector3.down * Speed * Time.deltaTime;
        //roatate a long a Z axes
        transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    #endregion

}
