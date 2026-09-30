using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

/// <summary>
/// Turns a press anywhere on the board into "the player tapped ring k". It reads the
/// new Input System's current pointer - the touchscreen on a phone, the mouse in the
/// editor - and never the legacy Input class, and it stands down whenever the press
/// landed on a UI element so the LAUNCH button cannot also spin a ring.
/// </summary>
public sealed class _0xebd7f20f : MonoBehaviour
{
    /// <summary>True when the press is over a UI element that wants it for itself.</summary>
    private static bool OverInterface()
    {
        EventSystem _0xe2c1df9f = EventSystem.current;
        return _0xe2c1df9f != null && _0xe2c1df9f.IsPointerOverGameObject();
    }

    [SerializeField]
    private _0x845080f6 _board;
    private bool _0x13a5100b;
    private void Update()
    {
        Pointer _0xfc24acd6 = Pointer.current;
        if (_0xfc24acd6 == null)
            return;
        bool _0xde28c790 = _0xfc24acd6.press.isPressed;
        if (_0xde28c790 && !this._0x13a5100b && !OverInterface())
        {
            Camera _0x0206e3bf = Camera.main;
            if (_0x0206e3bf != null && this._board != null)
            {
                Vector3 _0x9808f806 = _0xfc24acd6.position.ReadValue();
                _0x9808f806.z = Mathf.Abs(_0x0206e3bf.transform.position.z);
                Vector3 _0xfeda8428 = _0x0206e3bf.ScreenToWorldPoint(_0x9808f806);
                this._board._0xacd6abfb(new Vector2(_0xfeda8428.x, _0xfeda8428.y));
            }
        }

        this._0x13a5100b = _0xde28c790;
    }
}