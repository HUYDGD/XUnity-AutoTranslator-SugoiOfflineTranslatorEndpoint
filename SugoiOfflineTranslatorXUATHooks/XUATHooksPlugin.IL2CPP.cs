﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx.IL2CPP;

namespace SugoiOfflineTranslator.XUATHooks
{
    partial class XUATHooksPlugin : BasePlugin
    {
        public override void Load()
        {
            this.Init();
            this.PatchAll();
        }

        internal static void LogDebug(object obj)
        {
#if DEBUG
            Instance.Log.LogDebug(obj);
#endif
        }

    }
}
