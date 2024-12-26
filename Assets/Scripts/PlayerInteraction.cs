using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private GameObject m_interactionObject;

    [SerializeField] private float m_interactionTime;
    [SerializeField] private float m_interactionDelay;

    private bool m_canInteract = true;

    [Header("Input")]
    [SerializeField] public ShootingGameInputs playerControls;
    private InputAction m_interact;

    private void Awake()
    {
        //Initialise the input actions
        playerControls = new ShootingGameInputs();
    }

    private void OnEnable()
    {
        //m_interact = playerControls.Player.Interact;
        m_interact.Enable();
        m_interact.performed += Interact;
    }

    private void OnDisable()
    {
        m_interact.Disable();
    }

    private void Interact(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (m_canInteract)
            {
                m_canInteract = false;
                m_interactionObject.SetActive(true);
                Invoke(nameof(ResetInteraction), m_interactionTime);
            }
        }
    }

    private void ResetInteraction()
    {
        m_interactionObject.SetActive(false);
        Invoke(nameof(ResetCanInteract), m_interactionDelay);
    }

    private void ResetCanInteract()
    {
        m_canInteract = true;
    }
}
