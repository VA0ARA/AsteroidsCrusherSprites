using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HubbulletManager : MonoBehaviour
{
    #region public variable
    #endregion
    #region private variable
    private Text txtBullet;
    #endregion
    #region private Method
    private void Start()
    {
        txtBullet = GameObject.FindGameObjectWithTag("txtBullet").GetComponent<Text>();
        txtBullet.text = Random.Range(20, 50)+"";
    }
    #endregion
    #region public Method
    #endregion

}
