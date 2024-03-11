using UnityEngine;

public class Task1 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    [SerializeField] 
    private Vector3 _targetScale = new(2, 2, 2);
    
    private void Start()
    {
        var wall = Instantiate(_wallPrefab);
        wall.localScale = _targetScale;
    }
}
