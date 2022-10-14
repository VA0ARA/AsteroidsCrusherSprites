using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxScroling : MonoBehaviour
{
    #region public variable
    public Vector2 Speed;
    #endregion
    #region private variable
    private Renderer Myrender;
    #endregion
    #region public Method
    #endregion
    #region private Method 
    private void Awake()
    {
        Myrender = GetComponent<Renderer>();
    }
    private void Update()
    {
        Myrender.material.mainTextureOffset = Time.time * Speed;
    }
    #endregion

}
