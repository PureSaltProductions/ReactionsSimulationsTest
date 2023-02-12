using System.Collections;
using UnityEngine;
using Zenject;

public class Platform : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public class Pool : MonoMemoryPool<Vector3, Platform>
    {
        protected override void Reinitialize(Vector3 velocity, Platform platform)
        {
            //platform.Reset(velocity);
        }
    }
}
