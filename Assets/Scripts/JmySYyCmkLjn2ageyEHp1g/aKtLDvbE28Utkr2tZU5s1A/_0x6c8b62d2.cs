using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x6c8b62d2 : MonoBehaviour
{
    private static void ResolutionChanged()
    {
        _0xaebda63b.x = Screen.width;
        _0xaebda63b.y = Screen.height;
        _0x2ce28e33.Invoke();
    }

    private void _0x45942335()
    {
        if (this._0x0524cd25 == null)
            return;
        Rect _0x97865a17 = Screen.safeArea;
        Vector2 _0xaba228bc = _0x97865a17.position;
        Vector2 _0x3f2c3482 = _0x97865a17.position + _0x97865a17.size;
        _0xaba228bc.x /= this._0x7fdef4b7.pixelRect.width;
        _0xaba228bc.y /= this._0x7fdef4b7.pixelRect.height;
        _0x3f2c3482.x /= this._0x7fdef4b7.pixelRect.width;
        _0x3f2c3482.y /= this._0x7fdef4b7.pixelRect.height;
        this._0x0524cd25.anchorMin = _0xaba228bc;
        this._0x0524cd25.anchorMax = _0x3f2c3482;
    }

    private static void SafeAreaChanged()
    {
        _0xc763acfb = Screen.safeArea;
        for (int _0x4b53fa56 = 0; _0x4b53fa56 < _0x7e8d823e.Count; _0x4b53fa56++)
            _0x7e8d823e[_0x4b53fa56]._0x45942335();
    }

    private static Rect _0xc763acfb = Rect.zero;
    private Canvas _0x7fdef4b7;
    private void OnDestroy()
    {
        if (_0x7e8d823e != null && _0x7e8d823e.Contains(this))
            _0x7e8d823e.Remove(this);
    }

    private static ScreenOrientation _0xb311b961 = ScreenOrientation.LandscapeLeft;
    private static void OrientationChanged()
    {
        _0xb311b961 = Screen.orientation;
        _0xaebda63b.x = Screen.width;
        _0xaebda63b.y = Screen.height;
        _0x2ce28e33.Invoke();
    }

    private RectTransform _0x0524cd25;
    private RectTransform _0xc0cfabc3;
    private static UnityEvent _0x2ce28e33 = new();
    private void Awake()
    {
        if (!_0x7e8d823e.Contains(this))
            _0x7e8d823e.Add(this);
        this._0x7fdef4b7 = this.GetComponent<Canvas>();
        this._0xc0cfabc3 = this.GetComponent<RectTransform>();
        this._0x0524cd25 = this.transform.Find(_0x0f915583._0xd2ba723f(new byte[8] { 208, 226, 229, 230, 194, 241, 230, 226 }, 131)) as RectTransform;
        if (!_0x158a29a1)
        {
            _0xb311b961 = Screen.orientation;
            _0xaebda63b.x = Screen.width;
            _0xaebda63b.y = Screen.height;
            _0xc763acfb = Screen.safeArea;
            _0x158a29a1 = true;
        }

        this._0x45942335();
    }

    private static readonly List<_0x6c8b62d2> _0x7e8d823e = new();
    private void Update()
    {
        if (_0x7e8d823e[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xb311b961)
            OrientationChanged();
        if (Screen.safeArea != _0xc763acfb)
            SafeAreaChanged();
        if (Screen.width != _0xaebda63b.x || Screen.height != _0xaebda63b.y)
            ResolutionChanged();
    }

    private static Vector2 _0xaebda63b = Vector2.zero;
    private static bool _0x158a29a1;
}

internal static class _0x0f915583
{
    internal static string _0xd2ba723f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}