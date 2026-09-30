using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x47a641fc
{
    public static class _0x44cfec3f
    {
        public static int _0x678a3800
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x8420a80c._0xcda272d7(new byte[5] { 129, 173, 171, 172, 177 }, 194)))
                    PlayerPrefs.SetInt(_0x8420a80c._0xcda272d7(new byte[5] { 2, 46, 40, 47, 50 }, 65), 0);
                return PlayerPrefs.GetInt(_0x8420a80c._0xcda272d7(new byte[5] { 38, 10, 12, 11, 22 }, 101));
            }

            set
            {
                PlayerPrefs.SetInt(_0x8420a80c._0xcda272d7(new byte[5] { 234, 198, 192, 199, 218 }, 169), value);
                _0x0e5ba754.Instance._0x290fbd7d();
            }
        }
    }

    public static class _0x545b99d3
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xfc7f1136
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0xb2d9c6f9
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public class _0x1cbd8167
    {
        private static readonly _0x1cbd8167 _0x2b220c97 = new();
        public static readonly _0x1cbd8167[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x2b220c97,
            _0x2b220c97,
            _0x2b220c97,
        };
        private int _0xed89b9f2 => 0;
        private int _0x5649202d => 10;
        private string _0xdd64ac56 => _0x8420a80c._0xcda272d7(new byte[4] { 23, 63, 52, 47 }, 90);
        private string _0xb093cc14 => _0x8420a80c._0xcda272d7(new byte[8] { 168, 161, 178, 161, 168, 159, 212, 153 }, 228);

        private int _0xf14cb12e
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x8420a80c._0xcda272d7(new byte[25] { 126, 72, 79, 79, 88, 83, 73, 122, 81, 82, 95, 92, 81, 126, 85, 92, 77, 73, 88, 79, 116, 83, 89, 88, 69 }, 61)))
                    PlayerPrefs.SetInt(_0x8420a80c._0xcda272d7(new byte[25] { 28, 42, 45, 45, 58, 49, 43, 24, 51, 48, 61, 62, 51, 28, 55, 62, 47, 43, 58, 45, 22, 49, 59, 58, 39 }, 95), 0);
                return PlayerPrefs.GetInt(_0x8420a80c._0xcda272d7(new byte[25] { 120, 78, 73, 73, 94, 85, 79, 124, 87, 84, 89, 90, 87, 120, 83, 90, 75, 79, 94, 73, 114, 85, 95, 94, 67 }, 59));
            }

            set => PlayerPrefs.SetInt(_0x8420a80c._0xcda272d7(new byte[25] { 209, 231, 224, 224, 247, 252, 230, 213, 254, 253, 240, 243, 254, 209, 250, 243, 226, 230, 247, 224, 219, 252, 246, 247, 234 }, 146), value);
        }

        public int _0x61dc61e0
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xdd64ac56}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xdd64ac56}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xdd64ac56}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xdd64ac56}CurrentLevelIndex", value);
        }

        public int _0xd36fc50b
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xdd64ac56}BestScore"))
                    this._0xd36fc50b = 0;
                return PlayerPrefs.GetInt($"{this._0xdd64ac56}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xdd64ac56}BestScore", value);
        }

        public bool _0x3b8495f3
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xdd64ac56}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xdd64ac56}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xdd64ac56}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xdd64ac56}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }
}

internal static class _0x8420a80c
{
    internal static string _0xcda272d7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}