﻿using UnityEngine;

using VRC.SDK3.Avatars.Components;

namespace Mochizuki.VRChat.ParticleLiveToolkit.Internal
{
    internal static class StateMachineBehaviourExtensions
    {
        public static void ApplyTo(this StateMachineBehaviour source, StateMachineBehaviour dest)
        {
            switch (source)
            {
                case VRCAnimatorLayerControl layer:
                    layer.ApplyTo((VRCAnimatorLayerControl) dest);
                    break;

                case VRCAnimatorLocomotionControl locomotion:
                    locomotion.ApplyTo((VRCAnimatorLocomotionControl) dest);
                    break;

                case VRCAnimatorTemporaryPoseSpace temporaryPoseSpace:
                    temporaryPoseSpace.ApplyTo((VRCAnimatorTemporaryPoseSpace) dest);
                    break;

                case VRCAnimatorTrackingControl tracking:
                    tracking.ApplyTo((VRCAnimatorTrackingControl) dest);
                    break;

                case VRCAvatarParameterDriver parameterDriver:
                    parameterDriver.ApplyTo((VRCAvatarParameterDriver) dest);
                    break;

                case VRCPlayableLayerControl playableLayer:
                    playableLayer.ApplyTo((VRCPlayableLayerControl) dest);
                    break;
            }
        }
    }
}