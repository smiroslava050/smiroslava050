using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xb6ef9d95 : MonoBehaviour
{
    private void Awake()
    {
        this._0xd0959e54 = this.GetComponent<Camera>();
        _0x22e173d7 = this;
        this._0x4c8b6c85();
    }

    private Vector3 _0xd57dd9f1 { get; set; }

    private Color _0x55768a55 = Color.white;
    private Vector3 _0x268be395 { get; set; }
    private float _0xf28e174e { get; set; }

    private void _0x4c8b6c85()
    {
        float _0x9893bc87, _0xe4294f06, _0xe5f011ed, _0x404dd154;
        if (this._0x36bd6e4d == _0xbc265e3c.Landscape)
            this._0xd0959e54.orthographicSize = 1f / this._0xd0959e54.aspect * this._0x568819a2 / 2f;
        else
            this._0xd0959e54.orthographicSize = this._0x568819a2 / 2f;
        this._0xf28e174e = 2f * this._0xd0959e54.orthographicSize;
        this._0x90b0295d = this._0xf28e174e * this._0xd0959e54.aspect;
        float _0xa840ff5d = this._0xd0959e54.transform.position.x;
        float _0x088fc16d = this._0xd0959e54.transform.position.y;
        _0x9893bc87 = _0xa840ff5d - this._0x90b0295d / 2;
        _0xe4294f06 = _0xa840ff5d + this._0x90b0295d / 2;
        _0xe5f011ed = _0x088fc16d + this._0xf28e174e / 2;
        _0x404dd154 = _0x088fc16d - this._0xf28e174e / 2;
        this._0x06d7e1bd = new Vector3(_0x9893bc87, _0x404dd154, 0);
        this._0x57ebfa08 = new Vector3(_0xa840ff5d, _0x404dd154, 0);
        this._0x300a5732 = new Vector3(_0xe4294f06, _0x404dd154, 0);
        this._0xd57dd9f1 = new Vector3(_0x9893bc87, _0x088fc16d, 0);
        this._0xcd678861 = new Vector3(_0xa840ff5d, _0x088fc16d, 0);
        this._0xd644548f = new Vector3(_0xe4294f06, _0x088fc16d, 0);
        this._0xb94a1323 = new Vector3(_0x9893bc87, _0xe5f011ed, 0);
        this._0xe53147a5 = new Vector3(_0xa840ff5d, _0xe5f011ed, 0);
        this._0x268be395 = new Vector3(_0xe4294f06, _0xe5f011ed, 0);
    }

    private _0xbc265e3c _0x36bd6e4d = _0xbc265e3c.Portrait;
    private Vector3 _0xd644548f { get; set; }
    private Vector3 _0x300a5732 { get; set; }

    private float _0x568819a2 = 1;
    private Vector3 _0x57ebfa08 { get; set; }
    private Vector3 _0x06d7e1bd { get; set; }

    public enum _0xbc265e3c
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xe53147a5 { get; set; }

    private static _0xb6ef9d95 _0x22e173d7;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x55768a55;
        Matrix4x4 _0x8c7d1e32 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xd0959e54.orthographic)
        {
            float _0x7934dd96 = this._0xd0959e54.farClipPlane - this._0xd0959e54.nearClipPlane;
            float _0x0d6b9411 = (this._0xd0959e54.farClipPlane + this._0xd0959e54.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x0d6b9411), new Vector3(this._0xd0959e54.orthographicSize * 2 * this._0xd0959e54.aspect, this._0xd0959e54.orthographicSize * 2, _0x7934dd96));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xd0959e54.fieldOfView, this._0xd0959e54.farClipPlane, this._0xd0959e54.nearClipPlane, this._0xd0959e54.aspect);
        }

        Gizmos.matrix = _0x8c7d1e32;
    }

    private Vector3 _0xcd678861 { get; set; }
    //public bool executeInUpdate;
    private float _0x90b0295d { get; set; }

    private new Camera _0xd0959e54;
    private Vector3 _0xb94a1323 { get; set; }
}