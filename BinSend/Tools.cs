﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinSend
{
    /// <summary>
    /// Utilities
    /// </summary>
    public static class Tools
    {
        /// <summary>
        /// Value designating to use all bytes
        /// </summary>
        public const int DATA_EVERYTHING = -1;

        /// <summary>
        /// Converts UTF8 Text to bytes
        /// </summary>
        /// <param name="Data">Text</param>
        /// <returns>Binary</returns>
        public static byte[] UTF(this string Data)
        {
            return Encoding.UTF8.GetBytes(Data);
        }

        /// <summary>
        /// Converts binary Data to 
        /// </summary>
        /// <param name="Data">Binary</param>
        /// <param name="Start">Start</param>
        /// <param name="Count">Number of bytes to parse</param>
        /// <returns>String</returns>
        public static string UTF(this byte[] Data, int Start = 0, int Count = DATA_EVERYTHING)
        {
            if (Count == DATA_EVERYTHING)
            {
                Count = Data.Length - Start;
            }
            return Encoding.UTF8.GetString(Data, Start, Count);
        }

        /// <summary>
        /// Converts binary data to Base64
        /// </summary>
        /// <param name="Data">Binary</param>
        /// <param name="Start">Start</param>
        /// <param name="Count">Number of bytes to parse</param>
        /// <returns>Base64 String</returns>
        public static string B64(this byte[] Data, int Start = 0, int Count = DATA_EVERYTHING)
        {
            if (Count == DATA_EVERYTHING)
            {
                Count = Data.Length - Start;
            }
            return Convert.ToBase64String(Data, Start, Count);
        }

        /// <summary>
        /// Converts a Base64 string to Binary
        /// </summary>
        /// <param name="Data">Base64 Data</param>
        /// <returns>Binary</returns>
        public static byte[] B64(this string Data)
        {
            return Convert.FromBase64String(Data.Replace('\0', '\t').Trim());
        }

        /// <summary>
        /// Converts the JSON String into an Object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="S">JSON string</param>
        /// <param name="Default">Default value on error</param>
        /// <returns>Object or default</returns>
        public static T FromJson<T>(this string S, T Default = default(T))
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(S);
            }
            catch
            {
                return Default;
            }
        }

        /// <summary>
        /// Converts any Object to JSON
        /// </summary>
        /// <param name="o">Object</param>
        /// <param name="Pretty">Pretty print</param>
        /// <returns>JSON string</returns>
        public static string ToJson(this object o, bool Pretty = false)
        {
            return JsonConvert.SerializeObject(o, Pretty ? Formatting.Indented : Formatting.None);
        }
    }
}