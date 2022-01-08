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

    /// <summary>Displays a warning on the keyboard, indicating that the vessel is currently out of power and cannot be controlled. 
    /// Consists of two frames alternating at 1fps.</summary>
    internal class PowerLostAnimation : KeyboardAnimation
    {
        /// <summary>The red frame</summary>
        private static readonly ColorScheme red = new ColorScheme(Color.red);

        /// <summary>The blue frame</summary>
        private static readonly ColorScheme blue = new ColorScheme(Color.blue);

        private static readonly List<GameScenes> validScenes = new List<GameScenes>
        {
            GameScenes.FLIGHT
        };

        /// <summary>Static constructor adds lightning bolts in different colors to both frames</summary>
        static PowerLostAnimation()
        {
            KeyCode[] lightningKeys =
            {
                // Left lightning
                KeyCode.F2, KeyCode.Alpha3, KeyCode.W, KeyCode.E, KeyCode.R, KeyCode.D, KeyCode.X, KeyCode.LeftAlt,

                // Right lightning
                KeyCode.F9, KeyCode.Alpha0, KeyCode.O, KeyCode.P, KeyCode.LeftBracket, KeyCode.Semicolon,
                KeyCode.Period,
                KeyCode.RightAlt
            };

            blue.SetKeysToColor(lightningKeys, Color.white);
            red.SetKeysToColor(lightningKeys, Color.blue);
        }

        /// <summary>Constructor that initializes the keyboard animation object. frames can be null here, because the
        /// getFrame method relies on alternating between two fixed frames rather than a sequence.</summary>
        public PowerLostAnimation() : base(1, validScenes, null)
        {
        }

        /// <summary><see cref="KeyboardAnimation.GetFrame" /></summary>
        /// <returns>the current animation frame.</returns>
        public override ColorScheme GetFrame() => (int) Time.realtimeSinceStartup % 2 == 0 ? red : blue;

        /// <summary><see cref="KeyboardAnimation.IsFinished" /></summary>
        /// <returns>true, if the animation is finished, false if not.</returns>
        public override bool IsFinished()
        {
            double electricity = 0.0f;
            var electricityPresent = false;

            foreach (var part in FlightGlobals.ActiveVessel.parts)
            {
                foreach (var resource in part.Resources)
                {
                    if (resource.info.name.Equals("ElectricCharge"))
                    {
                        electricity += resource.amount;
                        electricityPresent = true;
                    }
                }
            }

            // Check if the vessel needs power, and if empty, continue blinking
            return !electricityPresent || electricity > 0.0001;
        }
    }
}