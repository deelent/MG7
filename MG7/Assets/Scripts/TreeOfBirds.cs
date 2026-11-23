using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] _birds;
    [SerializeField] private float _interactionDistance = 10f;
    [SerializeField] private Transform _player;
    private void Update()
    {
        for (int i = 0; i < _birds.Length; i++)
        {
            float distance = Vector3.Distance(
                _birds[i].transform.position,
                _player.position);

            if (distance <= _interactionDistance)
            {
                _birds[i].SetActive(true);
            }
        }
    }
}