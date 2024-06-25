using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EBAC.CORE.singleton;
using DG.Tweening;




public class GameManager : Singleton<GameManager>

    {

    [Header("Player")]
    public GameObject PlayerPrefab;

    [Header("Enemies")]

    public List<GameObject> Enemies;

[Header("References")]

public Transform StartPoint;



 [Header("Animation")]
  public float duration = .2f;
  public float delay = .05f;
  public Ease ease = Ease.OutBack;



private GameObject _currentPlayer;



private void Start()

{
Init();
}


public void Init()
{
spawnPlayer();
}

private void spawnPlayer()
{
_currentPlayer = Instantiate(PlayerPrefab);
_currentPlayer.transform.position = StartPoint.transform.position;
_currentPlayer.transform.DOScale(0,duration).SetEase(ease).From().SetDelay(delay);
}
           
    }