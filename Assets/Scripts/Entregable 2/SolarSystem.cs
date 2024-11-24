using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    //Atributes
    //Public
    public float sunRotationSpeed = 30f;
    public float sunDistance = 10f; //Sun distance from the universe center
    public float satellite1RotationSpeed = 90f;
    public float satellite1Distance = 5f; //Satelliet 1 distance from the Sun
    public float satellite2RotationSpeed = 45f;
    public float satellite2Distance = 2f; //Satelliet 1 distance from satellite 1
    public float growSpeed = 0.025f;
   
    public Transform satellite1;
    public Transform satellite2;
    public Transform sunCamera;

    //Private
    private Vector3 universeCenter;

    private void Start()
    {
        //UniverseCenter start
        universeCenter = new Vector3(0, 0, 0);
        //Sun start
        transform.position = new Vector3(sunDistance, 0, 0);
        //Satellite1 start
        satellite1.position = transform.position + new Vector3 (satellite1Distance, 0, 0);
        //Satellite2 start
        satellite2.position = satellite1.position + new Vector3(satellite2Distance, 0, 0);
        

    }
    private void Update()
    {
        //Rotations
        transform.RotateAround(universeCenter, Vector3.up , sunRotationSpeed * Time.deltaTime);
        satellite1.RotateAround(transform.position, transform.up, satellite1RotationSpeed * Time.deltaTime);
        satellite2.RotateAround(satellite1.position, satellite1.up, satellite2RotationSpeed * Time.deltaTime);
        //LookAt
        transform.LookAt(universeCenter);
        satellite2.LookAt(satellite1.position);
        sunCamera.LookAt(transform);


        //Gizmos
        Debug.DrawLine(universeCenter, transform.position, Color.yellow);
        Debug.DrawLine(transform.position, satellite1.position, Color.red);
        Debug.DrawLine(transform.position, satellite2.position, Color.blue);
        Debug.DrawLine(satellite1.position, satellite2.position, Color.green);
        
        //Satellite2 scale changer
        if (Vector3.Angle(satellite2.right, Vector3.right)<90)
        {
            satellite2.localScale -= new Vector3(growSpeed, growSpeed, growSpeed);
        }
        else
        {
            satellite2.localScale += new Vector3(growSpeed, growSpeed, growSpeed);
        }


    }

}
