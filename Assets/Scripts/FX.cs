using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FX : MonoBehaviour
{
    [SerializeField] private ParticleSystem cubeExplosionFX;

   
    [SerializeField] private MeshRenderer cube;
    ParticleSystemRenderer cubeExplosionFXMainModule;
    private Renderer render;
   

    public static FX Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        
        render = cubeExplosionFX.GetComponent<Renderer>();
    }

    public void PlayCubeExplosionFX(Vector3 position, Color color)
    {
        render.material.color = new ParticleSystem.MinMaxGradient(color).color;

        
        

        cubeExplosionFX.transform.position = position;
        
        cubeExplosionFX.Play();
    }

    
}
