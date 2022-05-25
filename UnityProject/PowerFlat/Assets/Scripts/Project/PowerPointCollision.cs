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
        private MeshRenderer meshRenderer;

        private void Start()
        {
            //debug用.
            meshRenderer = gameObject.GetComponent<MeshRenderer>();
        }

        private void DebugChangeColor(Color color)
        {
            var mat = meshRenderer.material;
            mat.color = color;
            meshRenderer.material = mat;

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(key))
            {
                requireAddForce = true;
            }
            if (Input.GetKeyUp(key))
            {
                requireAddForce = false;
            }

            if (requireAddForce)
            {
                DebugChangeColor(Color.red);
            }
            else 
            {
                DebugChangeColor(Color.white);
            }
        }


        public void SetKeyCode(KeyCode key)
        {
            this.key = key;
        }

        private void OnTriggerStay(Collider other)
        {
            // リクエストないので、スキップ
            if (!requireAddForce)
            {
                return;
            }

            var rb = other.GetComponent<Rigidbody>();
            if (rb == null)
            {
                return; //rbないオブジェクトには、何もできない.
            }

            rb.AddForce(powerAngle,ForceMode.Impulse);
            requireAddForce = false; //一発殴ったら解除.
        }
    }
}
