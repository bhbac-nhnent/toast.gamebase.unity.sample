﻿namespace GamebaseSample
{
    public class LaunchingData
    {
        public class Sample
        {
            public class SmartDownloader
            {
                public string appkey;
                public string service_android;
            }

            public class Leaderboard
            {
                public string appkey;
                public string url;

                public string FullUrl
                {
                    get { return string.Format("{0}/appkeys/{1}", url, appkey); }
                }
            }

            public SmartDownloader smartdl;
            public Leaderboard leaderboard;
        }

        public Sample sample;
    }

    public class LaunchingVo
    {
        public class Header
        {
            public bool isSuccessful;
            public int resultCode;
            public string resultMessage;
        }

        public Header header;
        public LaunchingData launching;
    }
}