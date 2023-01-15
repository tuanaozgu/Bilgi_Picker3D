using Enums;
using Signals;
using UnityEngine;
using TMPro;





namespace Managers
{
    public class UIManager : MonoBehaviour
    {
        #region Self Variables

        #region Public Variables
        public TextMeshProUGUI pointText;
        public GameObject PointText;
        public int point;

        #endregion

        #region Serialized Variables

        #endregion

        #region Private Variables
      
        #endregion

        #endregion

        private void OnEnable()
        {
            SubscribeEvents();
        }


        private void SubscribeEvents()
        {
            CoreGameSignals.Instance.onLevelInitialize += OnLevelInitialize;
            CoreGameSignals.Instance.onLevelSuccessful += OnLevelSuccessful;
            CoreGameSignals.Instance.onLevelFailed += OnLevelFailed;
            CoreGameSignals.Instance.onReset += OnReset;
        }

        private void UnSubscribeEvents()
        {
            CoreGameSignals.Instance.onLevelInitialize -= OnLevelInitialize;
            CoreGameSignals.Instance.onLevelSuccessful -= OnLevelSuccessful;
            CoreGameSignals.Instance.onLevelFailed -= OnLevelFailed;
            CoreGameSignals.Instance.onReset -= OnReset;
        }

        private void OnDisable()
        {
            UnSubscribeEvents();
        }


       
        private void OnLevelInitialize(int levelValue)
        {
            CoreUISignals.Instance.onOpenPanel?.Invoke(UIPanelTypes.Level, 0);
            UISignals.Instance.onSetNewLevelValue?.Invoke(levelValue);
        }

        private void OnLevelSuccessful()
        {
            point = GameObject.FindGameObjectsWithTag("Point").Length;
            pointText.text = "Point: 2" +point.ToString();
            PointText.SetActive(true);
            CoreUISignals.Instance.onOpenPanel?.Invoke(UIPanelTypes.Win, 2);
            
            
        }

        private void OnLevelFailed()
        {
            CoreUISignals.Instance.onOpenPanel?.Invoke(UIPanelTypes.Fail, 2);
        }

        public void NextLevel()
        {
            CoreGameSignals.Instance.onNextLevel?.Invoke();
            CoreGameSignals.Instance.onReset?.Invoke();
            PointText.SetActive(false);
        }
    

        public void RestartLevel()
        {
            CoreGameSignals.Instance.onRestartLevel?.Invoke();
            CoreGameSignals.Instance.onReset?.Invoke();
            PointText.SetActive(false);
        }

        public void Play()
        {
            CoreGameSignals.Instance.onPlay?.Invoke();
            CoreUISignals.Instance.onClosePanel?.Invoke(1);
            CameraSignals.Instance.onSetCameraTarget?.Invoke();
        }

        private void OnReset()
        {
            CoreUISignals.Instance.onCloseAllPanels?.Invoke();
            CoreUISignals.Instance.onOpenPanel?.Invoke(UIPanelTypes.Start, 1);
        }
    }
}