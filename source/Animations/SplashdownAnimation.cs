/*
 * KspChromaControl
 * Copyright(C) Copyright © 2016, 2021, 2022 zer0Kerbal
 * zer0Kerbal at hotmail dot com
 * KGEx
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace KspChromaControl.Animations
{
    using System.Collections.Generic;
    using KspChromaControl.ColorSchemes;
    using UnityEngine;

    /// <summary>Animation displayed when the vessel is splashed down into any sort of ocean.</summary>
    internal class SplashdownAnimation : KeyboardAnimation
    {
        /// <summary>The animation frames.</summary>
        private static readonly ColorScheme[] frames;

        /// <summary>List of scenes this animation is valid in.</summary>
        private static readonly List<GameScenes> validScenes = new List<GameScenes>
        {
            GameScenes.FLIGHT
        };

        /// <summary>Static constructor adds lightning bolts in different colors to both frames</summary>
        static SplashdownAnimation()
        {
            var newFrames = new List<ColorScheme>();

            var uninterpolated = GenerateAnimationFrames();

            for (var i = 0; i < uninterpolated.Length - 1; i++)
            {
                newFrames.AddRange(AnimationUtils.InterpolateFrames(uninterpolated[i], uninterpolated[i + 1], 5));
            }

            newFrames.AddRange(
                AnimationUtils.InterpolateFrames(
                    uninterpolated[uninterpolated.Length - 1],
                    new ColorScheme(new Color(0f, 0f, .2f)),
                    10
                )
            );

            frames = newFrames.ToArray();
        }

        /// <summary>Constructor that initializes the keyboard animation object.</summary>
        public SplashdownAnimation() : base(40, validScenes, frames)
        {
        }

        /// <summary>Helper method that generates all animation frames.</summary>
        /// <returns></returns>
        private static ColorScheme[] GenerateAnimationFrames()
        {
            // Init with sine wave
            var myReturn = new ColorScheme[40];

            for (var i = 0; i < myReturn.Length; i++)
            {
                myReturn[i] = AnimationUtils.CircularSineWave(new Color(0f, 0f, .2f), new Color(.3f, .3f, 1f), i);
            }

            return myReturn;
        }
    }
}