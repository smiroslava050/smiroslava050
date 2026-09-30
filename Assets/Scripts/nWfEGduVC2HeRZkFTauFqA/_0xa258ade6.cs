using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xa258ade6 : MonoBehaviour
{
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x580ec621;
    private void OnDisable()
    {
        if (this._0x580ec621 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x580ec621);
    }

    private const float TargetRatio = 7f;
    private readonly HashSet<TMP_Text> _0x4afd660c = new HashSet<TMP_Text>();
    private void LateUpdate()
    {
        if (this._0x4afd660c.Count == 0)
            return;
        this._0x542bfa9a.Clear();
        this._0x542bfa9a.AddRange(this._0x4afd660c);
        this._0x4afd660c.Clear();
        for (int _0x2ee17484 = 0; _0x2ee17484 < this._0x542bfa9a.Count; _0x2ee17484++)
            Fix(this._0x542bfa9a[_0x2ee17484]);
    }

    private static void Fix(TMP_Text _0xef74f46f)
    {
        if (_0xef74f46f == null || !_0xef74f46f.isActiveAndEnabled)
            return;
        Material _0xd48ed548 = _0xef74f46f.fontSharedMaterial;
        if (_0xd48ed548 == null || !_0xd48ed548.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xd48ed548.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xd48ed548.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x40dcce8f = _0xef74f46f.color;
        if (_0x40dcce8f.a <= 0f)
            return;
        Color _0x6ea5f54c = _0xd48ed548.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x40dcce8f, _0x6ea5f54c) >= MinRatio)
            return;
        Color _0xb1784308 = Luminance(_0x6ea5f54c) < 0.5f ? Color.white : Color.black;
        Color _0x88567f06;
        if (Ratio(_0xb1784308, _0x6ea5f54c) < TargetRatio)
        {
            _0x88567f06 = _0xb1784308;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x2d600519 = 0f;
            float _0x128c3ba3 = 1f;
            for (int _0x95b786eb = 0; _0x95b786eb < 20; _0x95b786eb++)
            {
                float _0xafdd2c21 = (_0x2d600519 + _0x128c3ba3) * 0.5f;
                if (Ratio(Color.Lerp(_0x40dcce8f, _0xb1784308, _0xafdd2c21), _0x6ea5f54c) >= TargetRatio)
                    _0x128c3ba3 = _0xafdd2c21;
                else
                    _0x2d600519 = _0xafdd2c21;
            }

            _0x88567f06 = Color.Lerp(_0x40dcce8f, _0xb1784308, _0x128c3ba3);
        }

        _0x88567f06.a = _0x40dcce8f.a;
        _0xef74f46f.color = _0x88567f06;
    }

    private readonly List<TMP_Text> _0x542bfa9a = new List<TMP_Text>();
    private static _0xa258ade6 _0xc2cd060b;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x7deb9d6f)
    {
        return 0.2126f * Linear(_0x7deb9d6f.r) + 0.7152f * Linear(_0x7deb9d6f.g) + 0.0722f * Linear(_0x7deb9d6f.b);
    }

    private static float Linear(float _0x971c5df6)
    {
        _0x971c5df6 = Mathf.Clamp01(_0x971c5df6);
        return _0x971c5df6 <= 0.03928f ? _0x971c5df6 / 12.92f : Mathf.Pow((_0x971c5df6 + 0.055f) / 1.055f, 2.4f);
    }

    private const float MinOutlineWidth = 0.01f;
    private static float Ratio(Color _0x8c6be386, Color _0xa40a1e1f)
    {
        float _0x90df8935 = Luminance(_0x8c6be386);
        float _0x967adb05 = Luminance(_0xa40a1e1f);
        return (Mathf.Max(_0x90df8935, _0x967adb05) + 0.05f) / (Mathf.Min(_0x90df8935, _0x967adb05) + 0.05f);
    }

    private const float MinRatio = 4.5f;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xc2cd060b != null)
            return;
        GameObject _0x81c4e069 = new GameObject(_0xbbe2a53a._0x197ffa7a(new byte[16] { 60, 5, 24, 43, 7, 6, 28, 26, 9, 27, 28, 47, 29, 9, 26, 12 }, 104));
        _0x81c4e069.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x81c4e069);
        _0xc2cd060b = _0x81c4e069.AddComponent<_0xa258ade6>();
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xaf8292c1(Object _0x6abbd2e6)
    {
        TMP_Text _0x35ea0525 = _0x6abbd2e6 as TMP_Text;
        if (_0x35ea0525 != null)
            this._0x4afd660c.Add(_0x35ea0525);
    }

    private void OnEnable()
    {
        if (this._0x580ec621 == null)
            this._0x580ec621 = _0x08c780df => this._0xaf8292c1(_0x08c780df);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x580ec621);
    }
}

internal static class _0xbbe2a53a
{
    internal static string _0x197ffa7a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}