using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    private static List<Task> tasks = new List<Task>();
    
    public Task()
    {
        tasks.Add(this);
    }

    public static Task getTask()
    {
        Task task = tasks[tasks.Count - 1];
        tasks.RemoveAt(tasks.Count - 1);
        return task;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (Input.GetMouseButtonDown(0) && !isActive)
        {
            isActive = true;
            initTime = Time.time;
            tasksDone++;
        }

        if(Time.time - initTime >= 15)
        {
            isActive = false;
        }

        if (!isActive)
        {
            //GetComponent<Animation>().Play("Inactive Task");
            animation.Play("Inactive Task");
        }
        else
        {
            //this.GetComponent<Animation>().Play("Active Task");
            animation.Play("Active Task");
        }
=======
>>>>>>> parent of ca8fa49... Added task Gen
        
    }
}
