using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8362440a : MonoBehaviour
{
    private void _0xb56e4e41()
    {
        if (this.ScoreCurrent > _0x0e5ba754._0xb33a38eb._0xd36fc50b)
            _0x0e5ba754._0xb33a38eb._0xd36fc50b = this.ScoreCurrent;
        if (_0xc991c2b7.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x194377ea)
                this._0x42c549ef();
    }

    public List<Button> HomeButtons = new();
    [HideInInspector]
    public int CurrentGameIndex;
    public List<TMP_Text> LevelNumberText = new();
    public void _0x0da0f552(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x43f08851();
            this._0xb56e4e41();
        }
    }

    public void _0xe3a5d2b3()
    {
        _0x0e5ba754.Instance._0x81d24962(true);
        _0x0e5ba754.Instance.LoadSceneByIndex(_0x47a641fc._0xb2d9c6f9.SCENE_0);
    }

    [HideInInspector]
    public bool IsGameEnd;
    private void _0x43f08851()
    {
        if (_0xc991c2b7.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x2df5f499 => _0x2df5f499.text = $"{this.ScoreCurrent}/{this._0x194377ea}");
        else
            this.ScoreText.ForEach(_0x2df5f499 => _0x2df5f499.text = $"{this.ScoreCurrent}");
    }

    private int _0xbf0007eb => this.ScoreCurrent;

    public int CustomTimeInitial = 30;
    private static _0x8362440a _0x1757e029;
    public List<Button> PauseButtons = new();
    public int CustomTargetScore = 10;
    private void _0xaf587aa6()
    {
        this.TimerText.ForEach(_0x2df5f499 => _0x2df5f499.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x83ee4cb9._0x573da0cc(new byte[6] { 25, 25, 40, 78, 7, 7 }, 116)));
    }

    public List<TMP_Text> TimerText = new();
    public void _0x4eae2b67()
    {
        if (_0xc991c2b7.Instance.IsOnlyWinGameEndEnabled)
            this._0x42c549ef();
        if (!this.IsGameEnd)
        {
            this._0x9976c84f();
            _0x0e5ba754.IsAfterLevelComplete = false;
            _0x0e5ba754.IsAfterLevelFailed = true;
            _0x48578c91 _0x42dcc16c = _0xc1be6679.Instance._0x2fa7501b(_0x47a641fc._0xfc7f1136.LOSE).GetComponent<_0x48578c91>();
            if (_0xc991c2b7.Instance.IsCheckScoreEnabled)
                _0x42dcc16c.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x194377ea}";
            else
                _0x42dcc16c.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x42dcc16c.ContentAdditionalText.text = $"{0}";
            _0x47a641fc._0x44cfec3f._0x678a3800 += 0;
            _0xc1be6679.Instance._0xcb33a0ba(_0x47a641fc._0xfc7f1136.LOSE);
        }
    }

    private int _0x194377ea => this.CustomTargetScore + _0x0e5ba754._0xb33a38eb._0x61dc61e0 * 10;

    [HideInInspector]
    public int ScoreCurrent;
    private IEnumerator _0x141dacda()
    {
        this._0xaf587aa6();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x0e5ba754.Instance._0xda4a5fc6 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x0e5ba754.Instance._0x53738293)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xaf587aa6();
            }
        }

        if (!this.IsGameEnd)
            this._0x4eae2b67();
    }

    public List<TMP_Text> ScoreText = new();
    private int _0xb4867c48 => this.CustomTimeInitial + _0x0e5ba754._0xb33a38eb._0x61dc61e0 * 10;

    [HideInInspector]
    public int TimeLeft;
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xb4867c48;
        this.CurrentGameIndex = _0x0e5ba754.Instance._0xda4a5fc6;
        foreach (Button _0xe64931b9 in this.HomeButtons)
            _0xe64931b9.onClick.AddListener(() =>
            {
                this._0xe3a5d2b3();
            });
        foreach (Button _0x905720c2 in this.PauseButtons)
            _0x905720c2.onClick.AddListener(() =>
            {
                _0x0e5ba754.Instance._0x81d24962(false);
                _0xc1be6679.Instance._0xcb33a0ba(_0x47a641fc._0xfc7f1136.PAUSE);
            });
        this._0x43f08851();
        this.LevelNumberText.ForEach(_0x2df5f499 => _0x2df5f499.text = $"LVL {_0x0e5ba754._0xb33a38eb._0x61dc61e0 + 1}");
        if (_0xc991c2b7.Instance.IsTimerEnabled)
        {
            this._0xaf587aa6();
            this.StartCoroutine(this._0x141dacda());
        }
    }

    private void _0x9976c84f()
    {
        this.IsGameEnd = true;
        _0x0e5ba754.IsAfterLevelComplete = true;
    }

    public List<TMP_Text> SubtitleText = new();
    private void _0xa031e18b()
    {
        if (this.ScoreCurrent >= this._0x194377ea)
            this._0x42c549ef();
        else
            this._0x4eae2b67();
    }

    private void Awake()
    {
        _0x1757e029 = this.gameObject.GetComponent<_0x8362440a>();
    }

    public void _0x42c549ef()
    {
        if (!this.IsGameEnd)
        {
            this._0x9976c84f();
            _0x0e5ba754.IsAfterLevelComplete = true;
            _0x0e5ba754.IsAfterLevelFailed = false;
            _0x48578c91 _0x389a9c4c = _0xc1be6679.Instance._0x2fa7501b(_0x47a641fc._0xfc7f1136.WIN).GetComponent<_0x48578c91>();
            if (_0xc991c2b7.Instance.IsCheckScoreEnabled)
                _0x389a9c4c.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x194377ea}";
            else
                _0x389a9c4c.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xc991c2b7.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x47a641fc._0x44cfec3f._0x678a3800)
                    _0x47a641fc._0x44cfec3f._0x678a3800 = this.ScoreCurrent;
                _0x389a9c4c.ContentAdditionalText.text = $"{_0x47a641fc._0x44cfec3f._0x678a3800}";
            }
            else
            {
                _0x389a9c4c.ContentAdditionalText.text = $"{this._0xbf0007eb}";
                _0x47a641fc._0x44cfec3f._0x678a3800 += this._0xbf0007eb;
            }

            if (_0xc991c2b7.Instance.IsLevelIncrementOnWin)
                ++_0x0e5ba754._0xb33a38eb._0x61dc61e0;
            _0xc1be6679.Instance._0xcb33a0ba(_0x47a641fc._0xfc7f1136.WIN);
        }
    }
}

internal static class _0x83ee4cb9
{
    internal static string _0x573da0cc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}