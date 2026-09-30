using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x47a641fc;

public class _0x3d672026 : MonoBehaviour
{
    public void _0xe65d1564()
    {
        this.LastPanelIndexes.RemoveAll(_0xe2e9d7f6 => _0xe2e9d7f6 == this.CurrentPanelIndex);
        int _0x2ddbe02f = this.LastPanelIndexes.Last();
        this._0x9a362fb1(_0x2ddbe02f);
        this._0x493e614b(_0x2ddbe02f);
        this.CurrentPanelIndex = _0x2ddbe02f;
        this.Panels[_0x2ddbe02f].Show();
    }

    private void _0x9a362fb1(int _0x8ca05b26)
    {
        if (_0x8ca05b26 == _0x545b99d3.SPLASH)
            _0x9ff42d58.Instance._0xabe0e2ea();
        if (_0x0e5ba754.Instance._0xda4a5fc6 == _0xb2d9c6f9.SCENE_0)
        {
        }
    }

    private void Start()
    {
        this._0x6e4c8165();
    }

    public List<_0x47b2eccc> Panels;
    private void _0x6e4c8165()
    {
        this._0x2557d5f0(_0x545b99d3.SPLASH);
        if (_0x0e5ba754.Instance._0xda4a5fc6 == _0xb2d9c6f9.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x9ff42d58.Instance.DefaultAnimationTime);
        }
    }

    private void SwitchSplash()
    {
        if (_0xc991c2b7.Instance.IsTutorialEnabled && !_0x0e5ba754._0xb33a38eb._0x3b8495f3)
            this._0xb591be1b(_0x545b99d3.TUTORIAL0);
        else
            this._0xb591be1b(_0x545b99d3.DEFAULT);
    }

    public float ScaleDuration = 0.4f;
    private void _0x2557d5f0(int _0xdd834ac6)
    {
        this._0x514691e7(_0xdd834ac6);
        this._0x9a362fb1(_0xdd834ac6);
        this.CurrentPanelIndex = _0xdd834ac6;
        this.Panels[_0xdd834ac6]._0xb97301dd();
    }

    public bool IsShowSplashOnStart = true;
    public int CurrentPanelIndex;
    private void _0x514691e7(int _0x854f36cc)
    {
        this.LastPanelIndexes.Add(_0x854f36cc);
        this.CurrentPanelIndex = _0x854f36cc;
        for (int _0x457668d7 = 0; _0x457668d7 < this.Panels.Count; _0x457668d7++)
            if (_0x457668d7 != _0x854f36cc && this.Panels[_0x457668d7] != null)
                this.Panels[_0x457668d7]._0xde663106();
    }

    private void _0x493e614b(int _0xa53328b9)
    {
        this.LastPanelIndexes.Add(_0xa53328b9);
        this.CurrentPanelIndex = _0xa53328b9;
        for (int _0xe103d269 = 0; _0xe103d269 < this.Panels.Count; _0xe103d269++)
            if (_0xe103d269 != _0xa53328b9 && this.Panels[_0xe103d269] != null)
                this.Panels[_0xe103d269]._0xde663106();
    }

    public void _0xb591be1b(int _0xc42f77c2)
    {
        this._0x514691e7(_0xc42f77c2);
        this._0x9a362fb1(_0xc42f77c2);
        this.CurrentPanelIndex = _0xc42f77c2;
        this.Panels[_0xc42f77c2].Show();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x3d672026>();
    }

    private _0x47b2eccc _0xf3e7d81c(int _0x15bac7b6)
    {
        return this.Panels[_0x15bac7b6];
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public static _0x3d672026 Instance;
    public void _0xdf87180f(int _0xbb135d45)
    {
        if (_0xbb135d45 == _0x545b99d3.SPLASH && _0x0e5ba754.Instance._0xda4a5fc6 != _0xb2d9c6f9.SCENE_0)
            _0x9ff42d58.Instance._0xb178dc13();
        if (_0x0e5ba754.Instance._0xda4a5fc6 != _0xb2d9c6f9.SCENE_0)
        {
            if (_0xbb135d45 == _0x545b99d3.SPLASH || _0xbb135d45 == _0x545b99d3.TUTORIAL0)
                _0x0e5ba754.Instance._0x81d24962(false);
            else if (_0xbb135d45 == _0x545b99d3.DEFAULT)
                _0x0e5ba754.Instance._0x81d24962(true);
        }
    }

    public float StaticBlurMaterialInitialValue;
}