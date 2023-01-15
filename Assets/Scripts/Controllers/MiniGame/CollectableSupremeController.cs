using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using TMPro;
using Managers;




public class CollectableSupremeController : MonoBehaviour
{
    #region Serialized Variables
    //[SerializeField] private TextMeshPro pointText;
    #endregion
    
    #region Private Variables
    
    [ShowInInspector] private int collected;

    #endregion

    

    private void OnTriggerEnter(Collider other)
    {
        //if (!other.CompareTag("CollectableSupreme")) return;
        
       
        if(other.CompareTag("Finish"))
        {
            transform.gameObject.tag = "Point";
        }
        //point = GameObject.FindGameObjectsWithTag("Point").Length;

        //    IncreaseCollectedCount();
    }

  
    
    //private void IncreaseCollectedCount()
    //{
    //    _collectedSupremeCount++;
    //}

    
}

