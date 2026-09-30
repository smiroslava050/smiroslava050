using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The menu screen. It dresses the splash bar, clears the template's filler copy out
/// of the tutorial pool, and raises the menu itself inside the panel the controllers
/// already manage: the abstract mark, the objective line, the sky map rail, the miles
/// the player has banked and the PLAY control.
///
/// The PLAY control is the template's own button - it is found by the scene-loading
/// driver it carries, never by name - so there is exactly one button in that slot and
/// it keeps the wiring the template shipped.
/// </summary>
public sealed class _0xdd77c5f8 : MonoBehaviour
{
    /// <summary>
    /// The brand mark: three arcs and a wind arrow, turning slowly. It is a symbol, not
    /// a word - the game's name appears on no screen in this app.
    /// </summary>
    private void _0x81d40520(Transform _0xe51f6242)
    {
        RectTransform _0x0bb4e1c1 = _0xa9e49e33.Node(_0xe51f6242, _0xe04ec864._0x70dadf4e(new byte[7] { 207, 247, 229, 209, 253, 238, 247 }, 156), new Vector2(0.5f, MarkRow), Vector2.zero, new Vector2(300f, 300f));
        Image _0xd458ea38 = _0xa9e49e33.Block(_0x0bb4e1c1, _0xe04ec864._0x70dadf4e(new byte[8] { 54, 26, 9, 16, 60, 23, 20, 12 }, 123), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(340f, 340f), this._plate, _0xe65c236a.Fade(_0xe65c236a.Secondary, 0.22f));
        _0xd458ea38.type = Image.Type.Sliced;
        Image _0x97dc815b = _0xa9e49e33.Block(_0x0bb4e1c1, _0xe04ec864._0x70dadf4e(new byte[8] { 151, 187, 168, 177, 155, 168, 185, 169 }, 218), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(300f, 300f), this._emblem, Color.white);
        _0x97dc815b.type = Image.Type.Simple;
        _0x97dc815b.preserveAspect = true;
        _0x97dc815b.transform.localScale = Vector3.one * 0.86f;
        _0x97dc815b.transform.DOScale(1f, 0.55f).SetEase(Ease.OutBack);
        _0x97dc815b.transform.DOLocalRotate(new Vector3(0f, 0f, -360f), 10f, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        _0xd458ea38.transform.DOScale(1.06f, 1.8f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    private void Start()
    {
        _0xa9e49e33.ThemeSplashSlider();
        _0xa9e49e33.SanitiseTutorials(this._font);
        Transform _0x6b3c7e5f = MenuHost();
        if (_0x6b3c7e5f == null)
            return;
        int _0x53c8e4ff = Mathf.Max(0, _0x0e5ba754._0xb33a38eb._0x61dc61e0);
        this._0x31f40078(_0x6b3c7e5f);
        this._0x81d40520(_0x6b3c7e5f);
        _0xa9e49e33.Label(_0x6b3c7e5f, _0xe04ec864._0x70dadf4e(new byte[9] { 72, 101, 109, 98, 100, 115, 110, 113, 98 }, 7), _0xe04ec864._0x70dadf4e(new byte[19] { 0, 5, 2, 7, 108, 24, 4, 9, 108, 27, 5, 2, 8, 108, 30, 5, 2, 11, 31 }, 76), new Vector2(0.5f, ObjectiveRow), Vector2.zero, new Vector2(1060f, 96f), 52f, 40f, _0xe65c236a.TextPrimary, this._font, TextAlignmentOptions.Center);
        if (this._rail != null)
            this._rail._0xee0b7663(_0x6b3c7e5f, RailRow, _0x53c8e4ff);
        _0xa9e49e33.Label(_0x6b3c7e5f, _0xe04ec864._0x70dadf4e(new byte[8] { 160, 136, 131, 152, 165, 132, 131, 153 }, 237), _0xe04ec864._0x70dadf4e(new byte[40] { 88, 77, 92, 44, 94, 69, 66, 75, 95, 32, 44, 64, 69, 66, 73, 44, 89, 92, 44, 88, 68, 73, 44, 91, 69, 66, 72, 32, 6, 88, 68, 73, 66, 44, 64, 77, 89, 66, 79, 68 }, 12), new Vector2(0.5f, HintRow), Vector2.zero, new Vector2(1060f, 120f), 40f, 36f, _0xe65c236a.TextSecondary, this._font, TextAlignmentOptions.Center);
        this._0xaa514780(_0x6b3c7e5f);
    }

    private const float RailRow = 0.52f;
    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private Sprite _emblem;
    [SerializeField]
    private TMP_FontAsset _font;
    /// <summary>
    /// The menu panel, addressed by index like every panel in this project. Content is
    /// raised inside it so the template's own show and hide carry the menu with them.
    /// </summary>
    private static Transform MenuHost()
    {
        _0x3d672026 _0x99a41226 = _0x3d672026.Instance;
        if (_0x99a41226 == null || _0x99a41226.Panels == null)
            return null;
        int _0xff313270 = _0x47a641fc._0x545b99d3.DEFAULT;
        if (_0xff313270 < 0 || _0xff313270 >= _0x99a41226.Panels.Count)
            return null;
        _0x47b2eccc _0x9edd06a5 = _0x99a41226.Panels[_0xff313270];
        if (_0x9edd06a5 == null || _0x9edd06a5.Content == null)
            return null;
        return _0x9edd06a5.Content.transform;
    }

    private const float MilesRow = 0.94f;
    /// <summary>
    /// The banked score, read from the same store the template's own counters read, so
    /// the menu and the result cards can never disagree about it.
    /// </summary>
    private void _0x31f40078(Transform _0x511e4ccb)
    {
        RectTransform _0x6308cbe4 = _0xa9e49e33.Plate(_0x511e4ccb, _0xe04ec864._0x70dadf4e(new byte[9] { 173, 137, 140, 133, 147, 176, 137, 140, 140 }, 224), new Vector2(0.5f, MilesRow), Vector2.zero, new Vector2(520f, 122f), this._plate, _0xe65c236a.Fade(_0xe65c236a.Surface, 0.7f), _0xe65c236a.Fade(_0xe65c236a.Gold, 0.4f));
        _0xa9e49e33.Label(_0x6308cbe4, _0xe04ec864._0x70dadf4e(new byte[12] { 21, 49, 52, 61, 43, 27, 57, 40, 44, 49, 55, 54 }, 88), _0xe04ec864._0x70dadf4e(new byte[5] { 94, 90, 95, 86, 64 }, 19), new Vector2(0.5f, 0.74f), Vector2.zero, new Vector2(460f, 44f), 36f, 36f, _0xe65c236a.TextSecondary, this._font, TextAlignmentOptions.Center);
        TextMeshProUGUI _0x81c7d624 = _0xa9e49e33.Label(_0x6308cbe4, _0xe04ec864._0x70dadf4e(new byte[10] { 108, 72, 77, 68, 82, 119, 64, 77, 84, 68 }, 33), _0x47a641fc._0x44cfec3f._0x678a3800.ToString(), new Vector2(0.5f, 0.32f), Vector2.zero, new Vector2(460f, 66f), 56f, 40f, _0xe65c236a.Gold, this._font, TextAlignmentOptions.Center);
        _0x81c7d624.transform.localScale = Vector3.one * 0.9f;
        _0x81c7d624.transform.DOScale(1f, 0.35f).SetEase(Ease.OutBack);
    }

    /// <summary>
    /// Dress the template's play button: hide the layers it ships with no sprite (Unity
    /// draws those as white slabs), lay this game's plate over them and put the caption
    /// on last so nothing can cover it. Geometry is left exactly as the scene authored
    /// it - the size lives in the scene file, not in code.
    /// </summary>
    private void _0xaa514780(Transform _0x630e4811)
    {
        _0x00623c01[] _0xf60593cc = _0x630e4811.GetComponentsInChildren<_0x00623c01>(true);
        GameObject _0xc309e149 = null;
        for (int _0x0a4c6571 = 0; _0x0a4c6571 < _0xf60593cc.Length; _0x0a4c6571++)
        {
            if (_0xf60593cc[_0x0a4c6571] == null || _0xf60593cc[_0x0a4c6571].IsLoadCurrentScene)
                continue;
            if (_0xf60593cc[_0x0a4c6571].LoadSceneId != _0x47a641fc._0xb2d9c6f9.SCENE_1)
                continue;
            _0xc309e149 = _0xf60593cc[_0x0a4c6571].gameObject;
            break;
        }

        if (_0xc309e149 == null)
            return;
        Image[] _0x5fc44fea = _0xc309e149.GetComponentsInChildren<Image>(true);
        for (int _0xf67bb9b0 = 0; _0xf67bb9b0 < _0x5fc44fea.Length; _0xf67bb9b0++)
        {
            if (_0x5fc44fea[_0xf67bb9b0] != null && _0x5fc44fea[_0xf67bb9b0].sprite == null)
                _0x5fc44fea[_0xf67bb9b0].color = _0xe65c236a.Fade(_0xe65c236a.Primary, 0f);
        }

        RectTransform _0x72da09cf = _0xc309e149.GetComponent<RectTransform>();
        if (_0x72da09cf == null)
            return;
        Vector2 _0x9174dd53 = _0x72da09cf.sizeDelta;
        if (_0x9174dd53.x < 200f || _0x9174dd53.y < 80f)
            _0x9174dd53 = new Vector2(760f, 168f);
        _0xa9e49e33.Block(_0x72da09cf, _0xe04ec864._0x70dadf4e(new byte[7] { 6, 58, 55, 47, 4, 63, 59 }, 86), new Vector2(0.5f, 0.5f), Vector2.zero, _0x9174dd53, this._plate, _0xe65c236a.Fade(_0xe65c236a.Primary, 0.9f));
        _0xa9e49e33.Block(_0x72da09cf, _0xe04ec864._0x70dadf4e(new byte[8] { 215, 235, 230, 254, 193, 238, 235, 235 }, 135), new Vector2(0.5f, 0.5f), Vector2.zero, _0x9174dd53 - new Vector2(8f, 8f), this._plate, _0xe65c236a.Primary);
        _0xa9e49e33.Label(_0x72da09cf, _0xe04ec864._0x70dadf4e(new byte[8] { 190, 130, 143, 151, 186, 139, 150, 154 }, 238), _0xe04ec864._0x70dadf4e(new byte[4] { 17, 13, 0, 24 }, 65), new Vector2(0.5f, 0.5f), Vector2.zero, _0x9174dd53 - new Vector2(70f, 40f), 68f, 48f, _0xe65c236a.Ink, this._font, TextAlignmentOptions.Center);
        _0x72da09cf.localScale = Vector3.one * 0.9f;
        _0x72da09cf.DOScale(1f, 0.3f).SetDelay(0.45f).SetEase(Ease.OutBack);
    }

    private const float ObjectiveRow = 0.685f;
    private const float HintRow = 0.205f;
    [SerializeField]
    private _0x44c55eee _rail;
    private const float MarkRow = 0.8f;
}

internal static class _0xe04ec864
{
    internal static string _0x70dadf4e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}