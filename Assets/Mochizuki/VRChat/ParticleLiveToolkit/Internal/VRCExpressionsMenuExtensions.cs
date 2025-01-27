﻿using System.Linq;

using VRC.SDK3.Avatars.ScriptableObjects;

namespace Mochizuki.VRChat.ParticleLiveToolkit.Internal
{
    // ReSharper disable once InconsistentNaming
    internal static class VRCExpressionsMenuExtensions
    {
        public static void MergeExpressions(this VRCExpressionsMenu expression, params VRCExpressionsMenu[] expressions)
        {
            var count = expression.controls.Count;
            foreach (var control in expressions.SelectMany(w => w.controls))
            {
                count++;

                if (count >= VRCExpressionsMenu.MAX_CONTROLS)
                    break;

                if (expression.controls.Any(w => w.name == control.name))
                    continue;

                expression.controls.Add(control);
            }
        }
    }
}