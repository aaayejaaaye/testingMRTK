using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskManager : MonoBehaviour
{       //Round storing steps like questions, so treat procedure like questions
    //do we need roundata 
        // Start is called before the first frame update
    public TaskData[] allTaskProcedures;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public TaskData GetCurrentProcedure()
    {
        return allTaskProcedures[0];
    }
}
