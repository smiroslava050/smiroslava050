using System.Collections;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// Flies the balloon along the route the solver already resolved. It decides nothing:
/// the trace says which sector the balloon is in on every ring and where it stops, and
/// this only draws that, in polar steps so a bend reads as a curve along the ring
/// rather than a straight cut across it.
/// </summary>
public sealed class _0x310b7c46 : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _balloon;
    /// <summary>Hand the runner the pieces the board spawned for it.</summary>
    public void _0xbcd26c6f(SpriteRenderer _0x0b859f8b, SpriteRenderer _0x9ef76eb2)
    {
        this._balloon = _0x0b859f8b;
        this._trailFx = _0x9ef76eb2;
    }

    private static Vector3 Place(_0xe8454662 _0x5d1a073a, float _0xe164b700, float _0xad4b63f5)
    {
        Vector2 _0x54536b35 = _0x5d1a073a.Centre + _0xe8454662.Direction(_0xad4b63f5) * _0xe164b700;
        return new Vector3(_0x54536b35.x, _0x54536b35.y, 0f);
    }

    /// <summary>Drop any flight in progress, e.g. when the route restarts.</summary>
    public void _0x34ea0006()
    {
        if (this._0xab9cef5e != null)
        {
            this.StopCoroutine(this._0xab9cef5e);
            this._0xab9cef5e = null;
        }

        if (this._balloon != null)
            this._balloon.transform.DOKill();
    }

    /// <summary>
    /// One leg of the trip, interpolated in polar space so the balloon rides the ring
    /// instead of cutting the chord. Half way through the leg the cell underneath is
    /// told it was crossed, which is where the cloud pops and the plate flashes.
    /// </summary>
    private IEnumerator _0x065a372c(_0xe8454662 _0xefcab700, Transform _0x32a9f7cd, float _0x3317c2e9, float _0x47720800, float _0xc78ccd14, float _0x78b998d3, float _0x300a05a5, _0xa09d989b[] _0xbcfe9895, int[] _0xc4718acf, int _0xc6ae0d95, _0xf373b1d0 _0x3d9a1f91)
    {
        float _0x7cb98e48 = 0f;
        bool _0x806fb643 = false;
        while (_0x7cb98e48 < _0x300a05a5)
        {
            _0x7cb98e48 += Time.deltaTime;
            float _0xdb8346f6 = Mathf.Clamp01(_0x7cb98e48 / _0x300a05a5);
            float _0xc34599d6 = Mathf.SmoothStep(0f, 1f, _0xdb8346f6);
            _0x32a9f7cd.localPosition = Place(_0xefcab700, Mathf.Lerp(_0x3317c2e9, _0xc78ccd14, _0xc34599d6), Mathf.Lerp(_0x47720800, _0x78b998d3, _0xc34599d6));
            if (!_0x806fb643 && _0xdb8346f6 >= 0.5f)
            {
                _0x806fb643 = true;
                this._0x40458c18(_0xbcfe9895, _0xc4718acf, _0xc6ae0d95, _0x3d9a1f91);
            }

            yield return null;
        }

        _0x32a9f7cd.localPosition = Place(_0xefcab700, _0xc78ccd14, _0x78b998d3);
    }

    /// <summary>
    /// Walk the trace: outwards through every ring the balloon reaches, bending with
    /// the wind, then out to the gate - or a hard stop and a shake where a storm caught
    /// it. <paramref name = "onFinished"/> is raised once, after the last step.
    /// </summary>
    public void _0x176bec01(_0xe8454662 _0x9f2f0c4f, _0xf373b1d0 _0xc30608ec, _0x65393926 _0x7e59ae31, _0xa09d989b[] _0xc81a9290, int[] _0x8552e428, System.Action _0xbc761113)
    {
        this._0x34ea0006();
        this._0xab9cef5e = this.StartCoroutine(this._0x5be14403(_0x9f2f0c4f, _0xc30608ec, _0x7e59ae31, _0xc81a9290, _0x8552e428, _0xbc761113));
    }

    /// <summary>The renderer the board parks on the pad between routes.</summary>
    public SpriteRenderer _0xd2e60acb => this._balloon;

    /// <summary>
    /// Turn a wrapped sector index into the nearest continuous angle, so a bend from
    /// sector 7 to sector 0 sweeps one step forward instead of seven steps back.
    /// </summary>
    private float _0x97b2d7dd(float _0x3374fcdc, int _0xb0819844)
    {
        float _0x53618c33 = _0xb0819844;
        for (int _0x9df5704d = -1; _0x9df5704d <= 1; _0x9df5704d++)
        {
            float _0x5fb2aa61 = _0xb0819844 + _0x9df5704d * _0xd896e65b.Sectors;
            if (Mathf.Abs(_0x5fb2aa61 - _0x3374fcdc) < Mathf.Abs(_0x53618c33 - _0x3374fcdc))
                _0x53618c33 = _0x5fb2aa61;
        }

        return _0x53618c33;
    }

    private Coroutine _0xab9cef5e;
    [SerializeField]
    private SpriteRenderer _trailFx;
    /// <summary>Park the balloon on the pad and let it bob there.</summary>
    public void _0xa669b23b(_0xe8454662 _0x87c652e9, int _0xd069754e)
    {
        if (this._balloon == null)
            return;
        this._0x34ea0006();
        Transform _0x2dc476a8 = this._balloon.transform;
        _0x2dc476a8.DOKill();
        _0x2dc476a8.localPosition = Place(_0x87c652e9, 0f, _0xd069754e);
        this._balloon.color = Color.white;
        _0x457f4fef.SetAlpha(this._balloon, 1f);
        float _0xa619f7e8 = _0x87c652e9.OuterRadius * 0.022f;
        _0x2dc476a8.DOLocalMoveY(_0x2dc476a8.localPosition.y + _0xa619f7e8, 1.6f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private void _0x40458c18(_0xa09d989b[] _0xcbfa1446, int[] _0x30501f6a, int _0x7d6d3998, _0xf373b1d0 _0xba45c84c)
    {
        if (_0x7d6d3998 < 0 || _0xcbfa1446 == null || _0x30501f6a == null || _0x7d6d3998 >= _0xcbfa1446.Length || _0x7d6d3998 >= _0x30501f6a.Length)
            return;
        if (_0xcbfa1446[_0x7d6d3998] == null)
            return;
        _0xa10ff0de _0x3a131df2 = _0xcbfa1446[_0x7d6d3998]._0x96862690(_0xba45c84c.Angles[_0x7d6d3998], _0x30501f6a[_0x7d6d3998]);
        if (_0x3a131df2 != null)
            _0x3a131df2._0xc4c8a1ad();
        if (this._trailFx != null)
        {
            this._trailFx.transform.localPosition = this._balloon.transform.localPosition;
            _0x457f4fef.SetAlpha(this._trailFx, 0.85f);
            this._trailFx.DOFade(0f, 0.45f);
        }
    }

    private IEnumerator _0x5be14403(_0xe8454662 _0x3975e58e, _0xf373b1d0 _0x5777f7a4, _0x65393926 _0x180fd992, _0xa09d989b[] _0xd96c1be1, int[] _0x6de135f7, System.Action _0x5ad32308)
    {
        Transform _0xa296ead3 = this._balloon == null ? null : this._balloon.transform;
        if (_0xa296ead3 == null || _0x5777f7a4 == null || _0x180fd992 == null)
        {
            if (_0x5ad32308 != null)
                _0x5ad32308();
            yield break;
        }

        _0xa296ead3.DOKill();
        float _0x9f1d8563 = 0f;
        float _0x30bb32b5 = _0x5777f7a4.Angles[0];
        int _0x223d4f95 = _0x5777f7a4.StoppedRing >= 0 ? _0x5777f7a4.StoppedRing : _0xd896e65b.Rings - 1;
        for (int _0x38b8b0e5 = 0; _0x38b8b0e5 <= _0x223d4f95; _0x38b8b0e5++)
        {
            bool _0x931ddb8a = _0x5777f7a4.StoppedRing == _0x38b8b0e5;
            float _0xd5ac2dd2 = _0x931ddb8a ? _0x3975e58e.Middle[_0x38b8b0e5] : _0x3975e58e.Outer[_0x38b8b0e5];
            float _0x1dd51a84 = _0x931ddb8a ? _0x30bb32b5 : this._0x97b2d7dd(_0x30bb32b5, _0x5777f7a4.Angles[_0x38b8b0e5 + 1]);
            yield return this._0x065a372c(_0x3975e58e, _0xa296ead3, _0x9f1d8563, _0x30bb32b5, _0xd5ac2dd2, _0x1dd51a84, _0xd896e65b.FlightSegmentSeconds, _0xd96c1be1, _0x6de135f7, _0x38b8b0e5, _0x5777f7a4);
            _0x9f1d8563 = _0xd5ac2dd2;
            _0x30bb32b5 = _0x1dd51a84;
        }

        if (_0x5777f7a4.StoppedRing >= 0)
        {
            _0xa296ead3.DOShakePosition(0.35f, _0x3975e58e.OuterRadius * 0.05f, 18);
            if (this._balloon != null)
            {
                this._balloon.color = _0xe65c236a.Danger;
                this._balloon.DOFade(0.25f, 0.25f).SetDelay(0.35f);
            }

            yield return new WaitForSeconds(0.6f);
        }
        else
        {
            yield return this._0x065a372c(_0x3975e58e, _0xa296ead3, _0x9f1d8563, _0x30bb32b5, _0x3975e58e.OuterRadius * _0xd896e65b.GateRadiusFraction, _0x30bb32b5, _0xd896e65b.FlightExitSeconds, _0xd96c1be1, _0x6de135f7, -1, _0x5777f7a4);
        }

        if (_0x5ad32308 != null)
            _0x5ad32308();
    }
}