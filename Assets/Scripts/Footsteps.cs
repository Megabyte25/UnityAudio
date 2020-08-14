using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    private PlayerController m_PlayerController;
    
    [SerializeField]
    private AudioSource m_footStepSound;

    private void Start()
    {
        m_PlayerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (m_PlayerController.GetMoveDirection().magnitude >= 0.1f)
        {
            if (!m_footStepSound.isPlaying)
            {
                m_footStepSound.Play();
            }
        }
    }
}
