#if UNITY_EDITOR

using System.Collections.Generic;
using System.Net.Http;

namespace Unity.Networking
{
    class BackgroundDownloadEditor : BackgroundDownload
    {
        HttpClient _client;
        public BackgroundDownloadEditor(BackgroundDownloadConfig config)
            : base(config)
        {
            _status = BackgroundDownloadStatus.Failed;
            _error = "Not implemented for Unity Editor";
            config.onCompleted?.Invoke();
        }

        public override bool keepWaiting { get { return false; } }

        protected override float GetProgress() { return 1.0f; }

        internal static Dictionary<string, BackgroundDownload> LoadDownloads()
        {
            return new Dictionary<string, BackgroundDownload>();
        }

        internal static void SaveDownloads(Dictionary<string, BackgroundDownload> downloads)
        {
        }
    }
}

#endif
