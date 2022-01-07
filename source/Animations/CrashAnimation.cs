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
    using System.Linq;
    using KspChromaControl.ColorSchemes;
    using UnityEngine;

    /// <summary>Animation displayed when you manage to explode the root part of your vessel.</summary>
    internal class CrashAnimation : KeyboardAnimation
    {
        /// <summary>All animation frames for this animation.</summary>
        private static readonly ColorScheme[] frames;

        /// <summary>List of scenes this animation is valid in.</summary>
        private static readonly List<GameScenes> validScenes = new List<GameScenes>
        {
            GameScenes.FLIGHT
        };

        /// <summary>Static constructor adds lightning bolts in different colors to both frames</summary>
        static CrashAnimation()
        {
            var newFrames = new List<ColorScheme>();

            var red = new ColorScheme(Color.red);
            var yellow = new ColorScheme(Color.yellow);

            // Generate first few frames
            newFrames.AddRange(AnimationUtils.InterpolateFrames(red, yellow, 3));
            // Add the way back to the original
            newFrames.AddRange(newFrames.ToArray().Reverse());
            // Double it
            newFrames.AddRange(newFrames.ToArray());
            // Quadruple it
            newFrames.AddRange(newFrames.ToArray());
            // Octuple it
            newFrames.AddRange(newFrames.ToArray());

            for (var i = 0; i < 30; i++)
            {
                newFrames.Add(AnimationUtils.CircularSineWave(Color.red, Color.yellow, i));
            }

            newFrames.AddRange(AnimationUtils.InterpolateFrames(newFrames.Last(), new ColorScheme(Color.black), 10));

            frames = newFrames.ToArray();
        }

        /// <summary>Initializes the base keyboard animation object.</summary>
        public CrashAnimation() : base(30, validScenes, frames)
        {
        }
    }
}