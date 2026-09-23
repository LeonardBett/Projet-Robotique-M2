using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peche : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] objets = Physics.OverlapSphere(transform.position, 1f, layerObjets);

        foreach (Collider col in objets) {
            if(col.CompareTag("Pechable")) {
                Attraper(col.GameObject);
                break;
            }
        }
    }

    
    void Attraper(GameObject objet) {

    }
}
