using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class HealthUIHandler : MonoBehaviour
{
    private TMP_Text m_text;
    private UnityAction<int> OnHealthChangeAction;
    private Health m_health;
    void OnEnable()
    {
        OnHealthChangeAction += OnHealthChange;
    }
    void OnDisable()
    {
        OnHealthChangeAction -= OnHealthChange;
    }
    void Awake()
    {
        m_health = GetComponentInParent<Health>();
    }
    void Start()
    {
        m_health.AddOnHealthChangeListener(OnHealthChangeAction);
    }
    void OnDestroy()
    {
        m_health.RemoveOnHealthChangeListener(OnHealthChangeAction);
    }
    void OnHealthChange(int health)
    {
        m_text.text = ToString(health);
    }
}
