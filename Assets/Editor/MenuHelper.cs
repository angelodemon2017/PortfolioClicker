using UnityEngine;
using UnityEditor;
using Utils;

namespace Assets.Scripts.Editor
{
    public class MenuHelper : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("HELPER/Random Value")]
        static void Random_value()
        {
            var number = new BigInt(654321, 0);

            Debug.Log(number);
        }
#endif
    }
}