using UnityEngine;
using UnityEngine.UI;

public class HeathBar : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _damage = 10f;
    [SerializeField] private float _emergency = 10f;
    [SerializeField] private Color _color = Color.red;

    private Slider _slider;
    private float _health;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        GetComponentInChildren<Image>().color = _color;
    } 

    private void Start() => _health = _maxHealth;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TakeDamage();
        else if (Input.GetKeyDown(KeyCode.H))
            TakeEmergency();
    }

    private void TakeDamage() => _slider.value = _health > 0 ? (_health -= _damage) / _maxHealth : 0;

    private void TakeEmergency() => _slider.value = _health <= _maxHealth ? (_health += _emergency) / _maxHealth : _maxHealth;
}
