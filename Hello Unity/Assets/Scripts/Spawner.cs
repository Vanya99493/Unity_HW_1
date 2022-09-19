using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiguresGame
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _prefabs;
        [SerializeField] private float _ySpawnPosition;
        [SerializeField] private float _xLowerSpawnPosition;
        [SerializeField] private float _xUpperSpawnPosition;
        [SerializeField] private float _zSpawnPosition;

        public GameObject Spawn()
        {
            var obj = Instantiate(_prefabs[Random.Range(0, _prefabs.Count)]);
            obj.transform.position = GetSpawnPosition();
            return obj;
        }

        private Vector3 GetSpawnPosition()
        {
            return new Vector3(
                Random.Range(_xLowerSpawnPosition, _xUpperSpawnPosition),
                _ySpawnPosition,
                _zSpawnPosition
                );
        }
    }
}