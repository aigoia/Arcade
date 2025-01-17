using System;
using UnityEngine;

namespace Arcade
{
    public class PlayerCollider : MonoBehaviour
    {
        GameObject ShieldMesh => transform.Find("Ball").Find("Shield").gameObject; 
        LayerMask Block => LayerMask.NameToLayer("Block");
        
        void OnCollisionEnter(Collision other)
        {
            ShieldMesh.SetActive(other.gameObject.layer == Block);
        }
    }
}
