using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FresnelMatController : MonoBehaviour
{
    public float maxAmount = 2.4f;
    public float originalAmount = 1.2f;
    public float amount = 1.2f;
    public float step = 0.02f;
    public float speed = 1.0f;

    private MeshRenderer meshRenderer;


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (amount >= maxAmount)
        {
            amount = originalAmount;
        } else
        {
            amount += step;
        }

        amount = Mathf.Lerp(amount, 0, Time.deltaTime * speed);
        meshRenderer.material.SetFloat("_Amount", amount);

        if (Input.GetKey(KeyCode.Space))
        {
            amount += step;
        }
    }
}
