using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The layers of one generated button, returned together so a caller can restyle or
/// re-caption it later through references instead of a name lookup.
/// </summary>
public sealed class _0xbf3b76a3
{
    public Image Icon;
    public Image Rim;
    public RectTransform Root;
    public TextMeshProUGUI Caption;
    public Image Fill;
    public Button Button;
}

/// <summary>
/// The glass chrome of the night sky, built at runtime: a soft cyan rim, a dark
/// translucent body and a hard-wrapped label on top. Every label this kit makes has
/// word wrap OFF, autosize ON and a floor well above the readability minimum, so a
/// line breaks only where the string says and never shrinks into illegibility.
/// </summary>
public static class _0xa9e49e33
{
    /// <summary>Thickness of the glass rim around a plate, in canvas pixels.</summary>
    public const float RimPixels = 4f;
    public static Image Block(Transform _0x74e6d347, string _0xdaa3e9b8, Vector2 _0x8de49585, Vector2 _0xb4e17d9b, Vector2 _0x904964cc, Sprite _0xdd7aeaff, Color _0x16d7f8fb)
    {
        RectTransform _0x5153fe99 = Node(_0x74e6d347, _0xdaa3e9b8, _0x8de49585, _0xb4e17d9b, _0x904964cc);
        Image _0xa947dcbe = _0x5153fe99.gameObject.AddComponent<Image>();
        _0xa947dcbe.sprite = _0xdd7aeaff;
        _0xa947dcbe.type = _0xdd7aeaff == null ? Image.Type.Simple : Image.Type.Sliced;
        _0xa947dcbe.color = _0x16d7f8fb;
        _0xa947dcbe.raycastTarget = false;
        return _0xa947dcbe;
    }

    /// <summary>
    /// A glass plate: a cyan rim with a dark translucent body inset inside it. The body
    /// is returned, so anything a caller adds to it is drawn ON TOP of the fill, which
    /// is the sibling order the draw-order rule asks for.
    /// </summary>
    public static RectTransform Plate(Transform _0xcb04882a, string _0xd89bac6a, Vector2 _0xb2ed826b, Vector2 _0xf79d02af, Vector2 _0x4a4e24e7, Sprite _0x94d1e798, Color _0xc35687f3, Color _0xdffa8e46)
    {
        RectTransform _0x731a1220 = Node(_0xcb04882a, _0xd89bac6a, _0xb2ed826b, _0xf79d02af, _0x4a4e24e7);
        Block(_0x731a1220, _0xfdc5c713._0xdf67b60b(new byte[9] { 188, 128, 141, 152, 137, 171, 128, 131, 155 }, 236), new Vector2(0.5f, 0.5f), Vector2.zero, _0x4a4e24e7 + new Vector2(10f, 10f), _0x94d1e798, _0xe65c236a.Fade(_0xdffa8e46, _0xdffa8e46.a * 0.35f));
        Block(_0x731a1220, _0xfdc5c713._0xdf67b60b(new byte[8] { 114, 78, 67, 86, 71, 112, 75, 79 }, 34), new Vector2(0.5f, 0.5f), Vector2.zero, _0x4a4e24e7, _0x94d1e798, _0xdffa8e46);
        Image _0xf0fedf71 = Block(_0x731a1220, _0xfdc5c713._0xdf67b60b(new byte[9] { 148, 168, 165, 176, 161, 134, 171, 160, 189 }, 196), new Vector2(0.5f, 0.5f), Vector2.zero, _0x4a4e24e7 - new Vector2(RimPixels * 2f, RimPixels * 2f), _0x94d1e798, _0xc35687f3);
        return _0xf0fedf71.rectTransform;
    }

    /// <summary>
    /// The splash bar ships white-on-white: the fill is plain white and the track is
    /// white at one part in 255, so nothing reads. Repaint it in the game's own
    /// colours - a bright wind-cyan fill over a deep, genuinely opaque track. The bar's
    /// size is left exactly as the prefab authored it, because shrinking that root is
    /// what collapses the inset Fill Area to nothing.
    /// </summary>
    public static void ThemeSplashSlider()
    {
        _0x9ff42d58 _0xb81aa3ec = _0x9ff42d58.Instance;
        if (_0xb81aa3ec == null)
            return;
        Slider _0x7a1689a9 = _0xb81aa3ec.AnimationSlider;
        if (_0x7a1689a9 == null || _0x7a1689a9.fillRect == null)
            return;
        Image _0xa17537df = _0x7a1689a9.fillRect.GetComponent<Image>();
        if (_0xa17537df != null)
            _0xa17537df.color = _0xe65c236a.Primary;
        Transform _0x39d00b68 = _0x7a1689a9.fillRect.parent;
        Image _0xc8cd8b6b = _0x39d00b68 == null ? null : _0x39d00b68.GetComponent<Image>();
        if (_0xc8cd8b6b != null)
            _0xc8cd8b6b.color = _0xe65c236a.Fade(_0xe65c236a.SurfaceAlt, 0.9f);
    }

    public static Button Cta(Transform _0xabf0a888, string _0x94257fa1, string _0x1c438506, Vector2 _0xf4216b0a, Vector2 _0x858cf583, Vector2 _0x92a2880c, Sprite _0x38ba4fcf, Sprite _0x43b001c7, Color _0xd26b08b5, Color _0xeb305880, Color _0xe077aff2, TMP_FontAsset _0x331642c2, float _0xfcd0cd55)
    {
        return CtaParts(_0xabf0a888, _0x94257fa1, _0x1c438506, _0xf4216b0a, _0x858cf583, _0x92a2880c, _0x38ba4fcf, _0x43b001c7, _0xd26b08b5, _0xeb305880, _0xe077aff2, _0x331642c2, _0xfcd0cd55).Button;
    }

    /// <summary>
    /// A tappable glass button. Children go rim, then fill, then icon, then caption, so
    /// the caption is always the last sibling and can never be covered by its own
    /// plate. The press tint multiplies the FILL rather than the invisible hit layer,
    /// so a press is actually visible.
    /// </summary>
    public static _0xbf3b76a3 CtaParts(Transform _0xb779f60f, string _0x6dd8ebf8, string _0x836a8dbb, Vector2 _0x5eb2af26, Vector2 _0xa5193669, Vector2 _0xc0b74f7f, Sprite _0x81a47a47, Sprite _0x66ec57d1, Color _0x61814fdc, Color _0x7682ce10, Color _0x0543d79a, TMP_FontAsset _0xb4e723dd, float _0xc4bc1f52)
    {
        RectTransform _0xe87abc42 = Node(_0xb779f60f, _0x6dd8ebf8, _0x5eb2af26, _0xa5193669, _0xc0b74f7f);
        _0xbf3b76a3 _0xf769e5c8 = new _0xbf3b76a3();
        _0xf769e5c8.Root = _0xe87abc42;
        Image _0x2809c03e = _0xe87abc42.gameObject.AddComponent<Image>();
        _0x2809c03e.sprite = _0x81a47a47;
        _0x2809c03e.type = _0x81a47a47 == null ? Image.Type.Simple : Image.Type.Sliced;
        _0x2809c03e.color = new Color(1f, 1f, 1f, 0.004f);
        _0x2809c03e.raycastTarget = true;
        _0x2809c03e.canvasRenderer.cullTransparentMesh = false;
        _0xf769e5c8.Rim = Block(_0xe87abc42, _0xfdc5c713._0xdf67b60b(new byte[6] { 116, 67, 86, 101, 94, 90 }, 55), new Vector2(0.5f, 0.5f), Vector2.zero, _0xc0b74f7f, _0x81a47a47, _0x7682ce10);
        _0xf769e5c8.Fill = Block(_0xe87abc42, _0xfdc5c713._0xdf67b60b(new byte[7] { 247, 192, 213, 242, 221, 216, 216 }, 180), new Vector2(0.5f, 0.5f), Vector2.zero, _0xc0b74f7f - new Vector2(RimPixels * 2f, RimPixels * 2f), _0x81a47a47, _0x61814fdc);
        if (_0x66ec57d1 != null)
        {
            _0xf769e5c8.Icon = Block(_0xe87abc42, _0xfdc5c713._0xdf67b60b(new byte[7] { 201, 254, 235, 195, 233, 229, 228 }, 138), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xc0b74f7f.y * 0.5f, _0xc0b74f7f.y * 0.5f), _0x66ec57d1, _0x0543d79a);
            _0xf769e5c8.Icon.type = Image.Type.Simple;
        }

        if (!string.IsNullOrEmpty(_0x836a8dbb))
        {
            _0xf769e5c8.Caption = Label(_0xe87abc42, _0xfdc5c713._0xdf67b60b(new byte[7] { 176, 135, 146, 167, 150, 139, 135 }, 243), _0x836a8dbb, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xc0b74f7f.x - 52f, _0xc0b74f7f.y - 26f), _0xc4bc1f52, _0xc4bc1f52 * 0.78f, _0x0543d79a, _0xb4e723dd, TextAlignmentOptions.Center);
        }

        Button _0x14f2cd8a = _0xe87abc42.gameObject.AddComponent<Button>();
        _0x14f2cd8a.targetGraphic = _0xf769e5c8.Fill != null ? _0xf769e5c8.Fill : (Graphic)_0x2809c03e;
        Tint(_0x14f2cd8a);
        _0xf769e5c8.Button = _0x14f2cd8a;
        return _0xf769e5c8;
    }

    public static TextMeshProUGUI Label(Transform _0x8bb76d17, string _0x5a9efc95, string _0xa243f904, Vector2 _0xad121bf9, Vector2 _0x17b6c692, Vector2 _0xc4d02fbc, float _0x03c64db9, float _0x516179f4, Color _0x5a51ae3e, TMP_FontAsset _0x2c1549b4, TextAlignmentOptions _0xedb783de)
    {
        RectTransform _0x5ca4a15e = Node(_0x8bb76d17, _0x5a9efc95, _0xad121bf9, _0x17b6c692, _0xc4d02fbc);
        TextMeshProUGUI _0xf45234ce = _0x5ca4a15e.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x2c1549b4 != null)
            _0xf45234ce.font = _0x2c1549b4;
        _0xf45234ce.text = _0xa243f904;
        _0xf45234ce.color = _0x5a51ae3e;
        _0xf45234ce.alignment = _0xedb783de;
        _0xf45234ce.raycastTarget = false;
        Wrap(_0xf45234ce, _0x03c64db9, _0x516179f4);
        return _0xf45234ce;
    }

    public static RectTransform Node(Transform _0xe817ff98, string _0x9e4bcdb8, Vector2 _0x99416e86, Vector2 _0x26f1172c, Vector2 _0xf44c12c5)
    {
        GameObject _0xf4c4c905 = new GameObject(_0x9e4bcdb8, typeof(RectTransform));
        _0xf4c4c905.transform.SetParent(_0xe817ff98, false);
        RectTransform _0x7f5a3b7a = _0xf4c4c905.GetComponent<RectTransform>();
        _0x7f5a3b7a.anchorMin = _0x99416e86;
        _0x7f5a3b7a.anchorMax = _0x99416e86;
        _0x7f5a3b7a.pivot = new Vector2(0.5f, 0.5f);
        _0x7f5a3b7a.anchoredPosition = _0x26f1172c;
        _0x7f5a3b7a.sizeDelta = _0xf44c12c5;
        _0x7f5a3b7a.localScale = Vector3.one;
        return _0x7f5a3b7a;
    }

    /// <summary>Smallest size any generated label is allowed to shrink to.</summary>
    public const float LabelFloor = 36f;
    /// <summary>
    /// The scene template ships seven tutorial panels carrying filler copy. This game
    /// explains itself on the board instead, so every one of TUTORIAL0 through
    /// TUTORIAL6 is rewritten here at startup - the panels stay in the pool, because
    /// the controllers address panels by index, but none of them can ever surface the
    /// template's placeholder text.
    /// </summary>
    public static void SanitiseTutorials(TMP_FontAsset _0xce270fb4)
    {
        _0x3d672026 _0x8ba231d9 = _0x3d672026.Instance;
        if (_0x8ba231d9 == null || _0x8ba231d9.Panels == null)
            return;
        int[] _0x4ba53666 =
        {
            _0x47a641fc._0x545b99d3.TUTORIAL0,
            _0x47a641fc._0x545b99d3.TUTORIAL1,
            _0x47a641fc._0x545b99d3.TUTORIAL2,
            _0x47a641fc._0x545b99d3.TUTORIAL3,
            _0x47a641fc._0x545b99d3.TUTORIAL4,
            _0x47a641fc._0x545b99d3.TUTORIAL5,
            _0x47a641fc._0x545b99d3.TUTORIAL6,
        };
        string[] _0x94ba0e7b =
        {
            _0xfdc5c713._0xdf67b60b(new byte[10] { 159, 138, 155, 235, 138, 235, 153, 130, 133, 140 }, 203),
            _0xfdc5c713._0xdf67b60b(new byte[13] { 227, 230, 225, 228, 143, 251, 231, 234, 143, 248, 230, 225, 235 }, 175),
            _0xfdc5c713._0xdf67b60b(new byte[6] { 6, 11, 31, 4, 9, 2 }, 74)
        };
        string[] _0xf0d867f1 =
        {
            _0xfdc5c713._0xdf67b60b(new byte[45] { 158, 154, 152, 147, 251, 143, 154, 139, 251, 143, 142, 137, 149, 136, 251, 143, 147, 154, 143, 251, 137, 146, 149, 156, 209, 148, 149, 158, 251, 136, 158, 152, 143, 148, 137, 251, 152, 151, 148, 152, 144, 140, 146, 136, 158 }, 219),
            _0xfdc5c713._0xdf67b60b(new byte[54] { 77, 70, 79, 71, 64, 46, 90, 70, 75, 46, 79, 92, 92, 65, 89, 93, 46, 72, 92, 65, 67, 46, 90, 70, 75, 46, 94, 79, 74, 4, 90, 70, 92, 65, 91, 73, 70, 46, 75, 88, 75, 92, 87, 46, 73, 65, 66, 74, 46, 77, 66, 65, 91, 74 }, 14),
            _0xfdc5c713._0xdf67b60b(new byte[39] { 109, 122, 99, 101, 104, 12, 120, 100, 105, 12, 127, 120, 99, 126, 97, 127, 12, 109, 98, 104, 38, 126, 105, 109, 111, 100, 12, 120, 100, 105, 12, 127, 103, 117, 12, 107, 109, 120, 105 }, 44),
        };
        for (int _0xeb555bee = 0; _0xeb555bee < _0x4ba53666.Length; _0xeb555bee++)
        {
            int _0xfed3dbdf = _0x4ba53666[_0xeb555bee];
            if (_0xfed3dbdf < 0 || _0xfed3dbdf >= _0x8ba231d9.Panels.Count)
                continue;
            _0x47b2eccc _0x0575dbd4 = _0x8ba231d9.Panels[_0xfed3dbdf];
            if (_0x0575dbd4 == null || _0x0575dbd4.Content == null)
                continue;
            TMP_Text[] _0xe9eee0c7 = _0x0575dbd4.Content.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x5211bbb8 = 0; _0x5211bbb8 < _0xe9eee0c7.Length; _0x5211bbb8++)
            {
                if (_0xe9eee0c7[_0x5211bbb8] == null)
                    continue;
                string _0x174e8d7d = string.Empty;
                if (_0x5211bbb8 == 0 && _0xeb555bee < _0x94ba0e7b.Length)
                    _0x174e8d7d = _0x94ba0e7b[_0xeb555bee];
                else if (_0x5211bbb8 == 1 && _0xeb555bee < _0xf0d867f1.Length)
                    _0x174e8d7d = _0xf0d867f1[_0xeb555bee];
                _0xe9eee0c7[_0x5211bbb8].text = _0x174e8d7d;
                _0xe9eee0c7[_0x5211bbb8].color = _0x5211bbb8 == 0 ? _0xe65c236a.Gold : _0xe65c236a.TextPrimary;
                if (_0xce270fb4 != null)
                    _0xe9eee0c7[_0x5211bbb8].font = _0xce270fb4;
                Wrap(_0xe9eee0c7[_0x5211bbb8], _0x5211bbb8 == 0 ? 72f : 48f, _0x5211bbb8 == 0 ? 56f : 40f);
            }
        }
    }

    /// <summary>A RectTransform stretched over the whole of its parent.</summary>
    public static RectTransform Stretch(Transform _0x95d3a20b, string _0x42514900)
    {
        GameObject _0x68cbbd43 = new GameObject(_0x42514900, typeof(RectTransform));
        _0x68cbbd43.transform.SetParent(_0x95d3a20b, false);
        RectTransform _0xf34cc22d = _0x68cbbd43.GetComponent<RectTransform>();
        _0xf34cc22d.anchorMin = Vector2.zero;
        _0xf34cc22d.anchorMax = Vector2.one;
        _0xf34cc22d.pivot = new Vector2(0.5f, 0.5f);
        _0xf34cc22d.anchoredPosition = Vector2.zero;
        _0xf34cc22d.sizeDelta = Vector2.zero;
        _0xf34cc22d.localScale = Vector3.one;
        return _0xf34cc22d;
    }

    /// <summary>
    /// Word wrap off, autosize on, floor never below the readable minimum. Line breaks
    /// belong in the string as explicit newlines, so the same copy lays out identically
    /// on every screen.
    /// </summary>
    public static void Wrap(TMP_Text _0xa9e260f6, float _0x0bd3715c, float _0x5258c8ea)
    {
        if (_0xa9e260f6 == null)
            return;
        float _0x1df9e3b3 = Mathf.Max(LabelFloor, _0x5258c8ea);
        _0xa9e260f6.enableWordWrapping = false;
        _0xa9e260f6.overflowMode = TextOverflowModes.Overflow;
        _0xa9e260f6.enableAutoSizing = true;
        _0xa9e260f6.fontSizeMax = Mathf.Max(_0x1df9e3b3, _0x0bd3715c);
        _0xa9e260f6.fontSizeMin = _0x1df9e3b3;
    }

    /// <summary>A press state that reads on a dark glass fill.</summary>
    public static void Tint(Button _0x7f636636)
    {
        if (_0x7f636636 == null)
            return;
        ColorBlock _0x54c94d68 = _0x7f636636.colors;
        _0x54c94d68.normalColor = Color.white;
        _0x54c94d68.highlightedColor = Color.white;
        _0x54c94d68.pressedColor = new Color(0.62f, 0.78f, 0.86f, 1f);
        _0x54c94d68.selectedColor = Color.white;
        _0x54c94d68.disabledColor = new Color(0.42f, 0.46f, 0.56f, 0.8f);
        _0x54c94d68.colorMultiplier = 1f;
        _0x54c94d68.fadeDuration = 0.07f;
        _0x7f636636.colors = _0x54c94d68;
    }
}

internal static class _0xfdc5c713
{
    internal static string _0xdf67b60b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}