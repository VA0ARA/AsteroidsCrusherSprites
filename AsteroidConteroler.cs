using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidConteroler : MonoBehaviour
{
    #region public variabels
    public float Speed;
    public float RotationSpeed;
    public int  health;
    public GameObject Explotionprefabs;
    #endregion
    #region private variabels 
    private const string ANIMATION_NAME = "Health";
    private Animator anim;
    #endregion
    #region public Method
    #endregion
    #region private Method 
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        // move a long a Y axes
        transform.position += Vector3.down * Speed * Time.deltaTime;
        //roatate a long a Z axes
        transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
        anim.SetInteger(ANIMATION_NAME, health);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        health = health - collision.gameObject.GetComponent<BulletController>().Power;

        CheckHealth();
    }
    private void CheckHealth()
    {
        if (health <= 0)
        {
            Instantiate(Explotionprefabs, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    #endregion

}
