using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace WindowManagement
{
    [RequireComponent(typeof(CanvasGroup))]
    public class BaseWindowController : MonoBehaviour, IWindow
    {
        [SerializeField] protected CanvasGroup _canvasGroup;

        protected WindowModel Model;

        public CanvasGroup CanvasGroup => _canvasGroup;
        private void OnValidate()
        {
            if (_canvasGroup == null)
            {
                _canvasGroup = GetComponent<CanvasGroup>();
            }

            if (_canvasGroup == null)
            {
                Debug.LogError("Canvas Group is needed");
            }
        }

        public virtual async Task SetModel(WindowModel model)
        {
            Model = model;
            await AfterModelChanged();
        }

        protected virtual Task AfterModelChanged()
        {
            return Task.CompletedTask;
        }

/*        public virtual Task<Sequence> Show()
        {
            var sequence = DOTween.Sequence();

            sequence.AppendCallback(() =>
            {
                gameObject.SetActive(true);
                _canvasGroup.blocksRaycasts = true;
                try
                {
                    Model?.OnShowCallback?.Invoke();
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            });

            return Task.FromResult(sequence);
        }/**/

        public virtual void Close()
        {
            Close(false);
        }

        public virtual void Close(bool silent = false)
        {
            if (!silent)
            {
                try
                {
                    Model?.OnCloseCallback?.Invoke();
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            }

            if (gameObject == null)
                return;

            gameObject.SetActive(false);
        }
    }
}