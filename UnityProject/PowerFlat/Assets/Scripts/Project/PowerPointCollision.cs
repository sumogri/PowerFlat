using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PowerFlat
{
    /// <summary>
    /// �R���W�����^�p���[�����_.
    /// </summary>
    /// <remarks>
    /// isTrigger��On�̃R���W����������GameObect�ɂ��Ďg�p.
    /// �w�肳�ꂽkey�������ƁA�R���W�������d�Ȃ������̂ɑ΂��ė͂�^����.
    /// </remarks>>
    public class PowerPointCollision : MonoBehaviour
    {
        [SerializeField] private KeyCode key;
        [SerializeField] private Vector3 powerAngle;

        private bool requireAddForce = false;
        private MeshRenderer meshRenderer;

        private void Start()
        {
            //debug�p.
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
            // ���N�G�X�g�Ȃ��̂ŁA�X�L�b�v
            if (!requireAddForce)
            {
                return;
            }

            var rb = other.GetComponent<Rigidbody>();
            if (rb == null)
            {
                return; //rb�Ȃ��I�u�W�F�N�g�ɂ́A�����ł��Ȃ�.
            }

            rb.AddForce(powerAngle,ForceMode.Impulse);
            requireAddForce = false; //�ꔭ�����������.
        }
    }
}
