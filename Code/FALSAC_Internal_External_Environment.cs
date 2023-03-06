using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Falsac_Internal_External_Environment : MonoBehaviour
{
    //This is NOT the original code file for FALSAC Lives in an Environment
    //This file is only used for conceptual guidance

    #region ExternalEnvironment
    private float energy;//energy from external environmetn is metabolized.
    private float heat;//heat is released by living systems
    private float G;//the totual handleable external stimulus
    private float S;//the totual external stimulus/stress
    private float G2;//external stimulus done by deltaA1 and deltaaA2
    private float G3;//external stimulus left for deltaA3 to handle within its limited time
    public float deltaG;//delta external stimulus
    private float deltaAudienceG;//delta external stimulus input
    #endregion

    #region Internal Value
    public float internalValue;
    private float IVu1;//1st threshold
    private float IVu2;//2nd threshold
    private float IVu3;//3rd threshold
    private float IVu4;//4th threshold
    private float IVThreat;//Threat sense threshold
    private float IVDeath;//Death threshold
    #endregion

    #region A
    public float deltaA;//A production/timeunit
    private float deltaA0;
    private float deltaA1;
    private float deltaA2;
    private float deltaA3;
    private float deltaAmax;//work at this rate for too long would cause A resistance, eventually causing glandA's failure
    private float deltaAthreat;
    #endregion

    #region B
    public float deltaB;//B production/timeunit
    private float deltaB0;
    private float deltaBmax;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //original Environment

        //HandleableStimulus

        //Nonhandleable stimulus

    }

    public void IV()
    {
        internalValue = internalValue - deltaA / 60 + deltaB / 60 + deltaG / 60;
    }

    private void OriginalState()
    {
      //Internal environment original state
        deltaA = deltaA0;
        deltaB = deltaB0;
      //External environment original state
        deltaG = 0;
    }

    private void HandleableStimulus()
    {

    }
    
    public void NonHandleableStimulus()
    {

    }

    private void notWorkingGlands()
    {

    }

    public void Death()
    {

    }

    public void RestartAfterDeath()
    {

    }

    public void Fight()
    {

    }

}
