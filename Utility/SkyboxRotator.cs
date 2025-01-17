using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    public float rotationSpeed = 0.2f;

    float rotation;
    
    void Update()
    {
        rotation += rotationSpeed * Time.deltaTime;
        
        if (rotation >= 360f) rotation = 0f;
        
        RenderSettings.skybox.SetFloat("_Rotation", rotation);
    }

    void OnDisable()
    {
        RenderSettings.skybox.SetFloat("_Rotation", 0f);
    }
}