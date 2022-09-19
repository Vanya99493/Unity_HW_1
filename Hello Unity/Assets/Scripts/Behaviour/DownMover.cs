using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiguresGame
{
    public class DownMover : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private void FixedUpdate()
        {
            transform.Translate(0f, -_speed * Time.fixedDeltaTime, 0f);
        }
    }
}