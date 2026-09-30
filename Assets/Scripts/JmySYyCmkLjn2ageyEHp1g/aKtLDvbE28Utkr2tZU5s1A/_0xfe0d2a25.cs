using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xfe0d2a25 : MonoBehaviour
{
    private static ScreenOrientation _0xc674e019 = ScreenOrientation.LandscapeLeft;
    private static void OrientationChanged()
    {
        _0xc674e019 = Screen.orientation;
        _0x5eef3592.x = Screen.width;
        _0x5eef3592.y = Screen.height;
        _0xceb43eab = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x9ec41077.Invoke();
    }

    private RectTransform _0x205fb03d;
    private static void SafeAreaChanged()
    {
        _0xceb43eab = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static Vector2 _0x5eef3592 = Vector2.zero;
    private void Start()
    {
    }

    private void _0x4aa42596()
    {
        if (this._0x205fb03d == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x0eef2733 = Screen.safeArea;
        Vector2 _0x77133d98 = _0x0eef2733.position;
        Vector2 _0xc8939358 = _0x0eef2733.position + _0x0eef2733.size;
        _0x77133d98.x /= screenWidth;
        _0x77133d98.y /= screenHeight;
        _0xc8939358.x /= screenWidth;
        _0xc8939358.y /= screenHeight;
        this._0x205fb03d.anchorMin = _0x77133d98;
        this._0x205fb03d.anchorMax = _0xc8939358;
        this._0x205fb03d.offsetMin = Vector2.zero;
        this._0x205fb03d.offsetMax = Vector2.zero;
        if (this._0x569aebf1 == null)
            return;
        Vector2 _0xbb0c7906 = _0xc8939358 - _0x77133d98;
        float _0x2add14d6 = 2f - _0xbb0c7906.x;
        float _0xc1fd9344 = 2f - _0xbb0c7906.y;
        this._0x569aebf1.referenceResolution = this._0xf061eaf8 * new Vector2(_0x2add14d6, _0xc1fd9344);
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x0e1088b6 = 0; _0x0e1088b6 < _0x62b36045.Count; _0x0e1088b6++)
            _0x62b36045[_0x0e1088b6]._0x4aa42596();
    }

    private void Awake()
    {
        if (!_0x62b36045.Contains(this))
            _0x62b36045.Add(this);
        this._0x2c28c8c8 = this.GetComponent<Canvas>();
        this._0x569aebf1 = this.GetComponent<CanvasScaler>();
        if (this._0x569aebf1 != null)
            this._0xf061eaf8 = this._0x569aebf1.referenceResolution;
        this._0x0b8c0335 = this.GetComponent<RectTransform>();
        this._0x205fb03d = this.transform.Find(_0x4626183c._0x9fa4524c(new byte[8] { 177, 131, 132, 135, 163, 144, 135, 131 }, 226)) as RectTransform;
        if (!_0xef4552cf)
        {
            _0xc674e019 = Screen.orientation;
            _0x5eef3592.x = Screen.width;
            _0x5eef3592.y = Screen.height;
            _0xceb43eab = Screen.safeArea;
            _0xef4552cf = true;
        }

        this._0x4aa42596();
    }

    private static readonly List<_0xfe0d2a25> _0x62b36045 = new();
    private CanvasScaler _0x569aebf1;
    private static Rect _0xceb43eab = Rect.zero;
    private Canvas _0x2c28c8c8;
    private void OnDestroy()
    {
        if (_0x62b36045 != null && _0x62b36045.Contains(this))
            _0x62b36045.Remove(this);
    }

    private void Update()
    {
        if (_0x62b36045.Count == 0 || _0x62b36045[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xc674e019)
            OrientationChanged();
        if (Screen.safeArea != _0xceb43eab)
            SafeAreaChanged();
        if (Screen.width != _0x5eef3592.x || Screen.height != _0x5eef3592.y)
            ResolutionChanged();
    }

    private static void ResolutionChanged()
    {
        _0x5eef3592.x = Screen.width;
        _0x5eef3592.y = Screen.height;
        _0xceb43eab = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x9ec41077.Invoke();
    }

    private RectTransform _0x0b8c0335;
    private static bool _0xef4552cf;
    private Vector2 _0xf061eaf8;
    private static UnityEvent _0x9ec41077 = new();
}

internal static class _0x4626183c
{
    internal static string _0x9fa4524c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}