﻿namespace Events.API.Entities
{
    public class DevEventSpeaker
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string TalkTitle { get; set; }  
        public string TalkDescription { get; set; }
        public string LinkedinProfile { get; set; }
    }
}