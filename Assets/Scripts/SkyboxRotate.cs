using UnityEngine;

public class SkyboxRotate : MonoBehaviour
{
    public float rotationSpeed = 1f; // Speed of skybox rotation

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", 
            RenderSettings.skybox.GetFloat("_Rotation") + rotationSpeed * Time.deltaTime);
    }
}