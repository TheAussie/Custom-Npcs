﻿using System.ComponentModel;
using Terraria;

namespace CustomNPC.EventSystem.Events
{
    public class ServerChatEvent : HandledEventArgs
    {
        public MessageBuffer Buffer { get; set; }
        public string Text { get; set; }
        public int Who { get; set; }
    }
}
