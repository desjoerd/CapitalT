﻿using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalT.Owin
{
    public static class AppBuilderExtensions
    {
        public static void UseCapitalT(this IAppBuilder app, CapitalTOptions options);
    }
}