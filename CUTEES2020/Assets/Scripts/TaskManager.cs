using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskManager : MonoBehaviour
{       //Round storing steps like questions, so treat procedure like questions
    //do we need roundata 
        // Start is called before the first frame update
    public Procedure[] allProcedures;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Procedure GetCurrentProcedure()
    {
        return allProcedures[0];
    }
}
[System.Serializable]
public class Procedure
{   //the major procudre like collecting soil samples or replacing a tire on the rover
    public string procedure;
    //how many major procedure there are
    public step[] stepList;
}