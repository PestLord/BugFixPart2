using UnityEngine;

/// <summary>
/// Измените этот скрипт
/// </summary>
public class Wall : MonoBehaviour
{
    [SerializeField]
    private Detector _detector;
    [SerializeField] 
    private Vector3 _targetPosition = new(0, 0, 0f);

    private void Awake()
    {
        _detector = FindObjectOfType<Detector>();
        _targetPosition = _detector.transform.position + new Vector3(0,_detector.transform.localScale.y,0);
        _detector.CoinDetected += ChangePosition;
    }

    private void ChangePosition()
    {
        transform.position = _targetPosition;
    }
}