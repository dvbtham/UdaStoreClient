﻿using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class AppSetting
    {
        public long Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
