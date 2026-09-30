using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>
/// The board screen: it measures the field from the camera, asks the generator for a
/// route, raises the rings, spends turns as the player turns them, flies the balloon
/// when LAUNCH is pressed and hands the outcome to the result cards.
///
/// Nothing here is laid out by hand. Every radius, plate and glyph comes from
/// <see cref = "SkyMetrics"/>, which is derived from the camera's orthographic size, and
/// every sorting order comes from a named constant in <see cref = "SkyConfig"/>.
/// </summary>
public sealed class _0x845080f6 : MonoBehaviour
{
    [SerializeField]
    private GameObject _balloonPrefab;
    /// <summary>The pause card was dismissed.</summary>
    public void _0xcf2a9218()
    {
        this._0x96aaa429 = false;
    }

    private _0xe8454662 _0xb054d95c;
    [Header("Art")]
    [SerializeField]
    private Sprite _spriteCell;
    [SerializeField]
    private Sprite _spriteBalloon;
    // ── outcome ─────────────────────────────────────────────────────────────
    private void _0xf800c9c7(_0xf373b1d0 _0x68d07931)
    {
        if (this._0xd8c75fd9 == _0xb5d6e1aa.Resolved)
            return;
        this._0xd8c75fd9 = _0xb5d6e1aa.Resolved;
        this._0xd1777462(false);
        bool _0x982e7ec3 = _0x68d07931.Result == _0xae4b601f.Locked;
        int _0x8dd80a47 = _0x68d07931.CloudsPassed * _0xd896e65b.MilesPerCloud;
        if (_0x982e7ec3)
            _0x8dd80a47 += _0xd896e65b.MilesPerRoute + this._0x03dc326b * _0xd896e65b.MilesPerSpareTurn;
        _0x47a641fc._0x44cfec3f._0x678a3800 = _0x47a641fc._0x44cfec3f._0x678a3800 + _0x8dd80a47;
        if (this._hud != null)
            this._hud._0xdc379224(_0x68d07931.CloudsPassed, this._0x291746c5.CloudTotal);
        if (_0x982e7ec3)
        {
            _0x0e5ba754._0xb33a38eb._0x61dc61e0 = this._0xcf023591 + 1;
            if (_0x8dd80a47 > _0x0e5ba754._0xb33a38eb._0xd36fc50b)
                _0x0e5ba754._0xb33a38eb._0xd36fc50b = _0x8dd80a47;
            if (this._0xfc0cf1eb != null)
            {
                Vector2 _0xe12de83c = this._0xfc0cf1eb.size * 1.18f;
                Vector2 _0xc5ebeaad = this._0xfc0cf1eb.size;
                DOTween.To(() => this._0xfc0cf1eb.size, _0x7b63cf9c => this._0xfc0cf1eb.size = _0x7b63cf9c, _0xe12de83c, 0.22f).SetTarget(this._0xfc0cf1eb).OnComplete(() => DOTween.To(() => this._0xfc0cf1eb.size, _0x7b63cf9c => this._0xfc0cf1eb.size = _0x7b63cf9c, _0xc5ebeaad, 0.23f).SetTarget(this._0xfc0cf1eb));
            }
        }

        DOVirtual.DelayedCall(_0xd896e65b.ResolveSeconds, () => this._0x57275d15(_0x68d07931, _0x8dd80a47, _0x982e7ec3));
    }

    /// <summary>Back to the menu scene, by build index.</summary>
    public void _0xd1351427()
    {
        if (_0x0e5ba754.Instance != null)
            _0x0e5ba754.Instance.LoadSceneByIndex(_0x47a641fc._0xb2d9c6f9.SCENE_0);
    }

    /// <summary>LAUNCH: fly the route exactly as it stands.</summary>
    public void _0xcd3420ec()
    {
        if (this._0xd8c75fd9 != _0xb5d6e1aa.Planning || this._0x96aaa429)
            return;
        this._0xefb44938?.Kill();
        this._0xd8c75fd9 = _0xb5d6e1aa.Flight;
        if (this._hud != null)
            this._hud._0xdc740ff1(false);
        this._0xd1777462(true);
        _0xf373b1d0 _0xc0e2096c = this._0x5958993f._0xb89a9663(this._0x291746c5, this._0x058370e3);
        this._0x60c29414 = _0xc0e2096c.CloudsPassed;
        {
#if B_LOGS
            {
                Debug.Log($"[flight] result={_0xc0e2096c.Result} clouds={_0xc0e2096c.CloudsPassed}/{this._0x291746c5.CloudTotal} stopped={_0xc0e2096c.StoppedRing}");
            }
#endif
        }

        if (this._flight == null)
        {
            this._0xf800c9c7(_0xc0e2096c);
            return;
        }

        this._flight._0x176bec01(this._0xb054d95c, _0xc0e2096c, this._0x291746c5, this._0x3fa3339b, this._0x058370e3, () => this._0xf800c9c7(_0xc0e2096c));
    }

    [Header("Screen parts")]
    [SerializeField]
    private _0x16230291 _hud;
    private enum _0xb5d6e1aa
    {
        Planning = 0,
        Flight = 1,
        Resolved = 2,
    }

    private _0xb5d6e1aa _0xd8c75fd9;
    [SerializeField]
    private Sprite _spriteArrowSteady;
    private int _0xcf023591;
    private Tween _0xefb44938;
    private void Start()
    {
        this._0xfda984d2 = this._0xd93f39ac();
        this._0xb054d95c = _0xe8454662.Measure(Camera.main);
        this._0xcf023591 = Mathf.Max(0, _0x0e5ba754._0xb33a38eb._0x61dc61e0);
        int _0xed774102 = unchecked((int)(System.DateTime.UtcNow.Ticks >> 9));
        this._0x291746c5 = this._0xbb803fe8._0x4f104ac7(this._0xcf023591, 0, _0xed774102);
        this._0x058370e3 = new int[_0xd896e65b.Rings];
        for (int _0x8dcc1b58 = 0; _0x8dcc1b58 < _0xd896e65b.Rings; _0x8dcc1b58++)
            this._0x058370e3[_0x8dcc1b58] = this._0x291746c5.Rotations[_0x8dcc1b58];
        this._0x03dc326b = _0xd896e65b.TurnBudget(this._0xcf023591, this._0x291746c5.Depth);
        this._0xd8c75fd9 = _0xb5d6e1aa.Planning;
        this._0xee23dcf9();
        Transform _0xa4b90121 = PanelHost();
        if (this._hud != null)
        {
            this._hud._0x70097354(_0xa4b90121);
            this._hud._0x093eb72a(this._0xcf023591);
            this._hud._0x3c073b51(this._0x03dc326b);
            this._hud._0xdc379224(0, this._0x291746c5.CloudTotal);
            this._hud._0xdc740ff1(true);
        }

        if (this._pops != null)
            this._pops._0x08cc6040();
        _0xa9e49e33.SanitiseTutorials(this._font);
        {
#if B_LOGS
            {
                Debug.Log($"[board] route={this._0xcf023591} seed={this._0x291746c5.Seed} depth={this._0x291746c5.Depth} turns={this._0x03dc326b}");
            }
#endif
        }
    }

    [SerializeField]
    private Sprite _spriteHub;
    [SerializeField]
    private GameObject _gatePrefab;
    private void _0x57275d15(_0xf373b1d0 _0xe0e01fda, int _0xdfbc9bf8, bool _0xdaadda58)
    {
        if (this._pops == null)
            return;
        if (_0xdaadda58)
            this._pops._0x4dfe380f(_0xe0e01fda.CloudsPassed, this._0x291746c5.CloudTotal, _0xdfbc9bf8);
        else
            this._pops._0xb5fa2456(_0xe0e01fda.Result, _0xe0e01fda.CloudsPassed, this._0x291746c5.CloudTotal, _0xdfbc9bf8);
    }

    // ── build ───────────────────────────────────────────────────────────────
    private _0xff4a3fa2 _0xd93f39ac()
    {
        _0xff4a3fa2 _0x4c4a2531 = new _0xff4a3fa2();
        _0x4c4a2531.RingCell = this._spriteCell;
        _0x4c4a2531.RingRim = this._spriteRim;
        _0x4c4a2531.ArrowSteady = this._spriteArrowSteady;
        _0x4c4a2531.ArrowClockwise = this._spriteArrowClockwise;
        _0x4c4a2531.ArrowCounter = this._spriteArrowCounter;
        _0x4c4a2531.Storm = this._spriteStorm;
        _0x4c4a2531.Cloud = this._spriteCloud;
        _0x4c4a2531.Gate = this._spriteGate;
        _0x4c4a2531.Hub = this._spriteHub;
        _0x4c4a2531.Balloon = this._spriteBalloon;
        _0x4c4a2531.Spark = this._spriteSpark;
        _0x4c4a2531.Plate = this._spritePlate;
        return _0x4c4a2531;
    }

    private int _0x03dc326b;
    [SerializeField]
    private _0x21ba0f9f _pops;
    [SerializeField]
    private Sprite _spriteArrowClockwise;
    [SerializeField]
    private Sprite _spriteCloud;
    [SerializeField]
    private Sprite _spriteArrowCounter;
    /// <summary>
    /// The route ran out of turns. The board does not end there: the button flares and
    /// the flight leaves on its own a moment later, so the screen always moves on to a
    /// result instead of sitting on a board nobody can change.
    /// </summary>
    private void _0x10200618()
    {
        if (this._hud != null)
            this._hud._0x45f161cc();
        this._0xefb44938?.Kill();
        this._0xefb44938 = DOVirtual.DelayedCall(_0xd896e65b.AutoLaunchSeconds, () => this._0xcd3420ec());
    }

    [SerializeField]
    private GameObject _sparkPrefab;
    [Header("Spawnable pieces")]
    [SerializeField]
    private GameObject _cellPrefab;
    private SpriteRenderer _0xfc0cf1eb;
    /// <summary>Spawn the field: rims, cells, the pad, the gate and the balloon.</summary>
    private void _0xee23dcf9()
    {
        _0x95357f1a _0x9f62fb45 = new _0x95357f1a();
        _0x9f62fb45.Cell = this._cellPrefab;
        _0x9f62fb45.Rim = this._rimPrefab;
        _0x9f62fb45.Balloon = this._balloonPrefab;
        _0x9f62fb45.Gate = this._gatePrefab;
        _0x9f62fb45.Pad = this._padPrefab;
        _0x9f62fb45.Spark = this._sparkPrefab;
        this._0x3fa3339b = new _0xa09d989b[_0xd896e65b.Rings];
        for (int _0x5f357a89 = 0; _0x5f357a89 < _0xd896e65b.Rings; _0x5f357a89++)
        {
            GameObject _0xda1f050f = new GameObject(_0x256f3f29._0x6c55a12d(new byte[8] { 187, 133, 130, 136, 190, 133, 130, 139 }, 236) + _0x5f357a89);
            _0xda1f050f.transform.SetParent(this.transform, false);
            _0xda1f050f.transform.localPosition = new Vector3(this._0xb054d95c.Centre.x, this._0xb054d95c.Centre.y, 0f);
            _0xda1f050f.transform.localScale = Vector3.one;
            _0xa09d989b _0xb46e98eb = _0xda1f050f.AddComponent<_0xa09d989b>();
            _0xb46e98eb._0x0280e6f2(this._0xfda984d2, _0x9f62fb45, this._0xb054d95c, _0x5f357a89);
            _0xb46e98eb._0xe6026360(this._0xfda984d2, this._0x291746c5);
            _0xb46e98eb._0x79993a6c(this._0x058370e3[_0x5f357a89]);
            _0xb46e98eb._0xa61d2ca1(_0x5f357a89 * 0.06f);
            this._0x3fa3339b[_0x5f357a89] = _0xb46e98eb;
        }

        float _0x430ec163 = this._0xb054d95c.Inner[0] * 2f;
        this._0x4c72e8bc = _0x457f4fef.Spawn(this._padPrefab, this.transform, _0x256f3f29._0x6c55a12d(new byte[9] { 239, 194, 214, 205, 192, 203, 243, 194, 199 }, 163), this._0xfda984d2.Hub, new Vector2(_0x430ec163, _0x430ec163), this._0xb054d95c.Centre, _0xd896e65b.OrderHub, Color.white);
        if (this._0x4c72e8bc != null)
            this._0x4c72e8bc.DOFade(0.72f, 1.4f).SetLoops(-1, LoopType.Yoyo);
        Vector2 _0x29dcb83c = new Vector2(this._0xb054d95c.Arc[2] * 0.47f, this._0xb054d95c.Band[2] * 0.82f);
        Vector2 _0xd3fe593d = this._0xb054d95c.Centre + _0xe8454662.Direction(this._0x291746c5.GateAngle) * (this._0xb054d95c.OuterRadius * _0xd896e65b.GateRadiusFraction);
        this._0xfc0cf1eb = _0x457f4fef.Spawn(this._gatePrefab, this.transform, _0x256f3f29._0x6c55a12d(new byte[7] { 215, 239, 253, 195, 229, 240, 225 }, 132), this._0xfda984d2.Gate, _0x29dcb83c, _0xd3fe593d, _0xd896e65b.OrderGate, _0xe65c236a.Gold);
        if (this._0xfc0cf1eb != null)
            this._0xfc0cf1eb.transform.localRotation = Quaternion.Euler(0f, 0f, -this._0x291746c5.GateAngle * _0xd896e65b.SectorDegrees);
        Vector2 _0x9014d166 = new Vector2(this._0xb054d95c.Band[0] * 0.76f, this._0xb054d95c.Band[0] * 1.05f);
        SpriteRenderer _0xc2be4466 = _0x457f4fef.Spawn(this._balloonPrefab, this.transform, _0x256f3f29._0x6c55a12d(new byte[7] { 205, 238, 227, 227, 224, 224, 225 }, 143), this._0xfda984d2.Balloon, _0x9014d166, this._0xb054d95c.Centre, _0xd896e65b.OrderBalloon, Color.white);
        float _0xe7610edc = this._0xb054d95c.Band[0] * 0.3f;
        SpriteRenderer _0xb48f39f4 = _0x457f4fef.Spawn(this._sparkPrefab, this.transform, _0x256f3f29._0x6c55a12d(new byte[11] { 115, 89, 92, 82, 93, 65, 102, 69, 84, 71, 94 }, 53), this._0xfda984d2.Spark, new Vector2(_0xe7610edc, _0xe7610edc), this._0xb054d95c.Centre, _0xd896e65b.OrderSpark, _0xe65c236a.Primary);
        _0x457f4fef.SetAlpha(_0xb48f39f4, 0f);
        if (this._flight != null)
        {
            this._flight._0xbcd26c6f(_0xc2be4466, _0xb48f39f4);
            this._flight._0xa669b23b(this._0xb054d95c, this._0x291746c5.StartAngle);
        }
    }

    private void OnDestroy()
    {
        this._0xefb44938?.Kill();
    }

    /// <summary>
    /// The panel the template already shows for gameplay, addressed by its index the
    /// way every panel in this project is addressed. The HUD is raised inside it so it
    /// inherits the panel's own show and hide.
    /// </summary>
    private static Transform PanelHost()
    {
        _0x3d672026 _0x5f8a6732 = _0x3d672026.Instance;
        if (_0x5f8a6732 == null || _0x5f8a6732.Panels == null)
            return null;
        int _0x7c82e2a4 = _0x47a641fc._0x545b99d3.DEFAULT;
        if (_0x7c82e2a4 < 0 || _0x7c82e2a4 >= _0x5f8a6732.Panels.Count)
            return null;
        _0x47b2eccc _0xe2125744 = _0x5f8a6732.Panels[_0x7c82e2a4];
        if (_0xe2125744 == null || _0xe2125744.Content == null)
            return null;
        return _0xe2125744.Content.transform;
    }

    private int _0x60c29414;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private _0x310b7c46 _flight;
    private void _0xd1777462(bool _0x75d7d7c4)
    {
        if (this._0x3fa3339b == null)
            return;
        for (int _0x1335ec1e = 0; _0x1335ec1e < this._0x3fa3339b.Length; _0x1335ec1e++)
        {
            if (this._0x3fa3339b[_0x1335ec1e] != null)
                this._0x3fa3339b[_0x1335ec1e]._0x23f6ee8d(_0x75d7d7c4);
        }
    }

    [SerializeField]
    private Sprite _spriteStorm;
    private _0x65393926 _0x291746c5;
    private _0xff4a3fa2 _0xfda984d2;
    private readonly _0xcac53a8e _0x5958993f = new _0xcac53a8e();
    private int[] _0x058370e3;
    [SerializeField]
    private Sprite _spritePlate;
    private readonly _0x7f5352cb _0xbb803fe8 = new _0x7f5352cb();
    /// <summary>The pause slot in the top bar.</summary>
    public void _0x25d7c4f5()
    {
        if (this._0xd8c75fd9 == _0xb5d6e1aa.Resolved || this._0x96aaa429 || this._pops == null)
            return;
        // Only hold the board if the card really came up. If it could not, the player
        // keeps their game instead of being locked out of a screen nothing is covering.
        this._0x96aaa429 = this._pops._0x05811287(this._0xcf023591, this._0x03dc326b, this._0x60c29414, this._0x291746c5.CloudTotal);
    }

    [SerializeField]
    private GameObject _rimPrefab;
    [SerializeField]
    private Sprite _spriteGate;
    private SpriteRenderer _0x4c72e8bc;
    // ── player actions ──────────────────────────────────────────────────────
    /// <summary>A tap landed on the field: turn whichever ring it fell on.</summary>
    public void _0xacd6abfb(Vector2 _0xe2a37f13)
    {
        if (this._0xd8c75fd9 != _0xb5d6e1aa.Planning || this._0x96aaa429 || this._0xb054d95c == null)
            return;
        int _0x73a7cb76 = this._0xb054d95c._0xd9b6a5e7(_0xe2a37f13);
        if (_0x73a7cb76 < 0 || this._0x3fa3339b == null || _0x73a7cb76 >= this._0x3fa3339b.Length || this._0x3fa3339b[_0x73a7cb76] == null)
            return;
        this._0x058370e3[_0x73a7cb76] = (this._0x058370e3[_0x73a7cb76] + 1) % _0xd896e65b.Sectors;
        this._0x3fa3339b[_0x73a7cb76]._0x546350ba();
        this._0x03dc326b = Mathf.Max(0, this._0x03dc326b - 1);
        if (this._hud != null)
            this._hud._0x3c073b51(this._0x03dc326b);
        if (this._0x03dc326b == 0)
            this._0x10200618();
    }

    private _0xa09d989b[] _0x3fa3339b;
    [SerializeField]
    private Sprite _spriteRim;
    private bool _0x96aaa429;
    [SerializeField]
    private GameObject _padPrefab;
    [SerializeField]
    private Sprite _spriteSpark;
}

internal static class _0x256f3f29
{
    internal static string _0x6c55a12d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}