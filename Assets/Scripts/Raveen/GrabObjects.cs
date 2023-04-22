using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrabObjects : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Transform grabPoint;

    [SerializeField]
    private Transform rayPoint;
    [SerializeField]
    private float rayDistance;

    private GameObject grabbedObject;
    private int layerIndex;

    
    void Start()
    {
        layerIndex = LayerMask.NameToLayer("Objects");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitinfo = Physics2D.Raycast(rayPoint.position, transform.right, rayDistance);

        if (hitinfo.collider!=null && hitinfo.collider.gameObject.layer == layerIndex)
        {
            //grab Object
            if (Keyboard.current.spaceKey.wasPressedThisFrame && grabbedObject == null)
            {
                grabbedObject = hitinfo.collider.gameObject;
                grabbedObject.GetComponent<Rigidbody>().isKinematic = true;
                grabbedObject.transform.position = grabPoint.position;
                grabbedObject.transform.SetParent(transform);

            }
        
            else if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
                grabbedObject.transform.SetParent(null);
                grabbedObject = null;
            }
                    
                    
                    
                    
                    
                    
                    
                    
                    
        }


    }
}
