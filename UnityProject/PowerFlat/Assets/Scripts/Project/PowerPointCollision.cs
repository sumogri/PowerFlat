using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PowerFlat
{
    /// <summary>
    /// コリジョン型パワー発生点.
    /// </summary>
    /// <remarks>
    /// isTriggerがOnのコリジョンを持つGameObectにつけて使用.
    /// 指定されたkeyを押すと、コリジョンが重なったものに対して力を与える.
    /// </remarks>>
    public class PowerPointCollision : MonoBehaviour
    {
        [SerializeField] private KeyCode key;
        [SerializeField] private Vector3 powerAngle;

        private bool requireAddForce = false;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(key))
            {
                requireAddForce = true;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log($"{other.gameObject.name}");
        }
    }
}
