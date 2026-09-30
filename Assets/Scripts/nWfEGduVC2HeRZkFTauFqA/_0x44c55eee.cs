using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The sky map on the menu: a short rail of route nodes showing what has been flown,
/// what is next and what is still shut. It always shows a window around the current
/// route, so route forty reads as clearly as route two, and it says so in words when
/// there is nothing to show at all rather than leaving a hole in the screen.
/// </summary>
public sealed class _0x44c55eee : MonoBehaviour
{
    [SerializeField]
    private Sprite _cloudSprite;
    private const float RailHeight = 320f;
    private const float NodeStep = 148f;
    [SerializeField]
    private TMP_FontAsset _font;
    /// <summary>Raise the rail under <paramref name = "host"/> at a given anchor height.</summary>
    public void _0xee0b7663(Transform _0x040da9d5, float _0x5cc890b1, int _0xda09a9e2)
    {
        if (_0x040da9d5 == null)
            return;
        RectTransform _0x3dc68400 = _0xa9e49e33.Node(_0x040da9d5, _0xfe30d76a._0xd1559c80(new byte[10] { 85, 109, 127, 75, 103, 118, 84, 103, 111, 106 }, 6), new Vector2(0.5f, _0x5cc890b1), Vector2.zero, new Vector2(_0xd896e65b.RailCapacity * NodeStep, RailHeight));
        if (_0xda09a9e2 < 0)
        {
            _0xa9e49e33.Label(_0x3dc68400, _0xfe30d76a._0xd1559c80(new byte[9] { 196, 247, 255, 250, 211, 251, 230, 226, 239 }, 150), _0xfe30d76a._0xd1559c80(new byte[25] { 204, 195, 216, 217, 222, 170, 216, 197, 223, 222, 207, 170, 197, 218, 207, 196, 217, 170, 197, 196, 170, 218, 198, 203, 211 }, 138), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xd896e65b.RailCapacity * NodeStep, 80f), 44f, 36f, _0xe65c236a.TextSecondary, this._font, TextAlignmentOptions.Center);
            return;
        }

        int _0xb0289235 = Mathf.Max(0, _0xda09a9e2 - 3);
        _0xa9e49e33.Block(_0x3dc68400, _0xfe30d76a._0xd1559c80(new byte[8] { 171, 152, 144, 149, 181, 144, 151, 156 }, 249), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2((_0xd896e65b.RailCapacity - 1) * NodeStep, 6f), this._plate, _0xe65c236a.Fade(_0xe65c236a.Secondary, 0.45f));
        float _0xf092add7 = (_0xd896e65b.RailCapacity - 1) * NodeStep;
        for (int _0xb967f630 = 0; _0xb967f630 < _0xd896e65b.RailCapacity; _0xb967f630++)
        {
            int _0x1846617a = _0xb0289235 + _0xb967f630;
            float _0x56738e16 = -_0xf092add7 * 0.5f + _0xb967f630 * NodeStep;
            this.Node(_0x3dc68400, new Vector2(_0x56738e16, 0f), _0x1846617a, _0x1846617a < _0xda09a9e2, _0x1846617a == _0xda09a9e2, _0xb967f630);
        }
    }

    private const float NodeSize = 116f;
    /// <summary>One node of the rail in one of its three states.</summary>
    private void Node(Transform _0x0533a41d, Vector2 _0xaf5873ad, int _0x7b0b7687, bool _0x386d1488, bool _0x1a04e906, int _0x0f6168cc)
    {
        Color _0x52566084 = _0x386d1488 ? _0xe65c236a.Gold : _0xe65c236a.Fade(_0xe65c236a.SurfaceAlt, 0.72f);
        Color _0x75ab7c7f = _0x1a04e906 ? _0xe65c236a.Primary : _0xe65c236a.Fade(_0xe65c236a.Secondary, 0.4f);
        RectTransform _0x0617c0b7 = _0xa9e49e33.Node(_0x0533a41d, _0xfe30d76a._0xd1559c80(new byte[9] { 169, 148, 142, 143, 158, 181, 148, 159, 158 }, 251), new Vector2(0.5f, 0.5f), _0xaf5873ad, new Vector2(NodeSize, NodeSize));
        Image _0x444290a5 = _0xa9e49e33.Block(_0x0617c0b7, _0xfe30d76a._0xd1559c80(new byte[8] { 52, 21, 30, 31, 62, 19, 9, 25 }, 122), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(NodeSize, NodeSize), this._nodeSprite, _0x75ab7c7f);
        _0x444290a5.type = Image.Type.Simple;
        Image _0x54389bca = _0xa9e49e33.Block(_0x0617c0b7, _0xfe30d76a._0xd1559c80(new byte[8] { 167, 134, 141, 140, 170, 134, 155, 140 }, 233), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(NodeSize - 14f, NodeSize - 14f), this._nodeSprite, _0x52566084);
        _0x54389bca.type = Image.Type.Simple;
        if (_0x386d1488 && this._cloudSprite != null)
        {
            Image _0xb6619f8d = _0xa9e49e33.Block(_0x0617c0b7, _0xfe30d76a._0xd1559c80(new byte[9] { 187, 154, 145, 144, 182, 153, 154, 128, 145 }, 245), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(54f, 38f), this._cloudSprite, _0xe65c236a.Ink);
            _0xb6619f8d.type = Image.Type.Simple;
            _0xb6619f8d.preserveAspect = true;
        }
        else
        {
            _0xa9e49e33.Label(_0x0617c0b7, _0xfe30d76a._0xd1559c80(new byte[8] { 37, 4, 15, 14, 63, 14, 19, 31 }, 107), (_0x7b0b7687 + 1).ToString(), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(NodeSize - 22f, NodeSize - 30f), 44f, 36f, _0x1a04e906 ? _0xe65c236a.TextPrimary : _0xe65c236a.TextMuted, this._font, TextAlignmentOptions.Center);
        }

        _0x0617c0b7.localScale = Vector3.zero;
        _0x0617c0b7.DOScale(1f, 0.22f).SetDelay(0.18f + _0x0f6168cc * 0.05f).SetEase(Ease.OutBack);
        if (_0x1a04e906)
            _0x0617c0b7.DOScale(1.08f, 0.9f).SetDelay(0.5f + _0x0f6168cc * 0.05f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    [SerializeField]
    private Sprite _nodeSprite;
    [SerializeField]
    private Sprite _plate;
}

internal static class _0xfe30d76a
{
    internal static string _0xd1559c80(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}