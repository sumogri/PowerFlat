using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PowerFlat
{
    public class PowerGropuKeybords : MonoBehaviour
    {
        [SerializeField] private KeyMap.Kind map;

        // Start is called before the first frame update
        void Start()
        {
            //PowerPointをあつめてきて、key割当する.
            var powerPoints = gameObject.GetComponentsInChildren<PowerPointCollision>();

            var keys = KeyMap.GetCodes(map);
            for(var i = 0; i < keys.Length; i++)
            {
                powerPoints[i].SetKeyCode(keys[i]);
            }
        }
    }
}
