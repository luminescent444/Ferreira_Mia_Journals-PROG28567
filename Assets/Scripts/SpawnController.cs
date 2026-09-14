using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnController : MonoBehaviour
{
    Vector2 blCorner;
    Vector2 tlCorner;
    Vector2 brCorner;
    Vector2 trCorner;

    public GameObject square;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(square);
        }

        //semi transparent square

        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //figure out where the lines should be
        blCorner.x = mousePos.x - 1; blCorner.y = mousePos.y - 1;
        brCorner.x = mousePos.x + 1; brCorner.y = mousePos.y - 1;
        tlCorner.x = mousePos.x - 1; tlCorner.y = mousePos.y + 1;
        trCorner.x = mousePos.x + 1; trCorner.y = mousePos.y + 1;

        Debug.DrawLine(blCorner, brCorner, Color.grey);
        Debug.DrawLine(brCorner, trCorner, Color.grey);
        Debug.DrawLine(trCorner, tlCorner, Color.grey);
        Debug.DrawLine(tlCorner, blCorner, Color.grey);

        //scroll wheel
        Vector2 scrollWheel = Mouse.current.scroll.ReadValue();
    }

}
