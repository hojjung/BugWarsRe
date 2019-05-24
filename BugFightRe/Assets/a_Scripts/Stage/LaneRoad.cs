﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class LaneRoad : MonoBehaviour
{
    Collider2D _coll2D;  
    [SerializeField]
    Transform _leftStartPos;
    [SerializeField]
    Transform _rightStartPos;
    [Header("DragFeedBackSRender")]
    [SerializeField]
    SpriteRenderer _sRenderer;
    [SerializeField]
    private int _laneNumber = 0;

    Tweener _fadeTweener;

    public Collider2D  myColl2D { get => _coll2D; set => _coll2D = value; }
    public Transform myLeftLaneStartPos { get => _leftStartPos; set => _leftStartPos = value; }
    public Transform myRightLaneStartPos { get => _rightStartPos; set => _rightStartPos = value; }
    public SpriteRenderer mySRenderer { get => _sRenderer; set => _sRenderer = value; }
    public int myLaneNumber { get => _laneNumber; }

    private void Awake()
    {
        myColl2D = GetComponent<Collider2D>();
       
    }
    public void ShowFeedBackLaneRoad()
    {
        if(_fadeTweener!=null)
        {
            _fadeTweener.Complete();
        }
         _fadeTweener = mySRenderer.DOFade(1, 0.4f);
    }
    public void HideFeedBackLaneRoad()
    {
        if (_fadeTweener != null)
        {
            _fadeTweener.Complete();
        }
        _fadeTweener = mySRenderer.DOFade(0, 0.4f);
    }
}
