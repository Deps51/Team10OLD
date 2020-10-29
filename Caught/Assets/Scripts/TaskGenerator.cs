using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskGenerator : MonoBehaviour
{
    private string[] typesOfTasks = { "first", "second" }; //put all programmed tasks here
    //assisgns tasks to players and places them onmaps
    public TaskGenerator(Escapee[] escapees)
    {
        int numberOfEscapees = escapees.Length;
        if(numberOfEscapees <= 3)
        {
            //choose 5 random tasks from typesOfTasks and init them
        }
        else if(numberOfEscapees >3 && numberOfEscapees <= 6)
        {
            //choose 10 random tasks from typesOfTasks and init them
        }
        else
        {
            //there should only be a max of 9 escappes (with one grim repaer) or 8 escapees (with 2 grim repears)
            //choose 15 random tasks from typesOfTasks and init them
        }

        //SHUFFLE THE TASK LIST IN THE TASK CLASS

        for (int i = 0; i < numberOfEscapees; i++)
        {
            Task task = Task.getTask();//get random tasks from task class  
            escapees[i].addTask(task, i);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
