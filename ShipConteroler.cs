using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipConteroler : MonoBehaviour
{
    #region public variable
    public float _Speed = 0.01f;
    public GameObject BulletPrefabs;
    public GameObject[] Guns;
    public int Health
    {
        get { return _health; }//just read it if we use set means you can chang it ....
    }
    public float fireRate=0;
    public Animator falmeAnimatore;


    #endregion
    #region private variable
    [SerializeField]
    private int _health;
    private float lastShot=0;
    private const string FLAME_ANIMATION = "speed";
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
        Vector3 Move= new Vector3(h, v, 0f) * _Speed * Time.deltaTime; ;
        transform.position += Move;
        falmeAnimatore.SetFloat(FLAME_ANIMATION, Move.sqrMagnitude);//sqrMagnitude means fisaghorays vatar 
        //using Calm for limitiation Code
        CkeckSpaceShipOutOfBound();
      if ( Input.GetKeyDown(KeyCode.Space))
        {
            // instance object that call Bullte
            Fire();

        }
    }

    private void Fire()
    {
        //Time.time means how many time spend during game... 
      
        if (Time.time>fireRate + lastShot)
        {
            for (int i = 0; i < Guns.Length; i++)
            {
                Instantiate(BulletPrefabs, Guns[i].transform.position, Quaternion.identity);
            }
            lastShot = Time.time;

        }

        
    }

    private void CkeckSpaceShipOutOfBound()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.12f, 8.17f)
            , Mathf.Clamp(transform.position.y, -4.14f, 4.23f), transform.position.z);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision happen");
        if(collision.gameObject.tag== "Bullet_Enemy")
        {
            Debug.Log("kamkon");
            _health -= collision.gameObject.GetComponent<BulletController>().Power;
            CheckHealth();
        }
        else if (collision.gameObject.tag == "Astroid")
        {
            _health -= collision.gameObject.GetComponent<AsteroidConteroler>().health;
            CheckHealth();
        }
        else if (collision.gameObject.tag == "ShipEnemy")
        {
            _health -= collision.gameObject.GetComponent<EnemyShipConteroler>().power;
            CheckHealth();
        }
    }
    private void CheckHealth()
    {
        if (_health <= 0)
        {
            // need to improve
            Destroy(gameObject);
        }
    }

    #endregion
    #region Public Method
    public void FireButtom()
    {
        Fire();

    }
    #endregion


}//class
