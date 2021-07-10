using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UItxt : MonoBehaviour
{
    public GeneticManager gm;
    public Text generation, genome, velocidade,turning;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        generation.text = "Generation : " + gm.currentGeneration.ToString();
        genome.text = "Genome : " + gm.currentGenome.ToString();
        velocidade.text = "Velocity : " + CarController.cc.aceleration.ToString();
        turning.text = "Turning : " + CarController.cc.turning.ToString();

            
    }
}
