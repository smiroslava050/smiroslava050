using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x7eb6e811 : MonoBehaviour
{
    private bool _0x5478d9e0(Touch? _0xce0a7b0d)
    {
        if (!_0xce0a7b0d.HasValue)
            return false;
        Vector3 _0xfed0944b = Camera.main.ScreenToWorldPoint(_0xce0a7b0d.Value.screenPosition);
        Vector3 _0xf40dfea9 = _0xfed0944b;
        _0xf40dfea9.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xf40dfea9))
            return true;
        _0xce0a7b0d = null;
        return false;
    }

    private Touch? _0xb058cd8b(Bounds _0xa27732d6)
    {
        if (!_0x0e5ba754.Instance._0x53738293)
            return null;
        foreach (Touch _0x51e55c9f in Touch.activeTouches)
            if (!_0x51e55c9f.ended)
            {
                Vector3 _0xad4097d4 = Camera.main.ScreenToWorldPoint(_0x51e55c9f.screenPosition);
                Vector3 _0xcf653e17 = new(_0xad4097d4.x, _0xad4097d4.y, _0xa27732d6.center.z);
                if (_0xa27732d6.Contains(_0xcf653e17) && this._0x5478d9e0(_0x51e55c9f))
                    return _0x51e55c9f;
            }

        return null;
    }

    private Touch? _0x127eaa0b(Bounds _0x58217d9a, TouchPhase _0xd27b6537)
    {
        if (!_0x0e5ba754.Instance._0x53738293)
            return null;
        foreach (Touch _0x5895ad61 in Touch.activeTouches)
            if (_0x5895ad61.phase == _0xd27b6537)
            {
                Vector3 _0x39c48418 = Camera.main.ScreenToWorldPoint(_0x5895ad61.screenPosition);
                Vector3 _0x5b997100 = new(_0x39c48418.x, _0x39c48418.y, _0x58217d9a.center.z);
                if (_0x58217d9a.Contains(_0x5b997100) && this._0x5478d9e0(_0x5895ad61))
                    return _0x5895ad61;
            }

        return null;
    }

    private Touch? _0x8cc58f9e()
    {
        if (!_0x0e5ba754.Instance._0x53738293)
            return null;
        foreach (Touch _0x4a8081b4 in Touch.activeTouches)
            if (_0x4a8081b4.ended)
                if (this._0x5478d9e0(_0x4a8081b4))
                    return _0x4a8081b4;
        return null;
    }

    private Touch? _0xc5b46954()
    {
        if (!_0x0e5ba754.Instance._0x53738293)
            return null;
        foreach (Touch _0x9534c682 in Touch.activeTouches)
            if (!_0x9534c682.ended)
                if (this._0x5478d9e0(_0x9534c682))
                    return _0x9534c682;
        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x90fca12a = this.gameObject.GetComponent<_0x7eb6e811>();
    }

    public BoxCollider2D CameraTouchBounds;
    private void _0x17ded3e1(Touch? _0xb1821fd6)
    {
        if (!_0x0e5ba754.Instance._0x53738293)
        {
            _0xb1821fd6 = null;
            return;
        }

        int _0x69470f14 = _0xb1821fd6.Value.touchId;
        _0xb1821fd6 = Touch.activeTouches.FirstOrDefault(_0x6ad91b74 => _0x6ad91b74.touchId == _0x69470f14);
        if (!this._0x5478d9e0(_0xb1821fd6.Value))
            _0xb1821fd6 = null;
    }

    private bool _0xae4e5c3a(Touch? _0xf814eb79, Bounds _0x008832ce, TouchPhase _0xde4d52c2)
    {
        if (!_0x0e5ba754.Instance._0x53738293)
        {
            _0xf814eb79 = null;
            return false;
        }

        if (_0xf814eb79 != null)
            if (_0xf814eb79.Value.phase == _0xde4d52c2)
            {
                Vector3 _0xa0511637 = Camera.main.ScreenToWorldPoint(_0xf814eb79.Value.screenPosition);
                Vector3 _0x44aaf41a = new(_0xa0511637.x, _0xa0511637.y, _0x008832ce.center.z);
                if (_0x008832ce.Contains(_0x44aaf41a) && this._0x5478d9e0(_0xf814eb79.Value))
                    return true;
            }

        return false;
    }

    private static _0x7eb6e811 _0x90fca12a;
    private Touch? _0xb7cf4a75(Bounds _0x8a2ca4a0)
    {
        if (!_0x0e5ba754.Instance._0x53738293)
            return null;
        foreach (Touch _0xba88bfc4 in Touch.activeTouches)
            if (_0xba88bfc4.ended)
            {
                Vector3 _0xb8f5639e = Camera.main.ScreenToWorldPoint(_0xba88bfc4.screenPosition);
                Vector3 _0x234ec172 = new(_0xb8f5639e.x, _0xb8f5639e.y, _0x8a2ca4a0.center.z);
                if (_0x8a2ca4a0.Contains(_0x234ec172) && this._0x5478d9e0(_0xba88bfc4))
                    return _0xba88bfc4;
            }

        return null;
    }
}