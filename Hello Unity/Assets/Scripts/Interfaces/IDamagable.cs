using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiguresGame
{
    public interface IDamagable<T>
    {
        void Damage(T damage);
    }
}