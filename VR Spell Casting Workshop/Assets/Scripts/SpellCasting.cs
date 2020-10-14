using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCasting : MonoBehaviour
{
    public GameObject m_basicSpell;
    public Transform m_spellSpawn;

    public string m_triggerName;
    private bool m_triggerHeld;

    public float m_coolDown;
    private float m_currentTime;

    // Update is called once per frame
    void Update()
    {
        m_currentTime += Time.deltaTime;
        if (Input.GetAxis(m_triggerName) > 0.8f && !m_triggerHeld)
        {
            m_triggerHeld = true;
            if (m_currentTime > m_coolDown)
            {
                m_currentTime = 0;
                Instantiate(m_basicSpell, m_spellSpawn.position, m_spellSpawn.rotation);
            }
        }
        else if (Input.GetAxis(m_triggerName) < 0.8f && m_triggerHeld)
        {
            m_triggerHeld = false;
        }
    }
}
