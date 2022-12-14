using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiguresGame
{
    public static class SetSpawnTransform
    {
        public static void ResetTransformation(this Transform trans)
        {
            trans.position = Vector3.zero;
            trans.localRotation = Quaternion.identity;
            trans.localScale = new Vector3(1, 1, 1);
        }
    }
}