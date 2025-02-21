﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osuTK.Graphics;

namespace osu.Framework.Testing.Drawables.Steps
{
    public partial class LabelStep : StepButton
    {
        public new required Action<LabelStep> Action { get; init; }

        protected override Color4 IdleColour => new Color4(77, 77, 77, 255);

        protected override Color4 RunningColour => new Color4(128, 128, 128, 255);

        public LabelStep()
        {
            Light.Hide();
            Height = 30;
            base.Action = clickAction;
        }

        private void clickAction() => Action(this);
    }
}
