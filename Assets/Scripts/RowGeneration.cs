using System;
using UnityEngine;

public class RowGeneration : MonoBehaviour
{
    public int numSquares;

    public float[] squares;

    Vector2 blCorner;
    Vector2 tlCorner;
    Vector2 brCorner;
    Vector2 trCorner;

    float squareY = -5;
    float squareX = -8;
    float squareCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //input field
        numSquares = 3;

        //Making loop to populate that goes as long as numsquares
        for (squareCount = 0; squareCount > numSquares-1; squareCount++)
        {
            //squares[i] = Instantiate(square2);

            blCorner.x = (squareX - 1) + squareCount*2; blCorner.y = squareY - 1;
            brCorner.x = (squareX + 1) + squareCount * 2; brCorner.y = squareY - 1;
            tlCorner.x = (squareX - 1) + squareCount * 2; tlCorner.y = squareY + 1;
            trCorner.x = (squareX + 1) + squareCount * 2; trCorner.y = squareY + 1;

            Debug.DrawLine(blCorner, brCorner, Color.white);
            Debug.DrawLine(brCorner, trCorner, Color.white);
            Debug.DrawLine(trCorner, tlCorner, Color.white);
            Debug.DrawLine(tlCorner, blCorner, Color.white);

        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
