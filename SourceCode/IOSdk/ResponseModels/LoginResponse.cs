﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IOSdk.ResponseModels
{
    public class LoginResponse
    {
        [JsonProperty("access_token")]
        public Guid AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public DateTimeOffset ExpiresIn { get; set; }
    }
}
