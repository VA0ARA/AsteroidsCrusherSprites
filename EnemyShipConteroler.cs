using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipConteroler : MonoBehaviour
{
    #region public variables
    public float VerticalSpeed;
    public float Hspeed;
    public GameObject bulletprefabs;
    public Vector2 TimeTofire;
    public GameObject Gun;
    public int power;
    #endregion
    #region private variable
    private int Direction;// 1>right, -1>left, 0


    #endregion
    #region public Method
    #endregion
    #region private Method 
    private void CheckSpaceShipOutOfBound()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, -7, 7);
        transform.position = pos;
    }
    private void Start()
    {
        InvokeRepeating("ChangeDirection", 1, 0.5f);
        InvokeRepeating("Fire", TimeTofire.x, TimeTofire.y);
    }
    private void Update()
    {
        Vector3 Move = Vector3.down;
        Move.x = Direction* Hspeed;
        Move.y = Direction * VerticalSpeed;
        transform.position += Move * Time.deltaTime;
        CheckSpaceShipOutOfBound();
        
    }
    private void ChangeDirection()
    {
        Direction = Random.Range(-1, 2); //-1, 1 ,0
    }
    private void Fire()
    {
        Instantiate(bulletprefabs, Gun.transform.position, Quaternion.identity);

    }
    #endregion

}
