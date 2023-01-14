﻿using Data.ValueObjects;
using Managers;
using Sirenix.OdinInspector;
using UnityEngine;
using TMPro;
using DG.Tweening;



    public class PlayerMeshController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private PlayerManager manager;
        [SerializeField] private new Renderer renderer;
        [SerializeField] private TextMeshPro scaleText;
        #endregion

        #region Private Variables

        [ShowInInspector] private ScaleData _data;

        #endregion

        #endregion

       
        internal void GetMeshData(ScaleData scaleData)
        {
            _data = scaleData;
        }
    internal void ScaleUpPlayer()
    {
        renderer.gameObject.transform.DOScaleX(_data.scaleCounter, 1).SetEase(Ease.Flash);
    }

    internal void ShowUpText()
    {
        scaleText.DOFade(1, 0f).SetEase(Ease.Flash).OnComplete(() => scaleText.DOFade(0, 0).SetDelay(.65f));
        scaleText.rectTransform.DOAnchorPosY(.85f, .65f).SetRelative(true).SetEase(Ease.OutBounce).OnComplete(() =>
            scaleText.rectTransform.DOAnchorPosY(-.85f, .65f).SetRelative(true));
    }

    internal void OnReset()
        {

        }

    }