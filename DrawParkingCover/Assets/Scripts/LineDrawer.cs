using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class LineDrawer : MonoBehaviour
{
    float minPointSpread;
    public LayerMask carOnly;
    public LayerMask anyLayer;
    public LineRenderer drivePath;
    public List<Vector2> linePoints = new List<Vector2>();



    void Update()
    {
        Mouse mouse = Mouse.current;
        Vector2 mousePos = mouse.position.ReadValue();

        if(mouse.leftButton.isPressed)
        {
            Ray rayToMouse = Camera.main.ScreenPointToRay(mousePos);
            Debug.DrawRay(rayToMouse.origin, rayToMouse.direction * 100, Color.red, 2.5f);
            bool clickedOnValidSpot = Physics.Raycast(rayToMouse, out RaycastHit hit, 1000.0f, anyLayer);

            if(clickedOnValidSpot)
            {
                linePoints.Add(hit.point);
            }

            




        }
    }
}
