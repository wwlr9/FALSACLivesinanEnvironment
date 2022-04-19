using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    //This is NOT the original code file for FALSAC Lives in an Environment
    //This file is only used for conceptual guidance

    #region Data Visualization
    #endregion

    #region Interaction for assigning the external environment
    #endregion

    #region Time
    #endregion

    #region ExternalEnvironment
    #endregion

    #region Internal Value
    #endregion

    #region GlandA
    #endregion

    #region GlandB
    #endregion

    #region Game manager singleton pattern
    private static MyGameManager instance;
    public static MyGameManager FindInstance()
    {
        return instance;
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    #endregion

    #region Game objects
    #endregion

    #region Game object Materials
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        #region Default Values
        #endregion

        #region Handstimulus prerequisite
        #endregion

        #region Data Visualization
        #endregion

        #region IV threshold
        #endregion

        #region Time 
        #endregion

        #region External Stimulus
        #endregion

        #region DeltaA calculation
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region Time
        #endregion

        #region Original Environment
        #endregion

        #region Handleable stimuli
        #endregion

        #region Nonhandleable stimulus
        #endregion

        #region Data 
        #endregion

        #region VisualOfGland
        #endregion

    }

    private void IV()
    {
        
    } 
    private void stimulusPosition(float numS)
    {
 
    }
    private void TimePoints()
    {
        
    }

    private void Original()
    {

    }

    private void checkTriggerHandleable()
    {

    }
    private void HandleableStimulus()
    {
     
    }

    private void NonHandleableStimulus()
    {

    }
    private void Death()
    {

    }
    private void Electricity()
    {
       
    }
    private void Fight()
    {

    }
    private void Restart()
    {

    }
    
    private void dataVisual()
    {
       
    }
    private void notWorkingGlands()
    {
       
    }

    private void myControl()
    {
        
    }
}
