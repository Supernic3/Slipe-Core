﻿using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Elements;
using Slipe.MtaDefinitions;
using System.Numerics;
using System.ComponentModel;

namespace Slipe.Client.Gui
{
    /// <summary>
    /// Represents a Cegui scroll bar
    /// </summary>
    public class ScrollBar : GuiElement
    {
        /// <summary>
        /// Get and set the position of this scroll bar (0-100)
        /// </summary>
        public float ScrollPosition
        {
            get
            {
                return MtaClient.GuiScrollBarGetScrollPosition(element);
            }
            set
            {
                MtaClient.GuiScrollBarSetScrollPosition(element, value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public ScrollBar(MtaElement element) : base(element)
        {

        }

        /// <summary>
        /// Create a scroll bar
        /// </summary>
        public ScrollBar(Vector2 position, Vector2 dimensions, bool horizontal, bool relative = false, GuiElement parent = null)
        {
            element = MtaClient.GuiCreateScrollBar(position.X, position.Y, dimensions.X, dimensions.Y, horizontal, relative, parent?.MTAElement);
            isRelative = relative;
            ElementManager.Instance.RegisterElement(this);
        }
    }
}
