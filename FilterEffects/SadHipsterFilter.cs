﻿/**
 * Copyright (c) 2013 Nokia Corporation.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Nokia.Graphics;
using Nokia.Graphics.Imaging;

using FilterEffects.Resources;

namespace FilterEffects
{
    public class SadHipsterFilter : CarShowFilter
    {
        // Constants
        private const double DefaultBrightness = 0.5;
        private const double DefaultSaturation = 0.3;
        private const LomoVignetting DefaultLomoVignetting = LomoVignetting.Medium;
        private const LomoStyle DefaultLomoStyle = LomoStyle.Yellow;

        public SadHipsterFilter()
            : base()
        {
            Name = "Sad Hipster";

            _lomoFilter.Brightness = DefaultBrightness;
            _lomoFilter.Saturation = DefaultSaturation;
            _lomoFilter.LomoVignetting = DefaultLomoVignetting;
            _lomoFilter.LomoStyle = DefaultLomoStyle;

            _lomoVignettingGroup = "SadHipsterLomoVignetting";
        }

        protected override void SetFilters(FilterEffect effect)
        {
            AntiqueFilter antiqueFilter = new AntiqueFilter();
            effect.Filters = new List<IFilter>() { antiqueFilter, _lomoFilter };
        }
    }
}
