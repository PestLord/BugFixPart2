using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _wallPrefab;
    
    private void Start()
    {
        var wall = Instantiate(_wallPrefab);
        wall.isKinematic = false;
    }
}
