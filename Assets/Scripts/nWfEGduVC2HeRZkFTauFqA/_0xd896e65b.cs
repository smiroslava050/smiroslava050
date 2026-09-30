using UnityEngine;

/// <summary>
/// Every tunable number of the wind-ring puzzle in one place: the board proportions
/// (all expressed as fractions of the camera, never as world constants), the sorting
/// band the art may occupy, the difficulty ladder and the scoring.
/// </summary>
public static class _0xd896e65b
{
    public const int OrderStorm = -12;
    /// <summary>Board centre above the screen centre, as a fraction of half the height.</summary>
    public const float FieldRiseFraction = 0.11f;
    public static readonly int[] CloudCount =
    {
        1,
        2,
        2,
        3,
        3,
        3
    };
    public const int OrderCloud = -11;
    public const float HintDimAlpha = 0.62f;
    public const int OrderGate = -10;
    /// <summary>Lowest and highest turn budget, whatever the ladder asks for.</summary>
    public const int TurnBudgetFloor = 6;
    public const int OrderCell = -15;
    /// <summary>How long one ring takes to swing round by a sector.</summary>
    public const float RingTurnSeconds = 0.28f;
    public const int OrderGlyph = -13;
    public const int TurnBudgetCeiling = 14;
    /// <summary>Inner edge of each ring, as a fraction of the field's outer radius.</summary>
    public static readonly float[] RingInnerFraction =
    {
        0.20f,
        0.47f,
        0.74f
    };
    /// <summary>How many routes the menu rail can show before it summarises.</summary>
    public const int RailCapacity = 7;
    // ── scoring ─────────────────────────────────────────────────────────────
    public const int MilesPerCloud = 120;
    /// <summary>Rings between the launch pad and the sky gate.</summary>
    public const int Rings = 3;
    /// <summary>Degrees one sector spans.</summary>
    public const float SectorDegrees = 360f / Sectors;
    /// <summary>Glyph size as a fraction of the smaller cell dimension.</summary>
    public const float GlyphFill = 0.62f;
    /// <summary>The gate sits just outside the field's outer radius.</summary>
    public const float GateRadiusFraction = 1.08f;
    public static readonly int[] CurveCount =
    {
        4,
        5,
        6,
        7,
        9,
        10
    };
    /// <summary>How much of its own slot a cell plate fills, along the arc and radially.</summary>
    public const float CellArcFill = 0.93f;
    /// <summary>Grace after the last turn is spent before the route launches itself.</summary>
    public const float AutoLaunchSeconds = 1.2f;
    public static readonly int[] DepthMax =
    {
        2,
        3,
        3,
        4,
        5,
        6
    };
    public const int OrderBalloon = -8;
    // ── board shape ─────────────────────────────────────────────────────────
    /// <summary>Sectors per ring. The whole model is modulo this number.</summary>
    public const int Sectors = 8;
    // ── difficulty ladder ───────────────────────────────────────────────────
    // Row 0 is the first route. Counts come from here; POSITIONS come from the
    // generator, so two attempts at the same route never look the same.
    public static readonly int[] StormCount =
    {
        2,
        3,
        4,
        5,
        6,
        7
    };
    /// <summary>Pause between the balloon settling and the result card.</summary>
    public const float ResolveSeconds = 0.45f;
    public const int OrderHub = -9;
    /// <summary>Outer edge of each ring, as a fraction of the field's outer radius.</summary>
    public static readonly float[] RingOuterFraction =
    {
        0.47f,
        0.74f,
        1.00f
    };
    /// <summary>Turn budget for a route whose shortest solution is depth turns long.</summary>
    public static int TurnBudget(int _0xb5ab9308, int _0x38145818)
    {
        int _0x4d6877fa = Row(_0xb5ab9308);
        return Mathf.Clamp(_0x38145818 + TurnSlack[_0x4d6877fa], TurnBudgetFloor, TurnBudgetCeiling);
    }

    /// <summary>Which ladder row a route index falls in.</summary>
    public static int Row(int _0xa4b2565a)
    {
        if (_0xa4b2565a <= 0)
            return 0;
        if (_0xa4b2565a == 1)
            return 1;
        if (_0xa4b2565a == 2)
            return 2;
        if (_0xa4b2565a <= 4)
            return 3;
        if (_0xa4b2565a <= 7)
            return 4;
        return 5;
    }

    public static readonly int[] TurnSlack =
    {
        6,
        6,
        5,
        5,
        4,
        4
    };
    // ── timing ──────────────────────────────────────────────────────────────
    /// <summary>One ring of the flight, in seconds.</summary>
    public const float FlightSegmentSeconds = 0.70f;
    public static readonly int[] DepthMin =
    {
        1,
        2,
        2,
        3,
        4,
        4
    };
    /// <summary>The last leg, from the outer ring out to the gate.</summary>
    public const float FlightExitSeconds = 0.60f;
    public const int MilesPerRoute = 200;
    // ── sorting band ────────────────────────────────────────────────────────
    // The background canvas draws at -30 and the result pops at 10 and above, so all
    // world art has to live strictly between them. These are the only numbers any
    // renderer may be given; nothing picks an order at the call site.
    public const int OrderBackdrop = -19;
    public const int MilesPerSpareTurn = 25;
    /// <summary>The control hint stays fully opaque this long, then dims (never to zero).</summary>
    public const float HintSolidSeconds = 6f;
    public const int OrderRingRim = -18;
    public const float CellBandFill = 0.94f;
    /// <summary>Outer radius of the play field, as a fraction of half the screen width.</summary>
    public const float FieldWidthFraction = 0.89f;
    public const int OrderSpark = -5;
}