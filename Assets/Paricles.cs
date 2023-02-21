using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paricles : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if(other.CompareTag("Stone"))
        {
            other.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
