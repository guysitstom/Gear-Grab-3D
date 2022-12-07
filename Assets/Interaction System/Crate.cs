using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt; 
    public bool Interact(Interacter interacter)
    {
        Debug.Log("Opening the chest");
        return true;
    }
}
