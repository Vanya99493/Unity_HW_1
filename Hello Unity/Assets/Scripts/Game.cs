using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiguresGame
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;
        [SerializeField] private float _startDelay;
        [SerializeField] private float _spawnDelay;
        [SerializeField] private int _enemyHealthPoints;
        [SerializeField] private int _damagePerTouch;

        private void Start()
        {
            StartCoroutine(SpawnEnemies());
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit[] hits = Physics.RaycastAll(ray);
                foreach (RaycastHit hit in hits)
                {
                    if(hit.transform.gameObject.GetComponent<Figure>() != null)
                    {
                        hit.transform.gameObject.GetComponent<Figure>().Damage(_damagePerTouch);
                        break;
                    }
                }
            }
        }

        private IEnumerator SpawnEnemies()
        {
            yield return new WaitForSeconds(_startDelay);

            while (true)
            {
                var figureObj = _spawner.Spawn();
                figureObj.GetComponent<Figure>().SetHealthPoints(_enemyHealthPoints);

                yield return new WaitForSeconds(_spawnDelay);
            }
        }
    }
}