using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    #region public variable
    public GameObject[] AsteroidsPrefabs;
    public Vector2 TimeTopawn;
    public Vector2 xAxiesLimiteToSpawn;
    #endregion
    #region private variable
    #endregion
    #region public Method
    #endregion
    #region private Method 
    private void Start()
    {
        //first approch
        //Invoke("Spawn", Random.Range(TimeTopawn.x,TimeTopawn.y));
        //second approch
        StartCoroutine(Spawn());
        // we have to use this methos(StartCoroutine) for call the corentin method


    }
    //first approch
    /*    private void Spawn()
        {
            Instantiate(AsteroidPrefabs, transform.position, Quaternion.identity);
            Invoke("Spawn", Random.Range(2, 6));
        }*/
    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Random.Range(TimeTopawn.x, TimeTopawn.y));
        Vector3 pos = transform.position;
        pos.x = Random.Range(xAxiesLimiteToSpawn.x, xAxiesLimiteToSpawn.y);
        int rnd = Random.Range(0, AsteroidsPrefabs.Length);
        Instantiate(AsteroidsPrefabs[rnd], pos, Quaternion.identity);
        StartCoroutine(Spawn());
    }
    #endregion

}
