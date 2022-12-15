using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt; 
    public bool Interact(Interacter interacter)
    {
        var invetory = interacter.GetComponent<Inventory>();
       


        if (invetory.hasPart)
        {
            Debug.Log("Place the part in the ship first.");
            return false;
        }
        else
        {
            Debug.Log("Opening the chest");
            
            invetory.hasPart = true;
            Destroy(gameObject);
            return true;
        }
        
    }
}
