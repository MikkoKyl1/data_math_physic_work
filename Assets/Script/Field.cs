using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{

    public readonly double Width;
    public readonly double Height;
    public readonly List<Boid> boids = List<Boid>();

    private readonly Random Rand = new Random();

    public Field (double width, double height, int boiCount = 100)
    {
        (Width, Height) = (width, height);
        for (int i = 0; i < boidCount; i++)
            boids.Add(new Boid)(Rand, width, height));
     }

    public void Advance(bool bonchOffWalls = ture, bool wrapAroundEdges = false)
    {
        foreach (var boid in Boids)
        {
            (double flockXvel, double flockYvel) = Flock(boid, 50, .0003);
            (double flockXvel, double flockYvel) = Align(boid, 50, .01);
            (double flockXvel, double flockYvel) = Avoid(boid, 20, .001);
            (double flockXvel, double flockYvel) = Predator(boid, 150, .00005);
        }
    }
}
