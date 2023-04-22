using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 0.25f;
    //[SerializeField]
    // float rayLength = 1.4f;
    // [SerializeField]
    // float rayOffsetX = 0.5f;
    //[SerializeField]
    //float rayOffsetY = 0.5f;
    // [SerializeField]
    // float rayOffsetZ = 0.5f;

    Vector3 targetPosition;
    Vector3 startPosition;
    bool moving;

    // Vector3 xOffset;
    // Vector3 yOffset;
    // Vector3 zOffset;
    // Vector3 zAxisOriginA;
    // Vector3 zAxisOriginB;
    // Vector3 xAxisOriginA;
    // Vector3 xAxisOriginB;

    // Vector3 xOffsetc;
    // Vector3 yOffsetc;
    // Vector3 zOffsetc;
    // Vector3 zAxisOriginAc;
    // Vector3 zAxisOriginBc;
    // Vector3 xAxisOriginAc;
    // Vector3 xAxisOriginBc;

    [SerializeField]
    Transform cameraRotator = null;

    // [SerializeField]
    // LayerMask walkableMask = 0;

    // [SerializeField]
    // LayerMask collidableMask = 0;



    // [SerializeField]
    // float maxFallCastDistance = 100f;
    [SerializeField]
    float fallSpeed = 30f;
    bool falling;
    float targetFallHeight;

    // private MoveStatus objectmoveStatus;

    // private GameObject selectedObject;
    // private GameObject childObject;

    // [SerializeField]
    // LayerMask moveableLayer;
    // [SerializeField]
    // LayerMask colidable;

    bool playerTurned_w = false;
    bool playerTurned_a = false;
    bool playerTurned_s = false;
    bool playerTurned_d = false;

    [SerializeField]
    private float forceMagnitude = 1.0f;

    public void Start()
    {
        //objectmoveStatus = GetComponent<MoveStatus>();
    }


    public void Update()
    {
        // Set the ray positions every frame

        // yOffset = transform.position + Vector3.up * rayOffsetY;
        // zOffset = Vector3.forward * rayOffsetZ;
        // xOffset = Vector3.right * rayOffsetX;

        // zAxisOriginA = yOffset + xOffset;
        // zAxisOriginB = yOffset - xOffset;

        // xAxisOriginA = yOffset + zOffset;
        // xAxisOriginB = yOffset - zOffset;

        // // Draw Debug Rays

        // Debug.DrawLine(
        //         zAxisOriginA,
        //         zAxisOriginA + Vector3.forward * rayLength,
        //         Color.red,
        //         Time.deltaTime);
        // Debug.DrawLine(
        //         zAxisOriginB,
        //         zAxisOriginB + Vector3.forward * rayLength,
        //         Color.red,
        //         Time.deltaTime);

        // Debug.DrawLine(
        //         zAxisOriginA,
        //         zAxisOriginA + Vector3.back * rayLength,
        //         Color.red,
        //         Time.deltaTime);
        // Debug.DrawLine(
        //         zAxisOriginB,
        //         zAxisOriginB + Vector3.back * rayLength,
        //         Color.red,
        //         Time.deltaTime);

        // Debug.DrawLine(
        //         xAxisOriginA,
        //         xAxisOriginA + Vector3.left * rayLength,
        //         Color.red,
        //         Time.deltaTime);
        // Debug.DrawLine(
        //         xAxisOriginB,
        //         xAxisOriginB + Vector3.left * rayLength,
        //         Color.red,
        //         Time.deltaTime);

        // Debug.DrawLine(
        //         xAxisOriginA,
        //         xAxisOriginA + Vector3.right * rayLength,
        //         Color.red,
        //         Time.deltaTime);
        // Debug.DrawLine(
        //         xAxisOriginB,
        //         xAxisOriginB + Vector3.right * rayLength,
        //         Color.red,
        //         Time.deltaTime);


        // Debug.DrawLine(
        //         MoveableObjectManager.zAxisOriginA,
        //         MoveableObjectManager.zAxisOriginA + Vector3.forward * rayLength,
        //         Color.green,
        //         Time.deltaTime);
        // Debug.DrawLine(
        //         MoveableObjectManager.zAxisOriginB,
        //         MoveableObjectManager.zAxisOriginB + Vector3.forward * rayLength,
        //         Color.green,
        //         Time.deltaTime);

        // Debug.DrawLine(
        //         MoveableObjectManager.zAxisOriginA,
        //         MoveableObjectManager.zAxisOriginA + Vector3.back * rayLength,
        //         Color.green,
        //         Time.deltaTime);
        // Debug.DrawLine(
        //         MoveableObjectManager.zAxisOriginB,
        //         MoveableObjectManager.zAxisOriginB + Vector3.back * rayLength,
        //         Color.green,
        //         Time.deltaTime);

        // Debug.DrawLine(
        //         MoveableObjectManager.xAxisOriginA,
        //         MoveableObjectManager.xAxisOriginA + Vector3.left * rayLength,
        //         Color.green,
        //         Time.deltaTime);
        // Debug.DrawLine(
        //         MoveableObjectManager.xAxisOriginB,
        //         MoveableObjectManager.xAxisOriginB + Vector3.left * rayLength,
        //         Color.green,
        //         Time.deltaTime);

        // Debug.DrawLine(
        //         MoveableObjectManager.xAxisOriginA,
        //         MoveableObjectManager.xAxisOriginA + Vector3.right * rayLength,
        //         Color.green,
        //         Time.deltaTime);
        // Debug.DrawLine(
        //         MoveableObjectManager.xAxisOriginB,
        //         MoveableObjectManager.xAxisOriginB + Vector3.right * rayLength,
        //         Color.green,
        //         Time.deltaTime);


        // Debug raycast line
        //     Debug.DrawLine(transform.position + Vector3.up, transform.position  + Vector3.up + transform.forward * rayLength, Color.red, Time.deltaTime);

        //    // Debug.DrawLine(transform.position + Vector3.up, transform.position  + Vector3.up + transform.forward * 3.5f, Color.green, Time.deltaTime);

        //     childObject = FindChildWithTag(transform, "Moveable");
        //     if (childObject != null) {
        //         yOffsetc = childObject.transform.position + Vector3.up * 0.5f;
        //         zOffsetc = Vector3.forward * 0.5f;
        //         xOffsetc = Vector3.right * 0.5f;

        //         zAxisOriginAc = yOffsetc + xOffsetc;
        //         zAxisOriginBc = yOffsetc - xOffsetc;

        //         xAxisOriginAc = yOffsetc + zOffsetc;
        //         xAxisOriginBc = yOffsetc - zOffsetc;

        //         // Draw Debug Rays

        //         Debug.DrawLine(
        //                 zAxisOriginAc,
        //                 zAxisOriginAc + Vector3.forward * rayLength,
        //                 Color.green,
        //                 Time.deltaTime);
        //         Debug.DrawLine(
        //                 zAxisOriginBc,
        //                 zAxisOriginBc + Vector3.forward * rayLength,
        //                 Color.green,
        //                 Time.deltaTime);

        //         Debug.DrawLine(
        //                 zAxisOriginAc,
        //                 zAxisOriginAc + Vector3.back * rayLength,
        //                 Color.green,
        //                 Time.deltaTime);
        //         Debug.DrawLine(
        //                 zAxisOriginBc,
        //                 zAxisOriginBc + Vector3.back * rayLength,
        //                 Color.green,
        //                 Time.deltaTime);

        //         Debug.DrawLine(
        //                 xAxisOriginAc,
        //                 xAxisOriginAc + Vector3.left * rayLength,
        //                 Color.green,
        //                 Time.deltaTime);
        //         Debug.DrawLine(
        //                 xAxisOriginBc,
        //                 xAxisOriginBc + Vector3.left * rayLength,
        //                 Color.green,
        //                 Time.deltaTime);

        //         Debug.DrawLine(
        //                 xAxisOriginAc,
        //                 xAxisOriginAc + Vector3.right * rayLength,
        //                 Color.green,
        //                 Time.deltaTime);
        //         Debug.DrawLine(
        //                 xAxisOriginBc,
        //                 xAxisOriginBc + Vector3.right * rayLength,
        //                 Color.green,
        //                 Time.deltaTime);

        //        // Debug.DrawLine(childObject.transform.position, childObject.transform.position  + Vector3.up + childObject.transform.forward * rayLength, Color.green, Time.deltaTime);
        //     }



        if (falling)
        {
            if (transform.position.y <= targetFallHeight)
            {
                float x = Mathf.Round(transform.position.x);
                float y = Mathf.Round(targetFallHeight);
                float z = Mathf.Round(transform.position.z);

                transform.position = new Vector3(x, y, z);

                falling = false;

                return;
            }

            transform.position += Vector3.down * fallSpeed * Time.deltaTime;
            return;
        }
        else if (moving)
        {
            if (Vector3.Distance(startPosition, transform.position) > 1f)
            {
                float x = Mathf.Round(targetPosition.x);
                float y = Mathf.Round(targetPosition.y);
                float z = Mathf.Round(targetPosition.z);

                transform.position = new Vector3(x, y, z);

                moving = false;

                return;
            }

            transform.position += (targetPosition - startPosition) * moveSpeed * Time.deltaTime;
            return;
        }
        //else {
        //     RaycastHit[] hits = Physics.RaycastAll(
        //             transform.position + Vector3.up * 0.5f,
        //             Vector3.down,
        //             maxFallCastDistance,
        //             walkableMask
        //     );

        //     if (hits.Length > 0) {
        //         int topCollider = 0;
        //         for (int i = 0; i < hits.Length; i++) {
        //             if (hits[topCollider].collider.bounds.max.y < hits[i].collider.bounds.max.y)
        //                 topCollider = i;
        //         }
        //         if (hits[topCollider].distance > 1f) {
        //             targetFallHeight = transform.position.y - hits[topCollider].distance + 0.5f;
        //             falling = true;
        //         }
        //     } else {
        //         targetFallHeight = -Mathf.Infinity;
        //         falling = true;
        //     }
        // }

        // Handle player input
        // Also handle moving up 1 level
        // if (Input.GetKeyDown(KeyCode.Space) && (MovementSystem.enableInput))
        // {
        //     if (selectedObject != null && !objectmoveStatus.isMovingObject)
        //     {
        //         objectmoveStatus.isMovingObject = true;
        //         selectedObject.GetComponent<Transform>().SetParent(transform);
        //         selectedObject.GetComponent<Transform>().rotation = Quaternion.LookRotation(transform.forward, transform.up);
        //     }
        //     else if (selectedObject != null && objectmoveStatus.isMovingObject)
        //     {
        //         objectmoveStatus.isMovingObject = false;
        //         selectedObject.GetComponent<Transform>().SetParent(null, true);
        //        // Transform objectTransform = GetComponent<Transform>();
        //        // transform.DetachChildren();
        //     }
        // }

        if (Input.GetKey(KeyCode.W) && (MovementSystem.enableInput))
        {
            // if (objectmoveStatus.isMovingObject) {
            //     targetPosition = transform.position + cameraRotator.transform.forward * 2f;
            //     startPosition = transform.position;

            //     //  if (CanMove(Vector3.forward)) {
            //     //     moving = true;
            //     // }
            //     // else moving = false;
            //     moving = true;
            // }
            if (playerTurned_w)
            {
                targetPosition = transform.position + cameraRotator.transform.forward;
                startPosition = transform.position;
                moving = true;
            }
            else
            {
                PlayerTurn(Vector3.forward, true, false, false, false);
                // Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward);
                // transform.rotation = targetRotation; 
                // targetPosition = transform.position + cameraRotator.transform.forward * 2f;
                // startPosition = transform.position;

                //moving = true;
            }

            // if (CanMove(Vector3.forward)) {

            //     targetPosition = transform.position + cameraRotator.transform.forward * 2f;
            //     startPosition = transform.position;

            //     moving = true;
            // }
        }
        else if (Input.GetKey(KeyCode.S) && (MovementSystem.enableInput))
        {

            // if (objectmoveStatus.isMovingObject) {
            //     targetPosition = transform.position - cameraRotator.transform.forward * 2f;
            //     startPosition = transform.position;
            //     //  if (CanMove(Vector3.forward)) {
            //     //     moving = true;
            //     // }
            //     // else moving = false;
            //     moving = true;
            // }
            if (playerTurned_s)
            {
                targetPosition = transform.position - cameraRotator.transform.forward;
                startPosition = transform.position;
                moving = true;
            }
            else
            {
                PlayerTurn(Vector3.back, false, false, true, false);
                // Quaternion targetRotation = Quaternion.LookRotation(Vector3.back);
                // transform.rotation = targetRotation; 
                // targetPosition = transform.position - cameraRotator.transform.forward * 2f;
                // startPosition = transform.position;
                // moving = true;
            }

            // if (CanMove(Vector3.back)) {
            //     targetPosition = transform.position - cameraRotator.transform.forward * 2f;
            //     startPosition = transform.position;
            //     moving = true;
            // } 
        }
        else if (Input.GetKey(KeyCode.A) && (MovementSystem.enableInput))
        {
            // if (objectmoveStatus.isMovingObject) {
            //     targetPosition = transform.position - cameraRotator.transform.right * 2f;
            //     startPosition = transform.position;
            //     //  if (CanMove(Vector3.forward)) {
            //     //     moving = true;
            //     // }
            //     // else moving = false;
            //     moving = true;
            // }
            if (playerTurned_a)
            {
                targetPosition = transform.position - cameraRotator.transform.right;
                startPosition = transform.position;
                moving = true;
            }
            else
            {
                PlayerTurn(Vector3.left, false, true, false, false);
                // Quaternion targetRotation = Quaternion.LookRotation(Vector3.left);
                // transform.rotation = targetRotation; 
                // targetPosition = transform.position - cameraRotator.transform.right * 2f;
                // startPosition = transform.position;
                // moving = true;
            }

            // if (CanMove(Vector3.left)) {
            //     targetPosition = transform.position - cameraRotator.transform.right * 2f;
            //     startPosition = transform.position;
            //     moving = true;
            // } 

        }
        else if (Input.GetKey(KeyCode.D) && (MovementSystem.enableInput))
        {
            // if (objectmoveStatus.isMovingObject) {
            //     targetPosition = transform.position + cameraRotator.transform.right * 2f;
            //     startPosition = transform.position;
            //     // if (CanMove(Vector3.forward)) {
            //     //     moving = true;
            //     // }
            //     // else moving = false;
            //     moving = true;
            // }
            if (playerTurned_d)
            {
                //pauseing with delta time *(need delta time to pause)
                // Vector3 displacementVector = (targetPosition - startPosition) * Time.deltaTime;
                // transform.position += displacementVector;
                targetPosition = transform.position + cameraRotator.transform.right;
                startPosition = transform.position;
                moving = true;

            }
            else
            {
                PlayerTurn(Vector3.right, false, false, false, true);
                // Quaternion targetRotation = Quaternion.LookRotation(Vector3.right);
                // transform.rotation = targetRotation; 
                // playerTurned_w = false;
                // playerTurned_a = false;
                // playerTurned_s = false;
                // playerTurned_d = true;

            }

            // if (CanMove(Vector3.right)) {
            //     targetPosition = transform.position + cameraRotator.transform.right * 2f;
            //     startPosition = transform.position;
            //     moving = true;
            // }
        }

        // if (objectmoveStatus.isMovingObject == false)
        // {
        //     RaycastHit hit;
        //     if (Physics.Raycast(transform.position + Vector3.up, transform.forward, out hit, 2.0f, moveableLayer))
        //     {
        //         GameObject hitObject = hit.collider.gameObject;
        //         if (hitObject.CompareTag("Moveobj"))
        //         {
        //             if (selectedObject != hitObject)
        //             {
        //                 if (selectedObject != null)
        //                 {
        //                     selectedObject.GetComponent<Renderer>().material.color = Color.white;
        //                 }
        //                 selectedObject = hitObject;
        //                 selectedObject.GetComponent<Renderer>().material.color = Color.red;
        //             }
        //         }
        //         else
        //         {
        //             if (selectedObject != null)
        //             {
        //                 selectedObject.GetComponent<Renderer>().material.color = Color.yellow;
        //                 selectedObject = null;
        //             }
        //         }
        //     }
        //     else
        //     {
        //         if (selectedObject != null)
        //         {
        //             selectedObject.GetComponent<Renderer>().material.color = Color.green;
        //             selectedObject = null;
        //         }
        //     }
        // }
    }

    // Check if the player can move

    // bool CanMove(Vector3 direction) {
    //     if (objectmoveStatus.isMovingObject) {

    //        RaycastHit hit;
    //         if (Physics.Raycast(childObject.transform.position + Vector3.up, childObject.transform.forward, out hit, 2.0f, moveableLayer))
    //         {
    //            return false;
    //         }
    //         else if (Physics.Raycast(transform.position + Vector3.up, -transform.forward, out hit, 2.0f, moveableLayer))
    //         {
    //            return false;
    //         } 
    //         else if (Physics.Raycast(childObject.transform.position + Vector3.up, childObject.transform.right, out hit, 2.0f, moveableLayer))
    //         {
    //            return false;
    //         }
    //         else if (Physics.Raycast(childObject.transform.position + Vector3.up, -childObject.transform.right, out hit, 2.0f, moveableLayer))
    //         {
    //            return false;
    //         }
    //         else if (Physics.Raycast(childObject.transform.position + Vector3.up, childObject.transform.forward, out hit, 2.0f, LayerMask.GetMask("Colidable")))
    //         {
    //            return false;
    //         }
    //         else if (Physics.Raycast(transform.position + Vector3.up, -transform.forward, out hit, 2.0f, LayerMask.GetMask("Colidable")))
    //         {
    //            return false;
    //         } 
    //         else if (Physics.Raycast(childObject.transform.position + Vector3.up, childObject.transform.right, out hit, 2.0f, LayerMask.GetMask("Colidable")))
    //         {
    //            return false;
    //         }
    //         else if (Physics.Raycast(childObject.transform.position + Vector3.up, -childObject.transform.right, out hit, 2.0f, LayerMask.GetMask("Colidable")))
    //         {
    //            return false;
    //         }

    //         return true;

    //     }
    //     else {
    //         // Quaternion targetRotation = Quaternion.LookRotation(direction);
    //         // transform.rotation = targetRotation; 
    //         if (direction.z != 0) {
    //             if (Physics.Raycast(zAxisOriginA, direction, rayLength)) return false;
    //             if (Physics.Raycast(zAxisOriginB, direction, rayLength)) return false;         
    //         }
    //         else if (direction.x != 0) {
    //             if (Physics.Raycast(xAxisOriginA, direction, rayLength)) return false;
    //             if (Physics.Raycast(xAxisOriginB, direction, rayLength)) return false;
    //         }
    //         return true;
    //     }

    // }

    // Check if the player can step-up

    // bool CanMoveUp(Vector3 direction) {
    //     if (Physics.Raycast(transform.position + Vector3.up * 0.5f, Vector3.up, 1f, collidableMask))
    //         return false;
    //     if (Physics.Raycast(transform.position + Vector3.up * 1.5f, direction, 1f, collidableMask))
    //         return false;
    //     if (Physics.Raycast(transform.position + Vector3.up * 0.5f, direction, 1f, walkableMask))
    //         return true;
    //     return false;
    // }

    void PlayerTurn(Vector3 direction, bool w, bool a, bool s, bool d)
    {
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = targetRotation * cameraRotator.transform.rotation;
        playerTurned_w = w;
        playerTurned_a = a;
        playerTurned_s = s;
        playerTurned_d = d;
    }

    // public static GameObject FindChildWithTag(Transform parent, string layerName)
    // {
    //     foreach (Transform child in parent)
    //     {
    //         if (child.gameObject.layer == LayerMask.NameToLayer(layerName))
    //         {
    //             return child.gameObject;
    //         }
    //         else
    //         {
    //             GameObject obj = FindChildWithTag(child, layerName);
    //             if (obj != null)
    //             {
    //                 return obj;
    //             }
    //         }
    //     }
    //     return null;
    // }

    // void OnCollisionEnter(Collision other) {
    //     Debug.Log("colision");
    //     if (!falling && (1 << other.gameObject.layer & walkableMask) == 0) {
    //         // Find a nearby vacant square to push us on to
    //         // Vector3 direction = Vector3.zero;
    //         // Vector3[] directions = { Vector3.forward, Vector3.right, Vector3.back, Vector3.left };
    //         // for (int i = 0; i < 4; i++) {
    //         //     if (Physics.OverlapSphere(transform.position + directions[i], 0.1f).Length == 0) {
    //         //         direction = directions[i];
    //         //         break;
    //         //     }
    //         // }
    //         transform.position = transform.position;
    //         // Vector3 direction = (transform.position - other.transform.position).normalized;
    //         // transform.position += direction * 0.1f;
    //     }else {
    //         transform.position = transform.position;
    //     }
    // }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var rigidBody = hit.collider.attachedRigidbody;

        if (rigidBody != null)
        {
            var forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            rigidBody.AddForceAtPosition(forceDirection * forceMagnitude, transform.position, ForceMode.Impulse);


        }
    }
}