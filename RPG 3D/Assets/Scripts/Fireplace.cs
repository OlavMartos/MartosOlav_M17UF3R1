using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanvasManager.Instance.interact.SetActive(true);
            if (InputManager.Instance.IsInteracting() > 0)
            {
                DataManager.instance.SaveGame();
            }
        }  
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasManager.Instance.interact.SetActive(false);
    }

}
