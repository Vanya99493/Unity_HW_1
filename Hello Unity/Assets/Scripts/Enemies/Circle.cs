using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiguresGame
{
    public class Circle : Figure
    {
        protected override string Destroyed()
        {
            return "Circle was destroyed";
        }
    }
}