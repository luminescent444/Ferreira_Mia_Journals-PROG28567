using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Pipeline : MonoBehaviour
{

    public float timerCount = 0;
    public List<Vector2> coordinates = new List<Vector2>();
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coordinates.Add(new Vector2(0,0));
    }

    // Update is called once per frame
    void Update()
    {
        //if mouse is pressed do a timer for 0.1 sec
        if (Mouse.current.leftButton.isPressed)
        {
            //up timer count
            timerCount = timerCount + Time.deltaTime;
            Debug.Log(timerCount);

            //if timer is up: reset timer// save current mouse position
            if (timerCount > 0.1f)
            {
                //find mouse pos
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
                //save it
                coordinates.Add(new Vector2(mousePos.x, mousePos.y));
                //reset
                timerCount = 0;
                Debug.Log("reset");
            }

        }

        //draw every line over again every frame
        for (int i = 0; i < coordinates.Count-1; i++)
        {
            Debug.DrawLine(coordinates[i], coordinates[i+1],Color.red);
        }

    }
}
