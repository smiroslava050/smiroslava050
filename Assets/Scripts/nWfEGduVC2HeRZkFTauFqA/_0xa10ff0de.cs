using DG.Tweening;
using UnityEngine;

/// <summary>
/// One cell of a wind ring: the glass plate, the wind glyph that says which way the
/// cell bends a flight, and the gold marker for a check cloud riding on it. The three
/// renderers are assigned in the prefab, so nothing is ever looked up by name, and
/// every size arrives from the camera-derived metrics rather than from the sprite.
/// </summary>
public sealed class _0xa10ff0de : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _glyph;
    /// <summary>Dim the whole cell, used while a flight is running over the board.</summary>
    public void _0xd835cfac(bool _0x890ff6ed)
    {
        float _0x3026e427 = _0x890ff6ed ? 0.62f : 1f;
        _0x457f4fef.SetAlpha(this._glyph, _0x3026e427);
        if (this._cloudMark != null)
            _0x457f4fef.SetAlpha(this._cloudMark, _0x3026e427);
    }

    private float _0x6e921531;
    /// <summary>The balloon just crossed this cell: flash whatever is worth noticing.</summary>
    public void _0xc4c8a1ad()
    {
        if (this._plate != null)
        {
            DOTween.Kill(this._plate);
            DOTween.To(() => this._plate.size, _0x7b63cf9c => this._plate.size = _0x7b63cf9c, this._0x3839365b * 1.12f, 0.16f).SetTarget(this._plate).SetLoops(2, LoopType.Yoyo);
        }

        if (this._0xec999116 && this._cloudMark != null)
        {
            this._cloudMark.transform.DOKill();
            this._cloudMark.transform.localScale = Vector3.one;
            this._cloudMark.transform.DOPunchScale(Vector3.one * 0.25f, 0.30f, 6, 0.6f);
        }
    }

    /// <summary>The kind this cell currently shows, so the board can read it back.</summary>
    public _0xb707c4c5 _0x25881a13 { get; private set; }

    /// <summary>
    /// The entrance cascade: the cell swells from a fraction of its measured size back
    /// to that size. The animation is written from the measured plate size, never from
    /// a literal scale, so it reads the same on any aspect.
    /// </summary>
    public void _0x216ed712(float _0x8bbc59ae)
    {
        if (this._plate == null)
            return;
        DOTween.Kill(this._plate);
        this._plate.size = this._0x3839365b * 0.6f;
        DOTween.To(() => this._plate.size, _0x7b63cf9c => this._plate.size = _0x7b63cf9c, this._0x3839365b, 0.20f).SetDelay(_0x8bbc59ae).SetEase(Ease.OutBack).SetTarget(this._plate);
    }

    [SerializeField]
    private SpriteRenderer _cloudMark;
    /// <summary>Dress the cell as one kind of wind, with or without a check cloud.</summary>
    public void _0x2bc16719(_0xff4a3fa2 _0xe4a96c92, _0xb707c4c5 _0xca818d7e, bool _0x7a4c8b6a)
    {
        this._0x25881a13 = _0xca818d7e;
        this._0xec999116 = _0x7a4c8b6a;
        if (this._plate != null)
            this._plate.color = _0xff4a3fa2.TintFor(_0xca818d7e);
        if (this._glyph != null && _0xe4a96c92 != null)
        {
            this._glyph.sprite = _0xe4a96c92._0x74e00b5d(_0xca818d7e);
            this._glyph.color = _0xff4a3fa2.GlyphTintFor(_0xca818d7e);
            _0x457f4fef.Resize(this._glyph, new Vector2(this._0x6e921531, this._0x6e921531));
        }

        if (this._cloudMark != null)
            this._cloudMark.gameObject.SetActive(_0x7a4c8b6a);
    }

    private Vector2 _0x3839365b;
    [SerializeField]
    private SpriteRenderer _plate;
    /// <summary>Whether a check cloud is riding on this cell.</summary>
    public bool _0xec999116 { get; private set; }

    /// <summary>
    /// Size the three renderers from the ring this cell belongs to. Everything is
    /// Sliced with an explicit size and left at scale 1, so the plate is exactly as
    /// wide as its slot on the ring and never the sprite's native 6.4 units.
    /// </summary>
    public void Measure(Vector2 _0x00af7586, float _0xfccd9989)
    {
        this._0x3839365b = _0x00af7586;
        this._0x6e921531 = _0xfccd9989;
        _0x457f4fef.Resize(this._plate, _0x00af7586);
        _0x457f4fef.Resize(this._glyph, new Vector2(_0xfccd9989, _0xfccd9989));
        _0x457f4fef.Resize(this._cloudMark, new Vector2(_0xfccd9989 * 0.82f, _0xfccd9989 * 0.56f));
        if (this._cloudMark != null)
            this._cloudMark.transform.localPosition = new Vector3(0f, _0x00af7586.y * 0.28f, 0f);
    }
}