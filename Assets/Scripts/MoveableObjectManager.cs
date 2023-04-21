using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObjectManager : MonoBehaviour
{
    Vector3 targetPosition;
    Vector3 startPosition;
    bool moving;

    Vector3 xOffset;
    Vector3 yOffset;
    Vector3 zOffset;
    public static Vector3 zAxisOriginA;
    public static Vector3 zAxisOriginB;
    public static Vector3 xAxisOriginA;
    public static Vector3 xAxisOriginB;

    [SerializeField]
    LayerMask walkableMask = 0;

    [SerializeField]
    LayerMask collidableMask = 0;

    bool falling;
    float targetFallHeight;

    private MoveStatus playerpickedup;
    private GameObject player;

    // private void Start() {
       
    // }

    void Update() {
         // Set the ray positions every frame
        
        yOffset = transform.position * 0.9f;
        zOffset = Vector3.forward * 0.9f;
        xOffset = Vector3.right * 0.9f;

        zAxisOriginA = yOffset + xOffset;
        zAxisOriginB = yOffset - xOffset;

        xAxisOriginA = yOffset + zOffset;
        xAxisOriginB = yOffset - zOffset;

        // Draw Debug Rays
        
        Debug.DrawLine(
                zAxisOriginA,
                zAxisOriginA + Vector3.forward * 1.4f,
                Color.red,
                Time.deltaTime);
        Debug.DrawLine(
                zAxisOriginB,
                zAxisOriginB + Vector3.forward * 1.4f,
                Color.red,
                Time.deltaTime);

        Debug.DrawLine(
                zAxisOriginA,
                zAxisOriginA + Vector3.back * 1.4f,
                Color.red,
                Time.deltaTime);
        Debug.DrawLine(
                zAxisOriginB,
                zAxisOriginB + Vector3.back * 1.4f,
                Color.red,
                Time.deltaTime);

        Debug.DrawLine(
                xAxisOriginA,
                xAxisOriginA + Vector3.left * 1.4f,
                Color.red,
                Time.deltaTime);
        Debug.DrawLine(
                xAxisOriginB,
                xAxisOriginB + Vector3.left * 1.4f,
                Color.red,
                Time.deltaTime);

        Debug.DrawLine(
                xAxisOriginA,
                xAxisOriginA + Vector3.right * 1.4f,
                Color.red,
                Time.deltaTime);
        Debug.DrawLine(
                xAxisOriginB,
                xAxisOriginB + Vector3.right * 1.4f,
                Color.red,
                Time.deltaTime);


        player = GameObject.Find("Player");
        playerpickedup = player.GetComponent<MoveStatus>();
        // if (playerpickedup.isMovingObject) {
        //     // if (Input.GetKeyDown(KeyCode.W)) {
        //     //     if (CanMove(Vector3.forward)) {
        //     //         targetPosition = transform.position * 2f;
        //     //         startPosition = transform.position;

        //     //         moving = true;
        //     //     }
        //     // } else if (Input.GetKeyDown(KeyCode.S)) {
        //     //     if (CanMove(Vector3.back)) {
        //     //         targetPosition = transform.position * 2f;
        //     //         startPosition = transform.position;
        //     //         moving = true;
        //     //     }
        //     // } else if (Input.GetKeyDown(KeyCode.A)) {
        //     //     if (CanMove(Vector3.left)) {
        //     //         targetPosition = transform.position * 2f;
        //     //         startPosition = transform.position;
        //     //         moving = true;
        //     //     }
        //     // } else if (Input.GetKeyDown(KeyCode.D)) {
        //     //     if (CanMove(Vector3.right)) {
        //     //         targetPosition = transform.position * 2f;
        //     //         startPosition = transform.position;
        //     //         moving = true;
        //     //     }
        //     // }
        //     Transform objectTransform = GetComponent<Transform>();
        //     objectTransform.SetParent(player.transform);
        //     objectTransform.rotation = Quaternion.LookRotation(player.transform.forward, player.transform.up);
        // }
        // else 
        // {
        //     Transform objectTransform = GetComponent<Transform>();
        //     objectTransform.SetParent(null, true);
        // }
            

    }

}