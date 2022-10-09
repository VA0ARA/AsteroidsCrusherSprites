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
    public GameObject explotionPrefabs;
    public int Power;
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
        //collision>> object we coltion with it .contacts[0]>>list noghte barkhord avalin barkhord chon sefre.point>> mokhtasate mahale barkhord
        Instantiate(explotionPrefabs, collision.contacts[0].point, Quaternion.identity);
        //Destroy(collision.gameObject);
        Destroy(gameObject);




    }
    #endregion
}
