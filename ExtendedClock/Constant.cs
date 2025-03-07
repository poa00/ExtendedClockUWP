﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedClock
{
    public static class Constant
    {
        public static readonly int HOST_PORT = 8005;
        public static readonly string KEY_FIRST_LAUNCH = "first_launch";
        public static readonly string KEY_HOST_ADDRESS = "host_address";
        public static readonly string REGEX_IP_PATTERN = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
    }
}
