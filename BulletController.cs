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
        //transform.position += Vector3.up * speed * Time.deltaTime;
          transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "SpaceShipe")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
    #endregion
}
