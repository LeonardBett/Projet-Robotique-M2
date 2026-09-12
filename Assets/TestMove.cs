using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    // Les differents partie du bras qu'on bougera automatiquement
    public ArticulationBody[] articulationBodies;
    
    // Parametre pour changer la vitesse/cible de l'automatisation
    public float moveSpeed = 10.0f;
    public float targetAngle = 90.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (ArticulationBody articulationBody in articulationBodies)
        {
            BougerPartie(articulationBody);
        }
    }

    void BougerPartie(ArticulationBody articulationBody)
    {
        // On recupere une copie de la config du moteur sur l'axe X
        ArticulationDrive drive = articulationBody.xDrive;
        
        // On la modifie pour avancer vers l'angle cible
        drive.target = Mathf.MoveTowards(drive.target, targetAngle, moveSpeed*Time.fixedDeltaTime);
   
        // On l'assigne au moteur
        articulationBody.xDrive = drive;
    }
}
