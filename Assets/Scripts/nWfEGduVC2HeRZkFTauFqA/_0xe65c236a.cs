using UnityEngine;

/// <summary>
/// The night-sky palette every generated view paints with. One place, so the board,
/// the chrome and the result cards cannot drift apart, and so the text colours can be
/// checked against the single outline colour the font material carries.
/// </summary>
public static class _0xe65c236a
{
    /// <summary>Deep night blue - the bottom of both backgrounds.</summary>
    public static readonly Color BgDeep = new Color(0.067f, 0.094f, 0.176f, 1f);
    /// <summary>The upper sky, a touch lighter and warmer than the deep tone.</summary>
    public static readonly Color BgUpper = new Color(0.102f, 0.141f, 0.271f, 1f);
    /// <summary>Second text level: captions and hints.</summary>
    public static readonly Color TextSecondary = new Color(0.624f, 0.706f, 0.847f, 1f);
    /// <summary>The same colour at a different opacity.</summary>
    public static Color Fade(Color _0xbecc908f, float _0x925a0550)
    {
        return new Color(_0xbecc908f.r, _0xbecc908f.g, _0xbecc908f.b, _0x925a0550);
    }

    /// <summary>Second surface tone: slider track, closed route nodes.</summary>
    public static readonly Color SurfaceAlt = new Color(0.106f, 0.141f, 0.251f, 1f);
    /// <summary>
    /// The colour the font material outlines every glyph with. No label may be painted
    /// close to this tone, or the letter fills into its own outline.
    /// </summary>
    public static readonly Color Ink = new Color(0.039f, 0.059f, 0.122f, 1f);
    /// <summary>Third text level: locked or inactive rows.</summary>
    public static readonly Color TextMuted = new Color(0.361f, 0.427f, 0.573f, 1f);
    /// <summary>Glass surface for cards and plates.</summary>
    public static readonly Color Surface = new Color(0.086f, 0.125f, 0.227f, 1f);
    /// <summary>Sky violet - depth, gradients, far parallax.</summary>
    public static readonly Color Secondary = new Color(0.467f, 0.318f, 0.788f, 1f);
    /// <summary>Wind cyan - the primary accent.</summary>
    public static readonly Color Primary = new Color(0.212f, 0.776f, 0.933f, 1f);
    /// <summary>Brightest text: headings and values.</summary>
    public static readonly Color TextPrimary = new Color(0.957f, 0.969f, 1f, 1f);
    /// <summary>Mix two palette tones, for glows and highlight states.</summary>
    public static Color Mix(Color _0x305aa1ee, Color _0x8d156fd6, float _0x33ff0512)
    {
        float _0xf8d8b9f2 = Mathf.Clamp01(_0x33ff0512);
        return new Color(Mathf.Lerp(_0x305aa1ee.r, _0x8d156fd6.r, _0xf8d8b9f2), Mathf.Lerp(_0x305aa1ee.g, _0x8d156fd6.g, _0xf8d8b9f2), Mathf.Lerp(_0x305aa1ee.b, _0x8d156fd6.b, _0xf8d8b9f2), Mathf.Lerp(_0x305aa1ee.a, _0x8d156fd6.a, _0xf8d8b9f2));
    }

    /// <summary>Warm gold - check clouds, the gate, the launch action, miles.</summary>
    public static readonly Color Gold = new Color(0.953f, 0.757f, 0.298f, 1f);
    /// <summary>Storm red - hazards, the last turns, a lost route.</summary>
    public static readonly Color Danger = new Color(0.914f, 0.290f, 0.404f, 1f);
}