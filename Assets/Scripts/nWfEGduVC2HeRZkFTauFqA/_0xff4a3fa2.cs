using UnityEngine;

/// <summary>
/// Every piece of art the sky is drawn from, handed around in one object so no view
/// ever has to look an asset up by name. The two directors fill it from their own
/// serialized fields, which the scenes assign by guid.
/// </summary>
public sealed class _0xff4a3fa2
{
    public Sprite Plate;
    public Sprite Storm;
    public Sprite Spark;
    public Sprite ArrowCounter;
    public Sprite Gate;
    public Sprite ArrowSteady;
    public Sprite IconPause;
    public Sprite Emblem;
    public Sprite IconClose;
    public Sprite RingCell;
    /// <summary>The glyph that stands for one kind of wind cell.</summary>
    public Sprite _0x74e00b5d(_0xb707c4c5 _0x4c0af656)
    {
        if (_0x4c0af656 == _0xb707c4c5.Clockwise)
            return this.ArrowClockwise;
        if (_0x4c0af656 == _0xb707c4c5.Counter)
            return this.ArrowCounter;
        if (_0x4c0af656 == _0xb707c4c5.Squall)
            return this.Storm;
        return this.ArrowSteady;
    }

    public Sprite RingRim;
    public Sprite Balloon;
    /// <summary>The tint the glyph on a cell wears.</summary>
    public static Color GlyphTintFor(_0xb707c4c5 _0x450dce5d)
    {
        if (_0x450dce5d == _0xb707c4c5.Squall)
            return _0xe65c236a.Danger;
        if (_0x450dce5d == _0xb707c4c5.Steady)
            return _0xe65c236a.Fade(_0xe65c236a.TextSecondary, 0.95f);
        return _0xe65c236a.Primary;
    }

    /// <summary>The tint a cell plate wears for its kind.</summary>
    public static Color TintFor(_0xb707c4c5 _0xe23965b8)
    {
        if (_0xe23965b8 == _0xb707c4c5.Squall)
            return _0xe65c236a.Fade(_0xe65c236a.Danger, 0.34f);
        if (_0xe23965b8 == _0xb707c4c5.Steady)
            return _0xe65c236a.Fade(_0xe65c236a.SurfaceAlt, 0.92f);
        return _0xe65c236a.Fade(_0xe65c236a.Surface, 0.95f);
    }

    public Sprite Cloud;
    public Sprite ArrowClockwise;
    public Sprite IconBack;
    public Sprite Hub;
    public Sprite NodeDot;
}

/// <summary>
/// The spawnable pieces, authored as prefabs so each one arrives already Sliced,
/// already sized and already on a sorting order inside the allowed band.
/// </summary>
public sealed class _0x95357f1a
{
    public GameObject Marker;
    public GameObject Gate;
    public GameObject Rim;
    public GameObject Glyph;
    public GameObject Spark;
    public GameObject Pad;
    public GameObject Balloon;
    public GameObject Cell;
}

/// <summary>
/// The measured shape of the board. Everything is derived from the camera, so the
/// field fits the same way on any aspect - nothing here is a literal world size.
/// </summary>
public sealed class _0xe8454662
{
    public float[] Outer = new float[_0xd896e65b.Rings];
    public float[] Inner = new float[_0xd896e65b.Rings];
    /// <summary>Glyph size for ring k - one size for the whole ring, never per cell.</summary>
    public float _0x6dd25cd3(int _0xa89bd6bd)
    {
        return Mathf.Min(this.Arc[_0xa89bd6bd], this.Band[_0xa89bd6bd]) * _0xd896e65b.GlyphFill;
    }

    /// <summary>Plate size for a cell of ring k: along the arc by across the band.</summary>
    public Vector2 _0x985d0438(int _0xa1c336d6)
    {
        return new Vector2(this.Arc[_0xa1c336d6] * _0xd896e65b.CellArcFill, this.Band[_0xa1c336d6] * _0xd896e65b.CellBandFill);
    }

    public float[] Band = new float[_0xd896e65b.Rings];
    /// <summary>Which ring a world point falls in, or -1 for the pad and the sky outside.</summary>
    public int _0xd9b6a5e7(Vector2 _0x3bd1413e)
    {
        float _0xf826b1b9 = (_0x3bd1413e - this.Centre).magnitude;
        for (int _0xe2923155 = 0; _0xe2923155 < _0xd896e65b.Rings; _0xe2923155++)
        {
            if (_0xf826b1b9 >= this.Inner[_0xe2923155] && _0xf826b1b9 <= this.Outer[_0xe2923155])
                return _0xe2923155;
        }

        return -1;
    }

    public static _0xe8454662 Measure(Camera _0x387a5a5c)
    {
        _0xe8454662 _0x3d5450b0 = new _0xe8454662();
        _0x3d5450b0.HalfHeight = _0x387a5a5c == null ? 5f : _0x387a5a5c.orthographicSize;
        float _0x0cb3e988 = _0x387a5a5c == null || _0x387a5a5c.aspect <= 0f ? 9f / 19.5f : _0x387a5a5c.aspect;
        _0x3d5450b0.HalfWidth = _0x3d5450b0.HalfHeight * _0x0cb3e988;
        _0x3d5450b0.OuterRadius = _0x3d5450b0.HalfWidth * _0xd896e65b.FieldWidthFraction;
        _0x3d5450b0.Centre = new Vector2(0f, _0x3d5450b0.HalfHeight * _0xd896e65b.FieldRiseFraction);
        for (int _0xb358afe8 = 0; _0xb358afe8 < _0xd896e65b.Rings; _0xb358afe8++)
        {
            _0x3d5450b0.Inner[_0xb358afe8] = _0x3d5450b0.OuterRadius * _0xd896e65b.RingInnerFraction[_0xb358afe8];
            _0x3d5450b0.Outer[_0xb358afe8] = _0x3d5450b0.OuterRadius * _0xd896e65b.RingOuterFraction[_0xb358afe8];
            _0x3d5450b0.Middle[_0xb358afe8] = (_0x3d5450b0.Inner[_0xb358afe8] + _0x3d5450b0.Outer[_0xb358afe8]) * 0.5f;
            _0x3d5450b0.Band[_0xb358afe8] = _0x3d5450b0.Outer[_0xb358afe8] - _0x3d5450b0.Inner[_0xb358afe8];
            _0x3d5450b0.Arc[_0xb358afe8] = 2f * Mathf.PI * _0x3d5450b0.Middle[_0xb358afe8] / _0xd896e65b.Sectors;
        }

        return _0x3d5450b0;
    }

    public float[] Middle = new float[_0xd896e65b.Rings];
    public float HalfHeight;
    public float HalfWidth;
    public Vector2 Centre;
    /// <summary>Unit direction of a sector, measured clockwise from straight up.</summary>
    public static Vector2 Direction(float _0xa75757a6)
    {
        float _0x3c367ddd = _0xa75757a6 * _0xd896e65b.SectorDegrees * Mathf.Deg2Rad;
        return new Vector2(Mathf.Sin(_0x3c367ddd), Mathf.Cos(_0x3c367ddd));
    }

    public float OuterRadius;
    public float[] Arc = new float[_0xd896e65b.Rings];
}

/// <summary>
/// Thin factory for world art. Every renderer it returns is Sliced with an explicit
/// size taken from <see cref = "SkyMetrics"/> and sits at scale 1, so what the camera
/// shows is exactly what was computed - and its sorting order always comes from a
/// named constant in <see cref = "SkyConfig"/>, never from a number at the call site.
/// </summary>
public static class _0x457f4fef
{
    public static void SetAlpha(SpriteRenderer _0x1d6c3a0e, float _0xa61c23f6)
    {
        if (_0x1d6c3a0e == null)
            return;
        Color _0xbfc3f926 = _0x1d6c3a0e.color;
        _0x1d6c3a0e.color = new Color(_0xbfc3f926.r, _0xbfc3f926.g, _0xbfc3f926.b, _0xa61c23f6);
    }

    public static SpriteRenderer Quad(Transform _0x36f45ac9, string _0x4b4be09f, Sprite _0xd3221145, Vector2 _0xfb6943d3, Vector2 _0xb3086845, int _0x0d7fe2cf, Color _0x745c12cb)
    {
        GameObject _0xb3d4dcdb = new GameObject(_0x4b4be09f);
        _0xb3d4dcdb.transform.SetParent(_0x36f45ac9, false);
        _0xb3d4dcdb.transform.localPosition = new Vector3(_0xb3086845.x, _0xb3086845.y, 0f);
        _0xb3d4dcdb.transform.localScale = Vector3.one;
        SpriteRenderer _0x7aa39a30 = _0xb3d4dcdb.AddComponent<SpriteRenderer>();
        _0x7aa39a30.sprite = _0xd3221145;
        _0x7aa39a30.drawMode = SpriteDrawMode.Sliced;
        _0x7aa39a30.size = _0xfb6943d3;
        _0x7aa39a30.sortingOrder = _0x0d7fe2cf;
        _0x7aa39a30.color = _0x745c12cb;
        return _0x7aa39a30;
    }

    /// <summary>Resize a Sliced renderer without ever touching its transform scale.</summary>
    public static void Resize(SpriteRenderer _0x97cc3f26, Vector2 _0x80ca8bc2)
    {
        if (_0x97cc3f26 == null)
            return;
        _0x97cc3f26.drawMode = SpriteDrawMode.Sliced;
        _0x97cc3f26.size = _0x80ca8bc2;
        _0x97cc3f26.transform.localScale = Vector3.one;
    }

    public static SpriteRenderer Spawn(GameObject _0x47e322bc, Transform _0x3f1952c7, string _0x7c2164db, Sprite _0x02793e39, Vector2 _0x4ebde104, Vector2 _0x169da69b, int _0x39227529, Color _0x3cea5b2f)
    {
        SpriteRenderer _0x52d21740;
        if (_0x47e322bc == null)
        {
            _0x52d21740 = Quad(_0x3f1952c7, _0x7c2164db, _0x02793e39, _0x4ebde104, _0x169da69b, _0x39227529, _0x3cea5b2f);
            return _0x52d21740;
        }

        GameObject _0x67a959b3 = UnityEngine.Object.Instantiate(_0x47e322bc, _0x3f1952c7);
        _0x67a959b3.transform.localPosition = new Vector3(_0x169da69b.x, _0x169da69b.y, 0f);
        _0x67a959b3.transform.localRotation = Quaternion.identity;
        _0x67a959b3.transform.localScale = Vector3.one;
        _0x52d21740 = _0x67a959b3.GetComponent<SpriteRenderer>();
        if (_0x52d21740 == null)
            _0x52d21740 = _0x67a959b3.AddComponent<SpriteRenderer>();
        if (_0x02793e39 != null)
            _0x52d21740.sprite = _0x02793e39;
        _0x52d21740.drawMode = SpriteDrawMode.Sliced;
        _0x52d21740.size = _0x4ebde104;
        _0x52d21740.sortingOrder = _0x39227529;
        _0x52d21740.color = _0x3cea5b2f;
        return _0x52d21740;
    }
}