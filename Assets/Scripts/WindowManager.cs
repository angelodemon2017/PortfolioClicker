using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace WindowManagement
{
    public class WindowManager : MonoSingleton<WindowManager>
    {
        [SerializeField] private RectTransform _windowContainer;
        [SerializeField] private RectTransform _dialogsContainer;

        // Start is called before the first frame update
        void Start()
        {

        }

        public async Task ShowWindow(WindowName windowName, WindowModel model = null)
        {
            if (windowName == WindowName.None)
                return;


        }
    }
}