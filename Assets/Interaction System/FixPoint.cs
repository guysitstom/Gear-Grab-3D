using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FixPoint : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public int partsFixed = 0;
    public string InteractionPrompt => _prompt;
    public bool Interact(Interacter interacter)        
    {

        var invetory = interacter.GetComponent<Inventory>();
        if (invetory == null) return false;

        if (invetory.hasPart)
        {
            Debug.Log("Fixing the ship");
            invetory.hasPart = false;
            
            partsFixed++;
         
            if (partsFixed > 3)
            {
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            return true;
        }
        Debug.Log("No part found");
        return false;
        
    }
}
 