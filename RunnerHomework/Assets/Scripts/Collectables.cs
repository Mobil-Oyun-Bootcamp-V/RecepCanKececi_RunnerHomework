using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        PlayerController controller = other.GetComponentInParent<PlayerController>();
        if(controller)
        {
            controller.GoldIncrease();
            Destroy(gameObject);
        }
    }
}
