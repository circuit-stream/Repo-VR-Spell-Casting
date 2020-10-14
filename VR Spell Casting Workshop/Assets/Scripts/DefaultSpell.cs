using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultSpell : MonoBehaviour
{
    public ParticleSystem m_myParticleSystem;
    public Rigidbody m_rb;
    public float m_shootForce;
    void Start()
    {
        Destroy(gameObject, 10);
        m_rb.AddForce(transform.forward * m_shootForce);
    }

    void OnParticleCollision(GameObject other)
    {
        m_myParticleSystem.emissionRate = 0;
        Destroy(gameObject, m_myParticleSystem.startLifetime);
    }


}
