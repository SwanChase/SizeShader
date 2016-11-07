using UnityEngine;
using System.Collections;

public class ShaderSlider : MonoBehaviour
{
    [SerializeField, Range(-0.015f, 0.1f)]
    float shaderSlider;

    public float _shaderSlider
    {
        get
        {
            return shaderSlider;
        }

        set
        {
            shaderSlider = value;
        }
    }

    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        //rend.material.shader = Shader.Find("TestingShaders");
    }
    void Update()
    {
        rend.material.SetFloat("_ExtrudeAmount", shaderSlider);
    }    
}
