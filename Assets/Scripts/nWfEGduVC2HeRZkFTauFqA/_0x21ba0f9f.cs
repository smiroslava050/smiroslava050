using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses and fills the three result cards the template keeps in its pop pool - win,
/// lose and pause, addressed by their indices, never by name. It rewrites every line
/// in this game's own words, gives each button a caption that says what it does, puts
/// a real icon on the close button (the template leaves that Image empty, which Unity
/// draws as a white square) and blanks any leftover template label that would
/// otherwise ship inside the card.
/// </summary>
public sealed class _0x21ba0f9f : MonoBehaviour
{
    /// <summary>The player stepped away mid-route.</summary>
    public bool _0x05811287(int _0x113a4186, int _0xa284debc, int _0x6c952e61, int _0xc5eaff39)
    {
        if (!Holds(_0x47a641fc._0xfc7f1136.PAUSE))
            return false;
        _0x48578c91 _0x7e4bfd06 = _0xc1be6679.Instance._0x2fa7501b(_0x47a641fc._0xfc7f1136.PAUSE);
        if (!Raise(_0x7e4bfd06))
            return false;
        _0xc1be6679.Instance._0xcb33a0ba(_0x47a641fc._0xfc7f1136.PAUSE);
        this._0xd38efbfe(_0x7e4bfd06, _0xe55ecdfc._0x5f5f3413(new byte[16] { 54, 49, 50, 58, 55, 48, 57, 94, 46, 49, 45, 55, 42, 55, 49, 48 }, 126), _0xe55ecdfc._0x5f5f3413(new byte[6] { 180, 169, 179, 178, 163, 198 }, 230) + (_0x113a4186 + 1) + _0xe55ecdfc._0x5f5f3413(new byte[12] { 143, 209, 208, 215, 203, 214, 165, 201, 192, 195, 209, 165 }, 133) + _0xa284debc, _0xe55ecdfc._0x5f5f3413(new byte[7] { 183, 184, 187, 161, 176, 167, 212 }, 244) + _0x6c952e61 + _0xe55ecdfc._0x5f5f3413(new byte[4] { 205, 162, 171, 205 }, 237) + _0xc5eaff39, _0xe65c236a.Primary);
        return true;
    }

    /// <summary>The flight ended anywhere other than the gate.</summary>
    public bool _0xb5fa2456(_0xae4b601f _0xa60f0bb4, int _0xa82f0ff4, int _0xbaee8ef9, int _0x5f135d7a)
    {
        if (!Holds(_0x47a641fc._0xfc7f1136.LOSE))
            return false;
        _0x48578c91 _0x15ac38da = _0xc1be6679.Instance._0x2fa7501b(_0x47a641fc._0xfc7f1136.LOSE);
        if (!Raise(_0x15ac38da))
            return false;
        _0xc1be6679.Instance._0xcb33a0ba(_0x47a641fc._0xfc7f1136.LOSE);
        string _0xdc4bede6 = _0xa60f0bb4 == _0xae4b601f.Squalled ? _0xe55ecdfc._0x5f5f3413(new byte[16] { 132, 138, 137, 145, 136, 230, 137, 128, 128, 230, 133, 137, 147, 148, 149, 131 }, 198) : _0xe55ecdfc._0x5f5f3413(new byte[20] { 234, 246, 251, 158, 249, 255, 234, 251, 158, 237, 234, 255, 231, 251, 250, 158, 237, 246, 235, 234 }, 190);
        this._0xd38efbfe(_0x15ac38da, _0xdc4bede6, _0xcac53a8e.Reason(_0xa60f0bb4) + _0xe55ecdfc._0x5f5f3413(new byte[8] { 230, 175, 160, 163, 185, 168, 191, 204 }, 236) + _0xa82f0ff4 + _0xe55ecdfc._0x5f5f3413(new byte[4] { 28, 115, 122, 28 }, 60) + _0xbaee8ef9, _0xe55ecdfc._0x5f5f3413(new byte[7] { 110, 106, 111, 102, 112, 3, 8 }, 35) + _0x5f135d7a, _0xe65c236a.Danger);
        return true;
    }

    private void _0xe0622f3c(TMP_Text _0x4e62be60, string _0xdbd400cb, Color _0x4e0a05e5)
    {
        if (_0x4e62be60 == null)
            return;
        _0x4e62be60.text = _0xdbd400cb;
        _0x4e62be60.color = _0x4e0a05e5;
        if (this._font != null)
            _0x4e62be60.font = this._font;
        _0xa9e49e33.Wrap(_0x4e62be60, 56f, 40f);
    }

    /// <summary>
    /// True when every object between the child and the card root is switched on. The
    /// pool ships far more buttons than any one card uses, and the unused ones sit
    /// disabled - they must not be captioned as if they were on screen.
    /// </summary>
    private static bool Reachable(Transform _0xceb39356, Transform _0xf524c1f2)
    {
        Transform _0xa2d047ec = _0xceb39356;
        while (_0xa2d047ec != null && _0xa2d047ec != _0xf524c1f2)
        {
            if (!_0xa2d047ec.gameObject.activeSelf)
                return false;
            _0xa2d047ec = _0xa2d047ec.parent;
        }

        return _0xa2d047ec == _0xf524c1f2;
    }

    /// <summary>Put this game's cross on the dismiss button and tint its plate.</summary>
    private void _0x86963a31(Button _0x25fc4b37)
    {
        if (_0x25fc4b37 == null || this._closeIcon == null)
            return;
        Image[] _0x21d1f7b6 = _0x25fc4b37.GetComponentsInChildren<Image>(true);
        for (int _0x0337e705 = 0; _0x0337e705 < _0x21d1f7b6.Length; _0x0337e705++)
        {
            if (_0x21d1f7b6[_0x0337e705] == null || _0x21d1f7b6[_0x0337e705].sprite != null)
                continue;
            _0x21d1f7b6[_0x0337e705].sprite = this._closeIcon;
            _0x21d1f7b6[_0x0337e705].type = Image.Type.Simple;
            _0x21d1f7b6[_0x0337e705].color = _0xe65c236a.TextPrimary;
            _0x21d1f7b6[_0x0337e705].preserveAspect = true;
            return;
        }
    }

    private bool _0x4e5c51a3;
    /// <summary>Write the three lines of a card and colour its title.</summary>
    private void _0xd38efbfe(_0x48578c91 _0x8b6ba35c, string _0x6e2c26f6, string _0xd47d9268, string _0x9be1f2ae, Color _0x5b5d3abb)
    {
        this._0x2eecebc2(_0x8b6ba35c.ContentHeaderText, _0x6e2c26f6, _0x5b5d3abb, 96f, 56f);
        if (_0x8b6ba35c.ContentAdditionalText != null)
        {
            this._0x2eecebc2(_0x8b6ba35c.ContentMainText, _0xd47d9268, _0xe65c236a.TextPrimary, 56f, 40f);
            this._0x2eecebc2(_0x8b6ba35c.ContentAdditionalText, _0x9be1f2ae, _0xe65c236a.TextSecondary, 48f, 38f);
        }
        else
        {
            // No third slot on this card: fold the detail into the body rather than
            // dropping it, with the break written by hand so the layout is fixed.
            this._0x2eecebc2(_0x8b6ba35c.ContentMainText, _0xd47d9268 + _0xe55ecdfc._0x5f5f3413(new byte[1] { 170 }, 160) + _0x9be1f2ae, _0xe65c236a.TextPrimary, 56f, 40f);
        }
    }

    /// <summary>
    /// Put a card into a state where it can be raised, and raise it BEFORE anything is
    /// written into it. Two template behaviours make the order matter:
    ///  - the card body ships switched off, and TMP labels on a body that has never
    ///    been awoken can throw the moment a font is assigned - which would unwind the
    ///    whole call before it ever reached ShowPop, leaving a card that never opens;
    ///  - Show() kills the body's tweens WITH completion, so a Hide() still running
    ///    from a moment ago fires its "switch the body off" callback straight after
    ///    Show() switched it on. Killing that tween here without completing it, and
    ///    resetting the scale Show() animates from, defuses both.
    /// </summary>
    private static bool Raise(_0x48578c91 _0xe7b5031e)
    {
        if (_0xe7b5031e == null || _0xe7b5031e.Content == null)
            return false;
        Transform _0x455d2cdd = _0xe7b5031e.Content.transform;
        DOTween.Kill(_0x455d2cdd);
        _0x455d2cdd.localScale = Vector3.zero;
        _0xe7b5031e.Content.SetActive(true);
        return true;
    }

    /// <summary>
    /// True when the pool really has a card at this index. The template ships a pool
    /// far longer than the three cards this game uses, and reading past its end would
    /// throw before anything could be drawn.
    /// </summary>
    private static bool Holds(int _0x0998451c)
    {
        _0xc1be6679 _0x85a1d2a6 = _0xc1be6679.Instance;
        return _0x85a1d2a6 != null && _0x85a1d2a6.Pops != null && _0x0998451c >= 0 && _0x0998451c < _0x85a1d2a6.Pops.Count && _0x85a1d2a6.Pops[_0x0998451c] != null;
    }

    /// <summary>The card this pool holds at an index, or null when it holds none.</summary>
    private static _0x48578c91 Fetch(int _0x80858b6d)
    {
        if (!Holds(_0x80858b6d))
            return null;
        return _0xc1be6679.Instance._0x2fa7501b(_0x80858b6d);
    }

    // ── one-time dressing ───────────────────────────────────────────────────
    /// <summary>
    /// Give one card its captions, its close icon and its palette, and silence every
    /// other label inside it. The action buttons are told apart by the driver they
    /// carry - the one that loads the menu scene is the way out, the one that reloads
    /// the board is the way on - which survives renaming in a way names do not.
    /// </summary>
    private void _0x5c89d814(int _0x886b2971, string _0x5c25cab3, Color _0xe9f34d05)
    {
        _0x48578c91 _0x9f0c011d = Fetch(_0x886b2971);
        if (_0x9f0c011d == null || _0x9f0c011d.Content == null)
            return;
        _0x9f0c011d.Content.SetActive(true);
        List<TMP_Text> _0x00616044 = new List<TMP_Text>();
        Button[] _0x8e2032c4 = _0x9f0c011d.Content.GetComponentsInChildren<Button>(true);
        for (int _0xbd5d27a4 = 0; _0xbd5d27a4 < _0x8e2032c4.Length; _0xbd5d27a4++)
        {
            Button _0x2bcc25bd = _0x8e2032c4[_0xbd5d27a4];
            if (_0x2bcc25bd == null || !Reachable(_0x2bcc25bd.transform, _0x9f0c011d.Content.transform))
                continue;
            TMP_Text _0x4dd5d367 = _0x2bcc25bd.GetComponentInChildren<TMP_Text>(true);
            _0x00623c01 _0xf5505ac0 = _0x2bcc25bd.GetComponentInChildren<_0x00623c01>(true);
            if (_0xf5505ac0 == null)
                _0xf5505ac0 = _0x2bcc25bd.GetComponentInParent<_0x00623c01>();
            if (_0xf5505ac0 != null)
            {
                bool _0xe6bb5e53 = !_0xf5505ac0.IsLoadCurrentScene && _0xf5505ac0.LoadSceneId == _0x47a641fc._0xb2d9c6f9.SCENE_0;
                this._0xe0622f3c(_0x4dd5d367, _0xe6bb5e53 ? _0xe55ecdfc._0x5f5f3413(new byte[4] { 85, 93, 86, 77 }, 24) : _0x5c25cab3, _0xe6bb5e53 ? _0xe65c236a.TextPrimary : _0xe9f34d05);
                if (_0x4dd5d367 != null)
                    _0x00616044.Add(_0x4dd5d367);
                continue;
            }

            // No scene driver: this is the dismiss control in the card's top corner,
            // told apart from the action row by what drives it rather than by where it
            // sits. It carries an icon instead of a word, and on the pause card it also
            // puts the board back into play.
            this._0x86963a31(_0x2bcc25bd);
            if (_0x4dd5d367 != null)
            {
                _0x4dd5d367.text = string.Empty;
                _0x00616044.Add(_0x4dd5d367);
            }

            if (this._board != null)
                _0x2bcc25bd.onClick.AddListener(() => this._board._0xcf2a9218());
        }

        // Anything still carrying template filler - "Score:", "Reward:", a stray number -
        // is silenced. The three lines the card actually speaks are set in Write().
        TMP_Text[] _0x0c85d1ce = _0x9f0c011d.Content.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xcd5fd0f1 = 0; _0xcd5fd0f1 < _0x0c85d1ce.Length; _0xcd5fd0f1++)
        {
            TMP_Text _0x1897c481 = _0x0c85d1ce[_0xcd5fd0f1];
            if (_0x1897c481 == null || _0x00616044.Contains(_0x1897c481))
                continue;
            if (_0x1897c481 == _0x9f0c011d.ContentHeaderText || _0x1897c481 == _0x9f0c011d.ContentMainText || _0x1897c481 == _0x9f0c011d.ContentAdditionalText)
                continue;
            _0x1897c481.text = string.Empty;
        }
    }

    private void _0x2eecebc2(TMP_Text _0xeb94eaef, string _0xf8c9fe7d, Color _0xcf00abee, float _0x3665f358, float _0x85ee3094)
    {
        if (_0xeb94eaef == null)
            return;
        _0xeb94eaef.text = _0xf8c9fe7d;
        _0xeb94eaef.color = _0xcf00abee;
        if (this._font != null)
            _0xeb94eaef.font = this._font;
        _0xeb94eaef.alignment = TextAlignmentOptions.Center;
        _0xa9e49e33.Wrap(_0xeb94eaef, _0x3665f358, _0x85ee3094);
    }

    /// <summary>The route was linked end to end.</summary>
    public bool _0x4dfe380f(int _0x406f347f, int _0x5092fad0, int _0x4e2a9ad5)
    {
        if (!Holds(_0x47a641fc._0xfc7f1136.WIN))
            return false;
        _0x48578c91 _0xcf64a543 = _0xc1be6679.Instance._0x2fa7501b(_0x47a641fc._0xfc7f1136.WIN);
        if (!Raise(_0xcf64a543))
            return false;
        _0xc1be6679.Instance._0xcb33a0ba(_0x47a641fc._0xfc7f1136.WIN);
        this._0xd38efbfe(_0xcf64a543, _0xe55ecdfc._0x5f5f3413(new byte[12] { 132, 153, 131, 130, 147, 246, 154, 153, 149, 157, 147, 146 }, 214), _0xe55ecdfc._0x5f5f3413(new byte[19] { 71, 84, 71, 80, 91, 34, 65, 78, 77, 87, 70, 34, 82, 67, 81, 81, 71, 70, 8 }, 2) + _0x406f347f + _0xe55ecdfc._0x5f5f3413(new byte[4] { 244, 155, 146, 244 }, 212) + _0x5092fad0, _0xe55ecdfc._0x5f5f3413(new byte[7] { 28, 24, 29, 20, 2, 113, 122 }, 81) + _0x4e2a9ad5, _0xe65c236a.Gold);
        if (_0xcf64a543.ContentImage != null && this._cloudIcon != null)
        {
            _0xcf64a543.ContentImage.sprite = this._cloudIcon;
            _0xcf64a543.ContentImage.color = _0xe65c236a.Gold;
        }

        return true;
    }

    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _closeIcon;
    [SerializeField]
    private _0x845080f6 _board;
    [SerializeField]
    private Sprite _cloudIcon;
    /// <summary>Theme all three cards once, before any of them is ever raised.</summary>
    public void _0x08cc6040()
    {
        if (this._0x4e5c51a3)
            return;
        this._0x4e5c51a3 = true;
        this._0x5c89d814(_0x47a641fc._0xfc7f1136.WIN, _0xe55ecdfc._0x5f5f3413(new byte[10] { 234, 225, 252, 240, 132, 246, 235, 241, 240, 225 }, 164), _0xe65c236a.Gold);
        this._0x5c89d814(_0x47a641fc._0xfc7f1136.LOSE, _0xe55ecdfc._0x5f5f3413(new byte[9] { 85, 83, 88, 33, 64, 70, 64, 72, 79 }, 1), _0xe65c236a.Danger);
        this._0x5c89d814(_0x47a641fc._0xfc7f1136.PAUSE, _0xe55ecdfc._0x5f5f3413(new byte[7] { 90, 77, 91, 92, 73, 90, 92 }, 8), _0xe65c236a.Primary);
    }
}

internal static class _0xe55ecdfc
{
    internal static string _0x5f5f3413(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}