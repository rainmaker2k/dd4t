﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DD4T.ContentModel.Contracts.Providers;

namespace DD4T.Providers.SDLTridion2009
{
    public class BaseProvider : IProvider
    {
        public int PublicationId { get; set; }
    }
}
