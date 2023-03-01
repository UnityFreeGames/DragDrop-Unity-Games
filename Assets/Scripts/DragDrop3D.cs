using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop3D : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public float rotationSpeed = 20;
    public bool IS_Rotate=false;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);    
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    
    }
 
    void OnMouseDrag()
    {
        if(IS_Rotate) //rotate cube
        {
             
            float XaxisRotation = Input.GetAxis("Mouse X")*rotationSpeed;
            float YaxisRotation = Input.GetAxis("Mouse Y")*rotationSpeed;
            transform.RotateAround(Vector3.down, XaxisRotation);
            transform.RotateAround(Vector3.right, YaxisRotation);
        }
        else //Drag cube
        {
           Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);  
           Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
           transform.position = curPosition;
        }
       

      
    
    }
}
