using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexDisplacementController : MonoBehaviour
{
    public float displacementAmount = 0.6f;
    public float initialAmount = 0.6f;
    public float displacementStep = 0.2f;
    public float speed = 2f;
    public bool interactable = true;

    private MeshRenderer meshRenderer;


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (displacementAmount < 0.1)
        {
            displacementAmount += displacementStep;
        }

        displacementAmount = Mathf.Lerp(displacementAmount, 0, Time.deltaTime * speed);
        meshRenderer.material.SetFloat("_Amount", displacementAmount);

        if (interactable && Input.GetKey(KeyCode.Space))
        {
            displacementAmount += displacementStep;
        }
    }

}
