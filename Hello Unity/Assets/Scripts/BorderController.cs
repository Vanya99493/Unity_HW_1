using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiguresGame
{
    public class BorderController : MonoBehaviour
    {
        private void OnTriggerExit(Collider other)
        {
            if(other.gameObject.GetComponent<Figure>() != null)
            {
                Destroy(other.gameObject);
            }
        }
    }
}