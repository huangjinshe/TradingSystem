﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Oybab.ServerManager.Model.Service.Common
{

    public class ToServerServiceSetbak : ToServerService
    {


        public long AdminId { get; set; }

        public string Model { get; set; }

        public string ModelRef { get; set; }


        public int Token { get; set; }
        public string Key { get; set; }
    }
}
