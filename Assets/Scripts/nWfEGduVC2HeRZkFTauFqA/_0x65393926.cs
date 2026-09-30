using UnityEngine;

/// <summary>What a cell does to a balloon crossing its ring.</summary>
public enum _0xb707c4c5
{
    /// <summary>Straight out: the balloon keeps its sector.</summary>
    Steady = 0,
    /// <summary>A ribbon that carries the balloon one sector clockwise.</summary>
    Clockwise = 1,
    /// <summary>A ribbon that carries the balloon one sector counter-clockwise.</summary>
    Counter = 2,
    /// <summary>A storm cell. Whatever else is true, the route ends here.</summary>
    Squall = 3,
}

/// <summary>How a flight ended.</summary>
public enum _0xae4b601f
{
    Locked = 0,
    Squalled = 1,
    OffGate = 2,
    ShortOfClouds = 3,
}

/// <summary>
/// One board, fully described: what sits in every cell, where the pad and the gate
/// point, and the ring offsets the player starts from. Plain data, no behaviour, so
/// the generator, the solver and the views all read the same thing.
/// </summary>
public sealed class _0x65393926
{
    /// <summary>The seed the board was built from, so a board can be reproduced.</summary>
    public int Seed;
    /// <summary>Which slot of ring k currently sits under the physical sector angle.</summary>
    public static int SlotUnder(int _0x8a611345, int _0xa29590b6)
    {
        return ((_0x8a611345 - _0xa29590b6) % _0xd896e65b.Sectors + _0xd896e65b.Sectors) % _0xd896e65b.Sectors;
    }

    /// <summary>How far a kind pushes the balloon around the board.</summary>
    public static int Deflection(_0xb707c4c5 _0xa6426a6c)
    {
        if (_0xa6426a6c == _0xb707c4c5.Clockwise)
            return 1;
        if (_0xa6426a6c == _0xb707c4c5.Counter)
            return -1;
        return 0;
    }

    public int StartAngle;
    /// <summary>Shortest number of ring turns from <see cref = "Rotations"/> to a win.</summary>
    public int Depth;
    /// <summary>[ring][slot] - what the cell is.</summary>
    public _0xb707c4c5[][] Kinds;
    public int CloudTotal;
    public int GateAngle;
    /// <summary>Ring offsets the route starts scrambled to.</summary>
    public int[] Rotations = new int[_0xd896e65b.Rings];
    public _0x65393926()
    {
        this.Kinds = new _0xb707c4c5[_0xd896e65b.Rings][];
        this.Clouds = new bool[_0xd896e65b.Rings][];
        for (int _0xa23414b4 = 0; _0xa23414b4 < _0xd896e65b.Rings; _0xa23414b4++)
        {
            this.Kinds[_0xa23414b4] = new _0xb707c4c5[_0xd896e65b.Sectors];
            this.Clouds[_0xa23414b4] = new bool[_0xd896e65b.Sectors];
        }
    }

    /// <summary>[ring][slot] - whether a check cloud rides on that cell.</summary>
    public bool[][] Clouds;
}

/// <summary>Where the balloon went and why it stopped.</summary>
public sealed class _0xf373b1d0
{
    public int CloudsPassed;
    public _0xae4b601f Result;
    /// <summary>Ring the storm caught it on, or -1 when it flew clear.</summary>
    public int StoppedRing = -1;
    /// <summary>Sector the balloon occupies entering ring 0, 1, 2 and leaving the field.</summary>
    public int[] Angles = new int[_0xd896e65b.Rings + 1];
}

/// <summary>
/// The rules of a flight, with no Unity in them: walk the three rings from the pad
/// outwards and report what happened. The same routine answers "what does LAUNCH do
/// right now" and "how many turns is this board from a win", so the number the HUD
/// promises and the number the generator built for can never disagree.
/// </summary>
public sealed class _0xcac53a8e
{
    /// <summary>
    /// Cheapest number of taps that turns the given board into a win, or -1 if no
    /// arrangement of the three rings wins at all. A tap only ever moves a ring one
    /// sector clockwise, so the cost of reaching an offset is the clockwise distance -
    /// which makes the whole space 8 x 8 x 8 states and exhaustively checkable.
    /// </summary>
    public int _0x2373b971(_0x65393926 _0x12a28d56, int[] _0xe9697db7)
    {
        if (_0x12a28d56 == null || _0xe9697db7 == null)
            return -1;
        int _0x813496f9 = -1;
        int[] _0x7c6d452c = new int[_0xd896e65b.Rings];
        for (int _0x0b0099ca = 0; _0x0b0099ca < _0xd896e65b.Sectors; _0x0b0099ca++)
        {
            for (int _0x5acea0ee = 0; _0x5acea0ee < _0xd896e65b.Sectors; _0x5acea0ee++)
            {
                for (int _0x29430c15 = 0; _0x29430c15 < _0xd896e65b.Sectors; _0x29430c15++)
                {
                    _0x7c6d452c[0] = _0x0b0099ca;
                    _0x7c6d452c[1] = _0x5acea0ee;
                    _0x7c6d452c[2] = _0x29430c15;
                    if (this._0xb89a9663(_0x12a28d56, _0x7c6d452c).Result != _0xae4b601f.Locked)
                        continue;
                    int _0xeb4610b1 = Distance(_0xe9697db7[0], _0x0b0099ca) + Distance(_0xe9697db7[1], _0x5acea0ee) + Distance(_0xe9697db7[2], _0x29430c15);
                    if (_0x813496f9 < 0 || _0xeb4610b1 < _0x813496f9)
                        _0x813496f9 = _0xeb4610b1;
                }
            }
        }

        return _0x813496f9;
    }

    /// <summary>Screen-safe sector label, used by the pause card.</summary>
    public static string SectorLabel(int _0x35e7d02d)
    {
        return Mathf.Clamp(_0x35e7d02d, 0, _0xd896e65b.Sectors - 1).ToString();
    }

    /// <summary>Clockwise taps needed to move a ring from one offset to another.</summary>
    public static int Distance(int _0x14268589, int _0xf3994c80)
    {
        return ((_0xf3994c80 - _0x14268589) % _0xd896e65b.Sectors + _0xd896e65b.Sectors) % _0xd896e65b.Sectors;
    }

    /// <summary>Human-readable reason a route failed, for the result card.</summary>
    public static string Reason(_0xae4b601f _0x8364b86e)
    {
        if (_0x8364b86e == _0xae4b601f.Squalled)
            return _0x30a11979._0xa3df5204(new byte[17] { 205, 202, 209, 204, 211, 190, 209, 208, 190, 202, 214, 219, 190, 210, 215, 208, 219 }, 158);
        if (_0x8364b86e == _0xae4b601f.ShortOfClouds)
            return _0x30a11979._0xa3df5204(new byte[23] { 225, 128, 227, 236, 239, 245, 228, 128, 247, 225, 243, 128, 236, 229, 230, 244, 128, 226, 229, 232, 233, 238, 228 }, 160);
        return _0x30a11979._0xa3df5204(new byte[24] { 7, 27, 22, 115, 4, 26, 29, 23, 115, 30, 26, 0, 0, 22, 23, 115, 7, 27, 22, 115, 20, 18, 7, 22 }, 83);
    }

    /// <summary>Fly the current board and describe the trip.</summary>
    public _0xf373b1d0 _0xb89a9663(_0x65393926 _0x0635a288, int[] _0xe4b85a32)
    {
        _0xf373b1d0 _0xd339efea = new _0xf373b1d0();
        if (_0x0635a288 == null || _0xe4b85a32 == null)
        {
            _0xd339efea.Result = _0xae4b601f.OffGate;
            return _0xd339efea;
        }

        int _0x8018a6c2 = _0x0635a288.StartAngle;
        for (int _0x7ecf72f3 = 0; _0x7ecf72f3 < _0xd896e65b.Rings; _0x7ecf72f3++)
        {
            _0xd339efea.Angles[_0x7ecf72f3] = _0x8018a6c2;
            int _0xcd288a1a = _0x65393926.SlotUnder(_0x8018a6c2, _0xe4b85a32[_0x7ecf72f3]);
            _0xb707c4c5 _0xd060e7fa = _0x0635a288.Kinds[_0x7ecf72f3][_0xcd288a1a];
            if (_0xd060e7fa == _0xb707c4c5.Squall)
            {
                _0xd339efea.Result = _0xae4b601f.Squalled;
                _0xd339efea.StoppedRing = _0x7ecf72f3;
                return _0xd339efea;
            }

            if (_0x0635a288.Clouds[_0x7ecf72f3][_0xcd288a1a])
                _0xd339efea.CloudsPassed++;
            _0x8018a6c2 = ((_0x8018a6c2 + _0x65393926.Deflection(_0xd060e7fa)) % _0xd896e65b.Sectors + _0xd896e65b.Sectors) % _0xd896e65b.Sectors;
        }

        _0xd339efea.Angles[_0xd896e65b.Rings] = _0x8018a6c2;
        if (_0x8018a6c2 != _0x0635a288.GateAngle)
            _0xd339efea.Result = _0xae4b601f.OffGate;
        else if (_0xd339efea.CloudsPassed != _0x0635a288.CloudTotal)
            _0xd339efea.Result = _0xae4b601f.ShortOfClouds;
        else
            _0xd339efea.Result = _0xae4b601f.Locked;
        return _0xd339efea;
    }
}

internal static class _0x30a11979
{
    internal static string _0xa3df5204(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}