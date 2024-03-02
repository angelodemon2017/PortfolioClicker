using UnityEditor;
using UnityEngine;
using Utils;

namespace Assets.Editor
{
    public class Helper : EditorWindow
    {
        private BigInt testNumber = new();
        private int mainNumberTest;
        private int rankNumberTest;

        [MenuItem("HELPER/Panel")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow(typeof(Helper));
        }

        void OnGUI()
        {
            ExperimentWithBigInt();
        }

        private void ExperimentWithBigInt()
        {
            mainNumberTest = EditorGUILayout.IntField("mainNumberTest =", mainNumberTest);
            rankNumberTest = EditorGUILayout.IntField("rankNumberTest =", rankNumberTest);

            var tempBI = new BigInt(mainNumberTest, rankNumberTest);

            GUILayout.Label($"{tempBI}");
        }
    }
}