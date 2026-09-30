using DG.Tweening;
using UnityEngine;

/// <summary>
/// One wind ring: a glowing rim and the eight cells sitting on it. The ring itself is
/// what turns - one tap swings the whole object a sector clockwise - so a cell keeps
/// its slot for ever and only the angle it is seen at changes. That is exactly the
/// model the solver uses, which is why the picture and the simulation cannot drift
/// apart.
/// </summary>
public sealed class _0xa09d989b : MonoBehaviour
{
    /// <summary>Dim the ring while a flight is in the air.</summary>
    public void _0x23f6ee8d(bool _0x77fc6c09)
    {
        for (int _0x46e05685 = 0; _0x46e05685 < this._cells.Length; _0x46e05685++)
        {
            if (this._cells[_0x46e05685] != null)
                this._cells[_0x46e05685]._0xd835cfac(_0x77fc6c09);
        }
    }

    /// <summary>Fade the rim and cascade the cells in when the board first appears.</summary>
    public void _0xa61d2ca1(float _0xb6ecc489)
    {
        if (this._rim != null)
        {
            _0x457f4fef.SetAlpha(this._rim, 0f);
            this._rim.DOFade(0.55f, 0.25f).SetDelay(_0xb6ecc489);
        }

        for (int _0x1ef0b5d7 = 0; _0x1ef0b5d7 < this._cells.Length; _0x1ef0b5d7++)
        {
            if (this._cells[_0x1ef0b5d7] != null)
                this._cells[_0x1ef0b5d7]._0x216ed712(_0xb6ecc489 + _0x1ef0b5d7 * 0.03f);
        }
    }

    /// <summary>Swing the ring one sector clockwise - the answer to a tap.</summary>
    public void _0x546350ba()
    {
        this.transform.DOKill(true);
        this.transform.DOLocalRotate(new Vector3(0f, 0f, -_0xd896e65b.SectorDegrees), _0xd896e65b.RingTurnSeconds, RotateMode.LocalAxisAdd).SetEase(Ease.OutBack);
    }

    [SerializeField]
    private SpriteRenderer _rim;
    /// <summary>Drop the ring in place at a given offset, with no animation.</summary>
    public void _0x79993a6c(int _0x5ebafc1d)
    {
        this.transform.DOKill();
        this.transform.localRotation = Quaternion.Euler(0f, 0f, -_0x5ebafc1d * _0xd896e65b.SectorDegrees);
    }

    /// <summary>The cell currently sitting under a physical sector angle.</summary>
    public _0xa10ff0de _0x96862690(int _0x79862233, int _0xe4928dca)
    {
        int _0x56c2b48f = _0x65393926.SlotUnder(_0x79862233, _0xe4928dca);
        if (_0x56c2b48f < 0 || _0x56c2b48f >= this._cells.Length)
            return null;
        return this._cells[_0x56c2b48f];
    }

    /// <summary>Dress every cell from the layout's row for this ring.</summary>
    public void _0xe6026360(_0xff4a3fa2 _0x711bbc42, _0x65393926 _0xadfa4e53)
    {
        if (_0xadfa4e53 == null)
            return;
        for (int _0xa1a40f05 = 0; _0xa1a40f05 < this._cells.Length; _0xa1a40f05++)
        {
            if (this._cells[_0xa1a40f05] == null)
                continue;
            this._cells[_0xa1a40f05]._0x2bc16719(_0x711bbc42, _0xadfa4e53.Kinds[this._0x86e7f48c][_0xa1a40f05], _0xadfa4e53.Clouds[this._0x86e7f48c][_0xa1a40f05]);
        }
    }

    [SerializeField]
    private _0xa10ff0de[] _cells = new _0xa10ff0de[_0xd896e65b.Sectors];
    /// <summary>Spawn the rim and the eight cells of ring <paramref name = "ring"/>.</summary>
    public void _0x0280e6f2(_0xff4a3fa2 _0xa9d52470, _0x95357f1a _0x07f48eb3, _0xe8454662 _0xf55606ca, int _0xaf9777b7)
    {
        this._0x86e7f48c = _0xaf9777b7;
        this._cells = new _0xa10ff0de[_0xd896e65b.Sectors];
        float _0xa96df6ff = _0xf55606ca.Outer[_0xaf9777b7] * 2f;
        this._rim = _0x457f4fef.Spawn(_0x07f48eb3.Rim, this.transform, _0xb3c42c36._0xbe085aed(new byte[3] { 201, 242, 246 }, 155), _0xa9d52470.RingRim, new Vector2(_0xa96df6ff, _0xa96df6ff), Vector2.zero, _0xd896e65b.OrderRingRim, _0xe65c236a.Fade(_0xe65c236a.Secondary, 0.55f));
        Vector2 _0x237b2dcc = _0xf55606ca._0x985d0438(_0xaf9777b7);
        float _0x0fa1a3cd = _0xf55606ca._0x6dd25cd3(_0xaf9777b7);
        for (int _0x6d4e5a23 = 0; _0x6d4e5a23 < _0xd896e65b.Sectors; _0x6d4e5a23++)
        {
            GameObject _0x624917d3 = Instantiate(_0x07f48eb3.Cell, this.transform);
            _0x624917d3.transform.localPosition = _0xe8454662.Direction(_0x6d4e5a23) * _0xf55606ca.Middle[_0xaf9777b7];
            _0x624917d3.transform.localRotation = Quaternion.Euler(0f, 0f, -_0x6d4e5a23 * _0xd896e65b.SectorDegrees);
            _0x624917d3.transform.localScale = Vector3.one;
            _0xa10ff0de _0x0fe78b15 = _0x624917d3.GetComponent<_0xa10ff0de>();
            if (_0x0fe78b15 == null)
                continue;
            _0x0fe78b15.Measure(_0x237b2dcc, _0x0fa1a3cd);
            this._cells[_0x6d4e5a23] = _0x0fe78b15;
        }
    }

    private int _0x86e7f48c;
}

internal static class _0xb3c42c36
{
    internal static string _0xbe085aed(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}