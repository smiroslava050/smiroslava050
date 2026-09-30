using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Builds a board CONSTRUCTIVELY: it picks a winning flight first - where the pad
/// points, where the gate is, and which way the wind bends on each of the three rings
/// - lays the matching cells down so that flight works, and only then scatters the
/// storms and the filler around it. Nothing is hand-placed, so two attempts at the
/// same route differ in pad, gate, route shape, cloud positions and storm positions,
/// not merely in a number on the HUD.
///
/// Because the win is built in rather than searched for, "is it solvable" is never in
/// doubt; the exhaustive 8x8x8 pass afterwards is there to CALIBRATE - it measures how
/// many taps the shortest solution really costs and rejects a board that came out
/// easier or harder than this route is supposed to be.
/// </summary>
public sealed class _0x7f5352cb
{
    private const int MaxAttempts = 20;
    /// <summary>
    /// Three bends of -1, 0 or +1 that add up to the walk from the pad to the gate.
    /// If a draw cannot reach the gate the gate MOVES to meet it rather than the
    /// generator giving up - that keeps the board varied and always winnable.
    /// </summary>
    private int[] _0xeb55cf6a(System.Random _0x22e77ce5, int _0x5bbcde82, ref int _0xa5ce51a3)
    {
        for (int _0x3a37497c = 0; _0x3a37497c < MaxRouteRetries; _0x3a37497c++)
        {
            int _0x866821d9 = _0x22e77ce5.Next(-1, 2);
            int _0xd0d06639 = _0x22e77ce5.Next(-1, 2);
            int _0xcc41e3fb = ((_0xa5ce51a3 - _0x5bbcde82 - _0x866821d9 - _0xd0d06639) % _0xd896e65b.Sectors + _0xd896e65b.Sectors) % _0xd896e65b.Sectors;
            if (_0xcc41e3fb == 0)
                return new[]
                {
                    _0x866821d9,
                    _0xd0d06639,
                    0
                };
            if (_0xcc41e3fb == 1)
                return new[]
                {
                    _0x866821d9,
                    _0xd0d06639,
                    1
                };
            if (_0xcc41e3fb == _0xd896e65b.Sectors - 1)
                return new[]
                {
                    _0x866821d9,
                    _0xd0d06639,
                    -1
                };
        }

        int _0x24d72fa6 = _0x22e77ce5.Next(-1, 2);
        int _0xd9e20aa2 = _0x22e77ce5.Next(-1, 2);
        int _0x0e8de367 = _0x22e77ce5.Next(-1, 2);
        _0xa5ce51a3 = ((_0x5bbcde82 + _0x24d72fa6 + _0xd9e20aa2 + _0x0e8de367) % _0xd896e65b.Sectors + _0xd896e65b.Sectors) % _0xd896e65b.Sectors;
        return new[]
        {
            _0x24d72fa6,
            _0xd9e20aa2,
            _0x0e8de367
        };
    }

    private static void ShuffleList(System.Random _0x5b3cb2fe, List<int> _0xa11f6904)
    {
        for (int _0x7b4b3c48 = _0xa11f6904.Count - 1; _0x7b4b3c48 > 0; _0x7b4b3c48--)
        {
            int _0x57109d5d = _0x5b3cb2fe.Next(_0x7b4b3c48 + 1);
            int _0xc7993064 = _0xa11f6904[_0x7b4b3c48];
            _0xa11f6904[_0x7b4b3c48] = _0xa11f6904[_0x57109d5d];
            _0xa11f6904[_0x57109d5d] = _0xc7993064;
        }
    }

    private static void Place(_0x65393926 _0x97b54ed9, int _0x699509ef, _0xb707c4c5 _0xb20ef941)
    {
        _0x97b54ed9.Kinds[_0x699509ef / _0xd896e65b.Sectors][_0x699509ef % _0xd896e65b.Sectors] = _0xb20ef941;
    }

    // ── small helpers ───────────────────────────────────────────────────────
    private static _0xb707c4c5 KindFor(int _0x70094208)
    {
        if (_0x70094208 > 0)
            return _0xb707c4c5.Clockwise;
        if (_0x70094208 < 0)
            return _0xb707c4c5.Counter;
        return _0xb707c4c5.Steady;
    }

    private static void Shuffle(System.Random _0x7097b1d7, int[] _0xbd75a728)
    {
        for (int _0x6ae5ac28 = _0xbd75a728.Length - 1; _0x6ae5ac28 > 0; _0x6ae5ac28--)
        {
            int _0xca7ccc2a = _0x7097b1d7.Next(_0x6ae5ac28 + 1);
            int _0xe47ee17f = _0xbd75a728[_0x6ae5ac28];
            _0xbd75a728[_0x6ae5ac28] = _0xbd75a728[_0xca7ccc2a];
            _0xbd75a728[_0xca7ccc2a] = _0xe47ee17f;
        }
    }

    /// <summary>
    /// A board for this route index and this attempt. Deterministic: the same three
    /// inputs always rebuild the same board, which is what makes a reported seed worth
    /// logging.
    /// </summary>
    public _0x65393926 _0x4f104ac7(int _0x9516054c, int _0x96f5c9ec, int _0x7b76c651)
    {
        int _0xb201b8a5 = _0xd896e65b.Row(_0x9516054c);
        int _0x173b37fb = (_0x9516054c * 7919) ^ (_0x96f5c9ec * 104729) ^ (_0x7b76c651 * 31337);
        for (int _0x4339e095 = 0; _0x4339e095 < MaxAttempts; _0x4339e095++)
        {
            // System.Random, never UnityEngine.Random: the latter is one global stream
            // that anything else in the game can advance, and then the same seed stops
            // meaning the same board.
            System.Random _0xbf23e05c = new System.Random(_0x173b37fb + _0x4339e095 * 7717);
            _0x65393926 _0xaa47feab = this._0x35f5012a(_0xbf23e05c, _0xb201b8a5);
            _0xaa47feab.Seed = _0x173b37fb + _0x4339e095 * 7717;
            int _0x53dd0c2a = this._0x39be605b._0x2373b971(_0xaa47feab, _0xaa47feab.Rotations);
            if (_0x53dd0c2a >= 1 && _0x53dd0c2a <= _0xd896e65b.DepthMax[_0xb201b8a5])
            {
                _0xaa47feab.Depth = _0x53dd0c2a;
                {
#if B_LOGS
                    {
                        Debug.Log($"[route] index={_0x9516054c} attempt={_0x96f5c9ec} seed={_0xaa47feab.Seed} depth={_0x53dd0c2a} clouds={_0xaa47feab.CloudTotal}");
                    }
#endif
                }

                return _0xaa47feab;
            }
        }

        _0x65393926 _0x55b2c5d4 = this._0x1352f09f();
        _0x55b2c5d4.Depth = Mathf.Max(1, this._0x39be605b._0x2373b971(_0x55b2c5d4, _0x55b2c5d4.Rotations));
        {
#if B_LOGS
            {
                Debug.Log($"[route] index={_0x9516054c} attempt={_0x96f5c9ec} fell back to the safety board depth={_0x55b2c5d4.Depth}");
            }
#endif
        }

        return _0x55b2c5d4;
    }

    private readonly _0xcac53a8e _0x39be605b = new _0xcac53a8e();
    // ── construction ────────────────────────────────────────────────────────
    private _0x65393926 _0x35f5012a(System.Random _0xb0b3e261, int _0x22e3c4d9)
    {
        _0x65393926 _0x6271dcad = new _0x65393926();
        _0x6271dcad.StartAngle = _0xb0b3e261.Next(_0xd896e65b.Sectors);
        _0x6271dcad.GateAngle = _0xb0b3e261.Next(_0xd896e65b.Sectors);
        int[] _0x59e37d4e = new int[_0xd896e65b.Rings];
        for (int _0xbee9a86e = 0; _0xbee9a86e < _0xd896e65b.Rings; _0xbee9a86e++)
            _0x59e37d4e[_0xbee9a86e] = _0xb0b3e261.Next(_0xd896e65b.Sectors);
        int[] _0x94a32529 = this._0xeb55cf6a(_0xb0b3e261, _0x6271dcad.StartAngle, ref _0x6271dcad.GateAngle);
        // Lay the winning flight down: at the solved offsets, the cell the balloon
        // meets on ring k is exactly the one that bends it the way the flight needs.
        int[] _0x00974a58 = new int[_0xd896e65b.Rings];
        int _0x068ddc3e = _0x6271dcad.StartAngle;
        for (int _0x89181f88 = 0; _0x89181f88 < _0xd896e65b.Rings; _0x89181f88++)
        {
            int _0x5424c06a = _0x65393926.SlotUnder(_0x068ddc3e, _0x59e37d4e[_0x89181f88]);
            _0x00974a58[_0x89181f88] = _0x5424c06a;
            _0x6271dcad.Kinds[_0x89181f88][_0x5424c06a] = KindFor(_0x94a32529[_0x89181f88]);
            _0x068ddc3e = ((_0x068ddc3e + _0x94a32529[_0x89181f88]) % _0xd896e65b.Sectors + _0xd896e65b.Sectors) % _0xd896e65b.Sectors;
        }

        // Clouds ride ONLY on route cells, so every one of them is reachable by
        // construction and "pass every cloud" is never an impossible demand.
        int _0x0de0f63a = Mathf.Clamp(_0xd896e65b.CloudCount[_0x22e3c4d9], 1, _0xd896e65b.Rings);
        int[] _0x2d2da286 =
        {
            0,
            1,
            2
        };
        Shuffle(_0xb0b3e261, _0x2d2da286);
        for (int _0xa652e32a = 0; _0xa652e32a < _0x0de0f63a; _0xa652e32a++)
        {
            int _0x2ac92b6a = _0x2d2da286[_0xa652e32a];
            _0x6271dcad.Clouds[_0x2ac92b6a][_0x00974a58[_0x2ac92b6a]] = true;
        }

        _0x6271dcad.CloudTotal = _0x0de0f63a;
        // Everything that is not on the winning flight is free to be weather.
        List<int> _0xa7799e7b = new List<int>();
        for (int _0x000c747c = 0; _0x000c747c < _0xd896e65b.Rings; _0x000c747c++)
        {
            for (int _0x55304e76 = 0; _0x55304e76 < _0xd896e65b.Sectors; _0x55304e76++)
            {
                if (_0x55304e76 == _0x00974a58[_0x000c747c])
                    continue;
                _0xa7799e7b.Add(_0x000c747c * _0xd896e65b.Sectors + _0x55304e76);
            }
        }

        ShuffleList(_0xb0b3e261, _0xa7799e7b);
        int _0x6c8d4420 = 0;
        int _0x22ec4977 = Mathf.Clamp(_0xd896e65b.StormCount[_0x22e3c4d9], 0, _0xa7799e7b.Count - 2);
        for (int _0x84c6efe8 = 0; _0x84c6efe8 < _0x22ec4977 && _0x6c8d4420 < _0xa7799e7b.Count; _0x84c6efe8++, _0x6c8d4420++)
            Place(_0x6271dcad, _0xa7799e7b[_0x6c8d4420], _0xb707c4c5.Squall);
        int _0xe9d620f6 = 0;
        for (int _0xabc6f205 = 0; _0xabc6f205 < _0xd896e65b.Rings; _0xabc6f205++)
        {
            if (_0x94a32529[_0xabc6f205] != 0)
                _0xe9d620f6++;
        }

        int _0x894d0425 = Mathf.Clamp(_0xd896e65b.CurveCount[_0x22e3c4d9] - _0xe9d620f6, 0, _0xa7799e7b.Count - _0x6c8d4420);
        for (int _0x8519ba31 = 0; _0x8519ba31 < _0x894d0425 && _0x6c8d4420 < _0xa7799e7b.Count; _0x8519ba31++, _0x6c8d4420++)
            Place(_0x6271dcad, _0xa7799e7b[_0x6c8d4420], _0xb0b3e261.Next(2) == 0 ? _0xb707c4c5.Clockwise : _0xb707c4c5.Counter);
        for (; _0x6c8d4420 < _0xa7799e7b.Count; _0x6c8d4420++)
            Place(_0x6271dcad, _0xa7799e7b[_0x6c8d4420], _0xb707c4c5.Steady);
        // Scramble by a chosen amount: the depth is SET here, not discovered, and the
        // solver pass in Build only confirms it.
        int _0x99b5058c = _0xb0b3e261.Next(_0xd896e65b.DepthMin[_0x22e3c4d9], _0xd896e65b.DepthMax[_0x22e3c4d9] + 1);
        int[] _0xc0b37b2f = new int[_0xd896e65b.Rings];
        for (int _0xd08e5812 = 0; _0xd08e5812 < _0x99b5058c; _0xd08e5812++)
        {
            int _0x1286804a = _0xb0b3e261.Next(_0xd896e65b.Rings);
            for (int _0x256f15fc = 0; _0x256f15fc < _0xd896e65b.Rings && _0xc0b37b2f[_0x1286804a] >= _0xd896e65b.Sectors - 1; _0x256f15fc++)
                _0x1286804a = (_0x1286804a + 1) % _0xd896e65b.Rings;
            _0xc0b37b2f[_0x1286804a]++;
        }

        for (int _0xb2ca2887 = 0; _0xb2ca2887 < _0xd896e65b.Rings; _0xb2ca2887++)
            _0x6271dcad.Rotations[_0xb2ca2887] = ((_0x59e37d4e[_0xb2ca2887] - _0xc0b37b2f[_0xb2ca2887]) % _0xd896e65b.Sectors + _0xd896e65b.Sectors) % _0xd896e65b.Sectors;
        return _0x6271dcad;
    }

    private const int MaxRouteRetries = 8;
    /// <summary>
    /// The one hand-written board in the project, and it is insurance, not content:
    /// the constructive builder above has to fail twenty times in a row before anyone
    /// ever sees it.
    /// </summary>
    private _0x65393926 _0x1352f09f()
    {
        _0x65393926 _0x15f7e108 = new _0x65393926();
        _0x15f7e108.StartAngle = 0;
        _0x15f7e108.GateAngle = 2;
        _0x15f7e108.CloudTotal = 1;
        for (int _0xf2c73b2c = 0; _0xf2c73b2c < _0xd896e65b.Rings; _0xf2c73b2c++)
        {
            for (int _0xcba94a79 = 0; _0xcba94a79 < _0xd896e65b.Sectors; _0xcba94a79++)
                _0x15f7e108.Kinds[_0xf2c73b2c][_0xcba94a79] = _0xb707c4c5.Steady;
        }

        _0x15f7e108.Kinds[0][0] = _0xb707c4c5.Clockwise;
        _0x15f7e108.Kinds[1][1] = _0xb707c4c5.Clockwise;
        _0x15f7e108.Kinds[2][2] = _0xb707c4c5.Steady;
        _0x15f7e108.Clouds[0][0] = true;
        _0x15f7e108.Kinds[0][4] = _0xb707c4c5.Squall;
        _0x15f7e108.Kinds[1][5] = _0xb707c4c5.Squall;
        _0x15f7e108.Kinds[2][6] = _0xb707c4c5.Squall;
        _0x15f7e108.Rotations[0] = _0xd896e65b.Sectors - 1;
        _0x15f7e108.Rotations[1] = 0;
        _0x15f7e108.Rotations[2] = 0;
        return _0x15f7e108;
    }
}