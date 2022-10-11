using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EplotionContller : MonoBehaviour
{
    #region privet variables
    [SerializeField]
    private Animator anim;
    #endregion
    #region public Variable
    
    #endregion
    #region private Method
    private void Start()
    {
        // anim = GetComponent<Animator>();
        StartCoroutine(DestoryThis());
    }
    private IEnumerator DestoryThis()
    {
        yield return new WaitForSeconds(anim.GetCurrentAnimatorClipInfo(0).Length);// delay for animation length
        Destroy(gameObject);
    }
    #endregion
    #region public Method
    #endregion


}
