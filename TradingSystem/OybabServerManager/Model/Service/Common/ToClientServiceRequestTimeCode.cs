﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Oybab.ServerManager.Model.Service.Common
{

    public class ToClientServiceRequestTimeCode : ToClientService
    {

        public string RequestCode { get; set; }
    }
}
