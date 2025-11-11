using UnityEngine;



public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 50f; // Adjust this value in the Inspector for desired speed
    public Vector3 rotationDirectionY = Vector3.up; // Default to rotating around the Y-axis
    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the specified axis at the given speed
        transform.Rotate(rotationDirectionY * rotationSpeed * Time.deltaTime);
    }
}
