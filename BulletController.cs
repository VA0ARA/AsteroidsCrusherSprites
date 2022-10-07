using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum BullteDirection
{
    Up,
    Down
}

public class BulletController : MonoBehaviour
{
    #region public variable
    public float speed;
    public BullteDirection direction;
    #endregion

    #region private variable
    private Vector3 Move = Vector3.down;
    #endregion
    #region public method
    #endregion
    #region private method
    private void Start()
    {
        if (direction == BullteDirection.Down)
        {
            Move = Vector3.down;
        }
        else
        {
            Move = Vector3.up;
        }
        
    }
    private void Update()
    {
        //transform.position += Vector3.up * speed * Time.deltaTime;
          transform.Translate(Move * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       

            Destroy(collision.gameObject);
            Destroy(gameObject);
      


    }
    #endregion
}
