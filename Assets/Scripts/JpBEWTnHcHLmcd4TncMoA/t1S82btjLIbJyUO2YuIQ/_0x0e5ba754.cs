using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x47a641fc;

public class _0x0e5ba754 : MonoBehaviour
{
    public void LoadSceneByIndex(int _0x5a353ad0)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xefc28220(_0x5a353ad0));
    }

    public void _0x81d24962(bool _0xbf378a58)
    {
        this._0x53738293 = _0xbf378a58;
        this._0x52c3b16f(!this._0x53738293);
        Physics2D.simulationMode = this._0x53738293 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xfa8e6257(this.EnvironmentWithTweensToToggle);
    }

    public int _0xda4a5fc6 => SceneManager.GetActiveScene().buildIndex;

    private static void MakeGrid(List<RectTransform> _0xcd17b2e9, AspectRatioFitter _0x9c3de169, float _0x74f0d8f8, int _0xa3822896, int _0x3e8f7759)
    {
        _0x9c3de169.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x9c3de169.aspectRatio = _0x74f0d8f8;
        foreach (RectTransform _0x51f952a3 in _0xcd17b2e9)
        {
            int _0xe63f736d = _0x51f952a3.transform.GetSiblingIndex();
            _0x51f952a3.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xe63f736d % _0xa3822896) * (1f / _0xa3822896), (_0x3e8f7759 - (Mathf.FloorToInt((float)_0xe63f736d / _0xa3822896) % _0x3e8f7759 + 1f)) * (1f / _0x3e8f7759));
            _0x51f952a3.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xe63f736d % _0xa3822896 + 1f) * (1f / _0xa3822896), (_0x3e8f7759 - Mathf.FloorToInt((float)_0xe63f736d / _0xa3822896) % _0x3e8f7759) * (1f / _0x3e8f7759));
            _0x51f952a3.offsetMin = Vector2.zero;
            _0x51f952a3.offsetMax = Vector2.zero;
        }
    }

    private void _0xfa8e6257(Transform _0x81656b61)
    {
        Transform[] _0x12f0cec1 = _0x81656b61.GetComponentsInChildren<Transform>();
        foreach (Transform _0x1ea5e853 in _0x12f0cec1)
            if (_0x1ea5e853 != null && DOTween.IsTweening(_0x1ea5e853))
            {
                if (this._0x53738293)
                    DOTween.Play(_0x1ea5e853);
                else
                    DOTween.Pause(_0x1ea5e853);
            }
    }

    [HideInInspector]
    public List<_0x6eb663d4> MoneyCountContainers = new();
    public static bool IsAfterLevelComplete;
    public Canvas MainCanvas;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x0e5ba754>();
        this.RootGameObject = GameObject.FindWithTag(_0x9db45152._0x9a1cb562(new byte[4] { 10, 55, 55, 44 }, 88));
        if (this._0xda4a5fc6 == _0xb2d9c6f9.SCENE_0)
            this._0x81d24962(true);
        else
            this._0x81d24962(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x6eb663d4>(true).ToList();
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public void _0x290fbd7d()
    {
        foreach (_0x6eb663d4 _0xba519eaa in this.MoneyCountContainers)
            _0xba519eaa._0xb8e7d9eb();
    }

    private static _0x1cbd8167 GAME_INDEX_SETTINGS(int _0x1abb1f90)
    {
        return _0x1cbd8167.ALL_SCENES_SETTING_SINGLETONS[_0x1abb1f90];
    }

    private void Start()
    {
        if (this._0xda4a5fc6 != _0xb2d9c6f9.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0xb2d9c6f9.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xb33a38eb._0x3b8495f3 = false;
            _0xc1be6679.Instance._0xed679dda();
            _0x3d672026.Instance._0xb591be1b(_0x545b99d3.TUTORIAL0);
        });
    }

    public Button ShowResetTutorialButton;
    public static _0x1cbd8167 _0xb33a38eb => _0x1cbd8167.ALL_SCENES_SETTING_SINGLETONS[Instance._0xda4a5fc6];

    private void _0x94db3d56()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0xb2d9c6f9.SCENE_0);
    }

    public Transform Environment;
    public void _0x5e9d8cf9()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public static bool IsAfterLevelFailed = false;
    public bool _0x53738293 { get; private set; }

    public Button DeleteProgressDataButton;
    public Transform EnvironmentWithTweensToToggle;
    private static void ExitGame()
    {
        Application.Quit();
    }

    private void _0x52c3b16f(bool _0x614cea69)
    {
        Rigidbody2D[] _0x3c004f5b = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x71632a3a in _0x3c004f5b)
            if (_0x614cea69)
                _0x71632a3a.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x71632a3a.constraints = RigidbodyConstraints2D.None;
    }

    public void _0x31023a53()
    {
        _0xb33a38eb._0x3b8495f3 = true;
    }

    private IEnumerator _0xefc28220(int _0xd31805d1)
    {
        _0x3d672026.Instance._0xb591be1b(_0x545b99d3.SPLASH);
        AsyncOperation _0xc7893d09 = SceneManager.LoadSceneAsync(_0xd31805d1);
        while (!_0xc7893d09.isDone)
            yield return null;
    }

    public static _0x0e5ba754 Instance;
    private static _0x1cbd8167 _0xe3d2fc23 => _0x1cbd8167.ALL_SCENES_SETTING_SINGLETONS[0];

    private IEnumerator _0x6a645e75(string _0x7309a1b1)
    {
        _0x3d672026.Instance._0xb591be1b(_0x545b99d3.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x60545927 = SceneManager.LoadSceneAsync(_0x7309a1b1);
        while (!_0x60545927.isDone)
            yield return null;
    }
}

internal static class _0x9db45152
{
    internal static string _0x9a1cb562(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}