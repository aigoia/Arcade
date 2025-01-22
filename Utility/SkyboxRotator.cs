using UnityEngine;

namespace Utility
{
    public class SkyboxRotator : MonoBehaviour
    {
        int Rotation => Shader.PropertyToID("_Rotation");
        public float rotationSpeed = 0.2f;

        float _rotation;
    
        void Update()
        {
            _rotation += rotationSpeed * Time.deltaTime;
        
            if (_rotation >= 360f) _rotation = 0f;
        
            RenderSettings.skybox.SetFloat(Rotation, _rotation);
        }

        void OnDisable()
        {
            RenderSettings.skybox.SetFloat(Rotation, 0f);
        }
    }
}