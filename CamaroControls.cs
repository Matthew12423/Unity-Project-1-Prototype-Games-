using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaroControls : MonoBehaviour
{
    public WheelColliders colliders;
    public WheelMeshes wheelMeshes;
    //public float gas
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        UpdateWheels();
    }
    //void CheckInput()
    //{

    //}

    void UpdateWheels()
    {
        UpdateWheel(colliders.FrontLeftWheel, wheelMeshes.FrontLeftWheel);
        UpdateWheel(colliders.FrontRightWheel, wheelMeshes.FrontRightWheel);
        UpdateWheel(colliders.RearLeftWheel, wheelMeshes.RearLeftWheel);
        UpdateWheel(colliders.RearRightWheel, wheelMeshes.RearRightWheel);
    }
    void UpdateWheel(WheelCollider coll, MeshRenderer wheelMesh)
    {
        Quaternion quat;
        Vector3 position;
        coll.GetWorldPose(out position, out quat);
        wheelMesh.transform.position = position;
        wheelMesh.transform.rotation = quat;
    }
}
[System.Serializable]
public class WheelColliders
{
    public WheelCollider FrontLeftWheel;
    public WheelCollider FrontRightWheel;
    public WheelCollider RearLeftWheel;
    public WheelCollider RearRightWheel;
}
[System.Serializable]
public class WheelMeshes
{
    public MeshRenderer FrontLeftWheel;
    public MeshRenderer FrontRightWheel;
    public MeshRenderer RearLeftWheel;
    public MeshRenderer RearRightWheel;
}