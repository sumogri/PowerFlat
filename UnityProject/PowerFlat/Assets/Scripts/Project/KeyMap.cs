using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PowerFlat
{
    public static class KeyMap
    {
        private static Dictionary<Kind,KeyCode[]> keyCodes = new System.Collections.Generic.Dictionary<Kind,KeyCode[]>();

        static KeyMap()
        {
            KeyCode[] keyCode_Q = 
            { 
                KeyCode.Q,
                KeyCode.W,
                KeyCode.E,
                KeyCode.R,
                KeyCode.T,
                KeyCode.Y,
                KeyCode.U,
                KeyCode.I,
                KeyCode.O,
                KeyCode.P,
            };
            keyCodes.Add(Kind.QLine, keyCode_Q);


            KeyCode[] keyCode_A =
            {
                KeyCode.A,
                KeyCode.S,
                KeyCode.D,
                KeyCode.F,
                KeyCode.G,
                KeyCode.H,
                KeyCode.J,
                KeyCode.K,
                KeyCode.L,
                KeyCode.Equals,
            };
            keyCodes.Add(Kind.ALine, keyCode_A);

            KeyCode[] keyCode_Z =
            {
                KeyCode.Z,
                KeyCode.X,
                KeyCode.C,
                KeyCode.V,
                KeyCode.B,
                KeyCode.N,
                KeyCode.M,
                KeyCode.Comma,
                KeyCode.Period,
                KeyCode.Slash,
            };
            keyCodes.Add(Kind.ZLine, keyCode_Z);
        }

        public static KeyCode[] GetCodes(Kind kind)
        {
            return keyCodes[kind];
        }

        public enum Kind
        {
            QLine,
            ALine,
            ZLine
        }
    }
}
