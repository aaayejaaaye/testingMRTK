using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{       //Treat rounds like questions/procedures and answers as steps there are so skip round data
    private TaskManager taskManager;//holds procedure list "dataController"
    private Procedure currentProcedure;//Procedure class in task manager.cs for now
    private Procedure[] procedurePool;//
    public Transform stepListParent;
    private bool proceduresActive; //are there still procedures todo?
   //maybe call stepindex
    private int ProcedureIndex; //wihch procedure are we on

    private List<GameObject> stepsGameObjects = new List<GameObject>();
    public StepObjectPool stepPoolObject;

    public Text stepText;
    public Text stepDisplayText;
    // Start is called before the first frame update
    void Start()
    {
        taskManager = FindObjectOfType<TaskManager>();
        currentProcedure = taskManager.GetCurrentProcedure();
        procedurePool = currentProcedure.stepList;
        
        proceduresActive = true;
    }

    private void ShowProcedure()
    {
        RemovePreviousProcedureSteps();
        step stepData = stepPool[ProcedureIndex];
        stepDisplayText.text = stepData.stepText;
/**
        for (int i = 0; i < questionData.answers.Length; i++)
        {
            GameObjects stepGameObject = stepObjectPool.GetObject();
            stepsGameObjects.Add(stepGameObject);
            stepGameObject.transform.SetParent(stepListParent);
            StepText stepsText = stepGameObject.GetComponent<stepsGameObjects>();
            stepsText.Setup(stepData.steps[i]);
        }*/
        
    }

    private void RemovePreviousProcedureSteps()
    {
        while (stepsGameObjects.Count > 0)
        {
            stepPoolObject.ReturnObject(stepsGameObjects[0]);
            stepsGameObjects.RemoveAt(0);
        }

    }
}
