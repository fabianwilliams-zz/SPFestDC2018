using System;
using System.Collections.Generic;

namespace spfestdc2018.Model
{
    public class SpFestSpeakerNSessions
    {
        public SpFestSpeakerNSessions()
        {
        }

    }

    public class Creds
    {
        public string speakercategory { get; set; }
        public string certs { get; set; }
        public string title { get; set; }
    }

    public class Session
    {
        public string number { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
    }

    public class RootObject
    {
        public string id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string defaultPic { get; set; }
        public string twitterHandle { get; set; }
        public Creds creds { get; set; }
        public string bio { get; set; }
        public List<Session> sessions { get; set; }
        public string status { get; set; }
    }
}
