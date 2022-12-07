using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPoint : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;
    public bool Interact(Interacter interacter)        
    {

        var invetory = interacter.GetComponent<Inventory>();
        if (invetory == null) return false;

        if (invetory.hasPart)
        {
            Debug.Log("Fixing the ship");
            return true;
        }
        Debug.Log("No part found");
        return false;
        
    }
}
