using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiguresGame
{
    public class Square : Figure
    {
        protected override string Destroyed()
        {
            return "Square was destroyed";
        }
    }
}