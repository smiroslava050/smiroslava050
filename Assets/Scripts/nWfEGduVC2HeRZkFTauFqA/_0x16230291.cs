using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The chrome of the board screen, built from this game's own objects rather than the
/// template's placeholder HUD: three glass readouts across the top, a back and a pause
/// slot beside them, the control hint, and the LAUNCH button. Everything is created
/// under the panel the controllers already show and hide, so it appears and leaves
/// with the rest of the screen.
/// </summary>
public sealed class _0x16230291 : MonoBehaviour
{
    private TextMeshProUGUI _0xffc626ac;
    /// <summary>
    /// A round icon slot in the top bar. The two of them are the only navigation this
    /// screen has, and they are built here rather than borrowed from the template, so
    /// the panel carries one consistent set of buttons.
    /// </summary>
    private void Chrome(Transform _0x1d3747dc, Vector2 _0x6752ee59, Sprite _0x36c49e16, bool _0x9563f057)
    {
        _0xbf3b76a3 _0xa9834d06 = _0xa9e49e33.CtaParts(_0x1d3747dc, _0x9563f057 ? _0xa0c8aa7d._0x8e7ed1ab(new byte[8] { 80, 115, 113, 121, 65, 126, 125, 102 }, 18) : _0xa0c8aa7d._0x8e7ed1ab(new byte[9] { 79, 126, 106, 108, 122, 76, 115, 112, 107 }, 31), string.Empty, _0x6752ee59, Vector2.zero, new Vector2(132f, 132f), this._plate, _0x36c49e16, _0xe65c236a.Fade(_0xe65c236a.Surface, 0.85f), _0xe65c236a.Fade(_0xe65c236a.Primary, 0.5f), _0xe65c236a.TextPrimary, this._font, 44f);
        if (_0xa9834d06.Icon != null)
            _0xa9834d06.Icon.color = _0xe65c236a.TextPrimary;
        if (_0xa9834d06.Button == null || this._board == null)
            return;
        if (_0x9563f057)
            _0xa9834d06.Button.onClick.AddListener(() => this._board._0xd1351427());
        else
            _0xa9834d06.Button.onClick.AddListener(() => this._board._0x25d7c4f5());
    }

    /// <summary>Grey the launch action out while a flight is already in the air.</summary>
    public void _0xdc740ff1(bool _0x259f8ecb)
    {
        if (this._0xdd99275d == null || this._0xdd99275d.Button == null)
            return;
        this._0xdd99275d.Button.interactable = _0x259f8ecb;
        if (this._0xdd99275d.Fill != null)
            this._0xdd99275d.Fill.color = _0x259f8ecb ? _0xe65c236a.Gold : _0xe65c236a.Fade(_0xe65c236a.SurfaceAlt, 0.75f);
        if (this._0xdd99275d.Caption != null)
            this._0xdd99275d.Caption.color = _0x259f8ecb ? _0xe65c236a.Ink : _0xe65c236a.Fade(_0xe65c236a.TextSecondary, 0.8f);
    }

    private TextMeshProUGUI _0x8670d432;
    /// <summary>Which route the player is on, one-based and padded so it never jumps.</summary>
    public void _0x093eb72a(int _0x9a6d22ab)
    {
        if (this._0x8670d432 != null)
            this._0x8670d432.text = (_0x9a6d22ab + 1).ToString(_0xa0c8aa7d._0x8e7ed1ab(new byte[2] { 105, 105 }, 89));
    }

    private TextMeshProUGUI _0x8cf327af;
    private _0xbf3b76a3 _0xdd99275d;
    private void _0x76a95549()
    {
        if (this._0xdd99275d != null && this._0xdd99275d.Fill != null)
        {
            this._0xdd99275d.Fill.transform.DOKill();
            this._0xdd99275d.Fill.transform.localScale = Vector3.one;
            this._0xdd99275d.Fill.transform.DOPunchScale(Vector3.one * 0.06f, 0.16f, 4, 0.8f);
        }

        if (this._board != null)
            this._board._0xcd3420ec();
    }

    [SerializeField]
    private _0x845080f6 _board;
    /// <summary>Turns left. Two or fewer turns the readout goes red and jolts.</summary>
    public void _0x3c073b51(int _0xf11c521b)
    {
        if (this._0x76e52b5b == null)
            return;
        this._0x76e52b5b.text = Mathf.Max(0, _0xf11c521b).ToString(_0xa0c8aa7d._0x8e7ed1ab(new byte[2] { 219, 219 }, 235));
        this._0x76e52b5b.color = _0xf11c521b <= 2 ? _0xe65c236a.Danger : _0xe65c236a.Primary;
        this._0x76e52b5b.transform.DOKill();
        this._0x76e52b5b.transform.localScale = Vector3.one;
        this._0x76e52b5b.transform.DOPunchScale(Vector3.one * 0.18f, 0.18f, 6, 0.7f);
    }

    /// <summary>
    /// The last turn is spent: the button flares red and pulses, because the route is
    /// about to go up on its own and the player should see that coming.
    /// </summary>
    public void _0x45f161cc()
    {
        if (this._0xdd99275d == null || this._0xdd99275d.Rim == null)
            return;
        this._0xdd99275d.Rim.color = _0xe65c236a.Danger;
        this._0xdd99275d.Rim.transform.DOKill();
        this._0xdd99275d.Rim.transform.localScale = Vector3.one;
        this._0xdd99275d.Rim.transform.DOScale(1.06f, 0.45f).SetLoops(-1, LoopType.Yoyo);
    }

    private const float LaunchRow = 0.125f;
    [SerializeField]
    private Sprite _iconBack;
    [SerializeField]
    private TMP_FontAsset _font;
    /// <summary>One glass readout: a small caption with a big value under it.</summary>
    private TextMeshProUGUI Readout(Transform _0x1c495494, Vector2 _0xbb092aad, string _0x7689b570, string _0xb81edcdd, Color _0xf0e622ad)
    {
        RectTransform _0x6c2ea6da = _0xa9e49e33.Plate(_0x1c495494, _0x7689b570 + _0xa0c8aa7d._0x8e7ed1ab(new byte[4] { 238, 209, 210, 201 }, 189), _0xbb092aad, Vector2.zero, new Vector2(360f, 132f), this._plate, _0xe65c236a.Fade(_0xe65c236a.Surface, 0.72f), _0xe65c236a.Fade(_0xe65c236a.Primary, 0.34f));
        _0xa9e49e33.Label(_0x6c2ea6da, _0xa0c8aa7d._0x8e7ed1ab(new byte[7] { 128, 162, 179, 183, 170, 172, 173 }, 195), _0x7689b570, new Vector2(0.5f, 0.76f), Vector2.zero, new Vector2(320f, 46f), 36f, 36f, _0xe65c236a.TextSecondary, this._font, TextAlignmentOptions.Center);
        return _0xa9e49e33.Label(_0x6c2ea6da, _0xa0c8aa7d._0x8e7ed1ab(new byte[5] { 42, 29, 16, 9, 25 }, 124), _0xb81edcdd, new Vector2(0.5f, 0.34f), Vector2.zero, new Vector2(320f, 74f), 64f, 40f, _0xf0e622ad, this._font, TextAlignmentOptions.Center);
    }

    /// <summary>Check clouds crossed out of the route's total.</summary>
    public void _0xdc379224(int _0x2cdddc34, int _0xc5760d4d)
    {
        if (this._0xffc626ac != null)
            this._0xffc626ac.text = _0x2cdddc34 + _0xa0c8aa7d._0x8e7ed1ab(new byte[1] { 55 }, 24) + _0xc5760d4d;
    }

    private const float HintRow = 0.235f;
    [SerializeField]
    private Sprite _iconPause;
    [SerializeField]
    private Sprite _plate;
    private TextMeshProUGUI _0x76e52b5b;
    private const float ChromeRow = 0.952f;
    private const float RouteRow = 0.885f;
    /// <summary>
    /// The hint holds solid for the first seconds of a route and then settles to a
    /// readable dim - never to nothing, because a hint nobody can see is not a hint.
    /// </summary>
    private void _0x84680155()
    {
        if (this._0x8cf327af == null)
            return;
        this._0x8cf327af.DOKill();
        this._0x8cf327af.DOFade(_0xd896e65b.HintDimAlpha, 0.8f).SetDelay(_0xd896e65b.HintSolidSeconds);
    }

    /// <summary>Raise the whole HUD under <paramref name = "host"/>.</summary>
    public void _0x70097354(Transform _0x1aedda0b)
    {
        if (_0x1aedda0b == null)
            return;
        RectTransform _0xce7096cd = _0xa9e49e33.Stretch(_0x1aedda0b, _0xa0c8aa7d._0x8e7ed1ab(new byte[6] { 94, 102, 116, 69, 120, 105 }, 13));
        this.Chrome(_0xce7096cd, new Vector2(0.135f, ChromeRow), this._iconBack, true);
        this.Chrome(_0xce7096cd, new Vector2(0.865f, ChromeRow), this._iconPause, false);
        this._0x8670d432 = this.Readout(_0xce7096cd, new Vector2(0.19f, RouteRow), _0xa0c8aa7d._0x8e7ed1ab(new byte[5] { 248, 229, 255, 254, 239 }, 170), _0xa0c8aa7d._0x8e7ed1ab(new byte[2] { 203, 202 }, 251), _0xe65c236a.TextPrimary);
        this._0x76e52b5b = this.Readout(_0xce7096cd, new Vector2(0.5f, RouteRow), _0xa0c8aa7d._0x8e7ed1ab(new byte[5] { 238, 239, 232, 244, 233 }, 186), _0xa0c8aa7d._0x8e7ed1ab(new byte[2] { 196, 196 }, 244), _0xe65c236a.Primary);
        this._0xffc626ac = this.Readout(_0xce7096cd, new Vector2(0.81f, RouteRow), _0xa0c8aa7d._0x8e7ed1ab(new byte[6] { 38, 41, 42, 48, 33, 54 }, 101), _0xa0c8aa7d._0x8e7ed1ab(new byte[3] { 125, 98, 125 }, 77), _0xe65c236a.Gold);
        this._0x8cf327af = _0xa9e49e33.Label(_0xce7096cd, _0xa0c8aa7d._0x8e7ed1ab(new byte[11] { 221, 241, 240, 234, 236, 241, 242, 214, 247, 240, 234 }, 158), _0xa0c8aa7d._0x8e7ed1ab(new byte[51] { 239, 250, 235, 155, 250, 155, 233, 242, 245, 252, 155, 239, 244, 155, 239, 238, 233, 245, 155, 242, 239, 177, 247, 250, 238, 245, 248, 243, 155, 236, 243, 254, 245, 155, 239, 243, 254, 155, 236, 242, 245, 255, 155, 247, 242, 245, 254, 232, 155, 238, 235 }, 187), new Vector2(0.5f, HintRow), Vector2.zero, new Vector2(1020f, 140f), 40f, 36f, _0xe65c236a.TextSecondary, this._font, TextAlignmentOptions.Center);
        this._0xdd99275d = _0xa9e49e33.CtaParts(_0xce7096cd, _0xa0c8aa7d._0x8e7ed1ab(new byte[9] { 48, 29, 9, 18, 31, 20, 63, 8, 29 }, 124), _0xa0c8aa7d._0x8e7ed1ab(new byte[6] { 144, 157, 137, 146, 159, 148 }, 220), new Vector2(0.5f, LaunchRow), Vector2.zero, new Vector2(700f, 160f), this._plate, null, _0xe65c236a.Gold, _0xe65c236a.Fade(_0xe65c236a.TextPrimary, 0.85f), _0xe65c236a.Ink, this._font, 64f);
        if (this._0xdd99275d.Caption != null)
            this._0xdd99275d.Caption.color = _0xe65c236a.Ink;
        if (this._0xdd99275d.Button != null)
            this._0xdd99275d.Button.onClick.AddListener(() => this._0x76a95549());
        this._0x84680155();
    }
}

internal static class _0xa0c8aa7d
{
    internal static string _0x8e7ed1ab(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}