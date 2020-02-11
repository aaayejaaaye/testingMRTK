using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{       //Treat rounds like questions/procedures and answers as steps there are so skip round data
    private TaskManager taskManager;//holds procedure list "dataController"
    private TaskData currentProcedure;//Procedure class in task manager.cs for now
    private Procedure[] procedurePool;//
    public Transform stepListParent;
    private bool proceduresActive; //are there still procedures todo?
   //maybe call stepindex
    private int procedureIndex; //wihch procedure are we on

    private List<GameObject> stepsGameObjects = new List<GameObject>();
    public StepObjectPool stepPoolObject;

    public Text procedureText;
    public Text stepDisplayText;
    // Start is called before the first frame update
    void Start()
    {
        taskManager = FindObjectOfType<TaskManager>();
        currentProcedure = taskManager.GetCurrentProcedure();
        procedurePool = currentProcedure.allTask;

        ShowProcedure();
        proceduresActive = true;
    }

    private void ShowProcedure()
    {
        RemovePreviousProcedureSteps();
        Procedure procedureData = procedurePool[procedureIndex];
        procedureText.text = procedureData.procedure;
        for(int i =0; i < procedureData.stepList.Length; i++)
        {
            GameObject stepPoolObjectObject = stepPoolObject.GetObject();
            stepPoolObjectObject.transform.SetParent(stepListParent);
            stepsGameObjects.Add(stepPoolObjectObject);
            StepText steptext = stepPoolObjectObject.GetComponent<StepText>();
            steptext.Setup(procedureData.stepList[i]);
        }
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
