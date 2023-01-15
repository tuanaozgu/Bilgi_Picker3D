using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using TMPro;

public class CollectableController : MonoBehaviour
{

    


    private void  OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MiniGame")
            Destroy(gameObject);
    }
}
