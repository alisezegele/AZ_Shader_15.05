using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Player : MonoBehaviour
{
    public MeshRenderer ballRenderer;

    private void Update()
    {
        ballRenderer.sharedMaterial.SetVector("_PlayerPosition", transform.position);
    }
}
