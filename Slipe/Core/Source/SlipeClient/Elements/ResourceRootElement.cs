﻿using Slipe.MtaDefinitions;
using Slipe.Shared.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Client.Resources;

namespace Slipe.Client.Elements
{
    public class ResourceRootElement : Element
    {
        public ResourceRootElement(MtaElement element) : base(element)
        {
            OnStart += (Resource resource) => { resource.HandleStart(); };
            OnStop += (Resource resource) => { resource.HandleStop(); };
        }

        #pragma warning disable 67

        public delegate void OnFileDownloadCompleteHandler(string path, bool success);
        public static event OnFileDownloadCompleteHandler OnFileDownloadComplete;

        internal delegate void OnStartHandler(Resource resource);
        internal event OnStartHandler OnStart;

        internal delegate void OnStopHandler(Resource resource);
        internal event OnStopHandler OnStop;

        #pragma warning restore 67

    }
}
