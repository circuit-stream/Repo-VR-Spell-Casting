using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStopper : MonoBehaviour
{
    public ParticleSystem m_myParticleSystem;

    void Start()
    {
        m_myParticleSystem = GetComponent<ParticleSystem>();
        Destroy(gameObject, m_myParticleSystem.startLifetime);
    }

    void OnParticleCollision(GameObject other)
    {
        m_myParticleSystem.emissionRate = 0;

        ParticleSystem.Particle[] tempPS = new ParticleSystem.Particle[m_myParticleSystem.particleCount];
        int pSSize = m_myParticleSystem.GetParticles(tempPS);

        int i = 0;
        while (i < pSSize)
        {
            tempPS[i].velocity = new Vector3(0, 0, 0);
            i++;
        }
        m_myParticleSystem.SetParticles(tempPS, pSSize);
    }
}
