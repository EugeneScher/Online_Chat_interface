﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat2._0.MVVM.Model
{
    class MessageModel
    {
        public string Username { get; set; }

        public string UsernameColor { get; set; }

        public string ImageSource { get; set; }

        public string Message { get; set; }

        public DateTime Time { get; set; }

        public bool IsNativeOrigin { get; set; }

        public bool? FristMessage { get; set; }
    }
}
