using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HodTopLefitManager : MonoBehaviour
{
    #region public variable
    public TextMesh txtHealthpercent;
    public TextMesh txtScore;
    #endregion
    #region private variable
    #endregion
    #region public Method
    #endregion
    #region private Method
    private void Start()
    {
        txtHealthpercent.text = Random.Range(0, 100).ToString();
        txtScore.text = Random.Range(100, 3000).ToString();
    }
    #endregion

}
