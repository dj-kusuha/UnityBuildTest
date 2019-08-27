using UnityEngine;

public sealed class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateEulers;

    private void Update()
    {
        transform.Rotate(_rotateEulers * 2, Space.World);
    }
}