using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;

    private void OnDrawGizmosSelected()
    {
        Collider m_Collider;
        Vector3 m_Center;

        //Fetch the Collider from the GameObject
        m_Collider = GetComponent<Collider>();
        //Fetch the center of the Collider volume
        m_Center = m_Collider.bounds.center;


        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(m_Center, radius);
    }
}
