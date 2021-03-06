﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SpotifyAPI.Web
{
    public interface IClient : IDisposable
    {
        JsonSerializerSettings JsonSettings { get; set; }

        /// <summary>
        ///     Downloads data from an URL and returns it
        /// </summary>
        /// <param name="url">An URL</param>
        /// <returns></returns>
        string Download(string url);

        /// <summary>
        ///     Downloads data from an URL and returns it
        /// </summary>
        /// <param name="url">An URL</param>
        /// <returns></returns>
        byte[] DownloadRaw(string url);

        /// <summary>
        ///     Downloads data from an URL and converts it to an object
        /// </summary>
        /// <typeparam name="T">The Type which the object gets converted to</typeparam>
        /// <param name="url">An URL</param>
        /// <returns></returns>
        T DownloadJson<T>(string url);

        /// <summary>
        ///     Uploads data from an URL and returns the response
        /// </summary>
        /// <param name="url">An URL</param>
        /// <param name="body">The Body-Data (most likely a JSON String)</param>
        /// <param name="method">The Upload-method (POST,DELETE,PUT)</param>
        /// <returns></returns>
        string Upload(string url, string body, string method);

        /// <summary>
        ///     Uploads data from an URL and returns the response
        /// </summary>
        /// <param name="url">An URL</param>
        /// <param name="body">The Body-Data (most likely a JSON String)</param>
        /// <param name="method">The Upload-method (POST,DELETE,PUT)</param>
        /// <returns></returns>
        byte[] UploadRaw(string url, string body, string method);

        /// <summary>
        ///     Uploads data from an URL and converts the response to an object
        /// </summary>
        /// <typeparam name="T">The Type which the object gets converted to</typeparam>
        /// <param name="url">An URL</param>
        /// <param name="body">The Body-Data (most likely a JSON String)</param>
        /// <param name="method">The Upload-method (POST,DELETE,PUT)</param>
        /// <returns></returns>
        T UploadJson<T>(string url, string body, string method);

        /// <summary>
        ///     Sets a specific Header
        /// </summary>
        /// <param name="header">Header name</param>
        /// <param name="value">Header value</param>
        void SetHeader(string header, string value);

        /// <summary>
        ///     Removes a specific Header
        /// </summary>
        /// <param name="header">Header name</param>
        void RemoveHeader(string header);

        /// <summary>
        ///     Gets all current Headers
        /// </summary>
        /// <returns>A collection of Header KeyValue Pairs</returns>
        List<KeyValuePair<string, string>> GetHeaders();
    }
}