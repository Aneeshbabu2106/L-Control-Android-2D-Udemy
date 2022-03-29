using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    void Update()
    {
       float x = Input.acceleration.x;
       float z = Input.acceleration.z;

       Debug.Log("x"+x);
       Debug.Log("z"+z);

       transform.Rotate(0,0,-x*rotationSpeed*Time.deltaTime);
       transform.Translate(0,0,-z*speed*Time.deltaTime);
    }
}
