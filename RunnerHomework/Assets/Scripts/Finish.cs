using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        PlayerController controller = other.GetComponentInParent<PlayerController>();
        if(controller)
        {
            controller.FinishMove();
            UIManager.manager.ShowNextLevelPanel();
            GameManager.manager.ToFinishGame();
        }    
    }
}
