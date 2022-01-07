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

namespace KspChromaControl.ColorSchemes
{
    using UnityEngine;

    /// <summary>Displays an image on the keyboard vaguely similar to the logo minus the KSP text.</summary>
    internal class LogoScheme : ColorScheme
    {
        /// <summary>Overlays the defined keys on top of a blue base color scheme.</summary>
        public LogoScheme() : base(Color.blue)
        {
            KeyCode[] redkeys =
            {
                // Rocket
                //KeyCode.LeftAlt, KeyCode.Backslash, KeyCode.Z, KeyCode.S, KeyCode.X, KeyCode.C, KeyCode.F3,
                KeyCode.LeftAlt, KeyCode.Slash, KeyCode.Z, KeyCode.S, KeyCode.X, KeyCode.C, KeyCode.F3,
                KeyCode.D, KeyCode.E, KeyCode.Alpha4,

                // Stripes
                KeyCode.LeftShift, KeyCode.V, KeyCode.B, KeyCode.N, KeyCode.M, KeyCode.Comma, KeyCode.Period,
                KeyCode.Slash, KeyCode.RightShift
            };
            this.SetKeysToColor(redkeys, Color.red);

            KeyCode[] whitekeys =
            {
                KeyCode.LeftControl, KeyCode.LeftWindows, KeyCode.Space, KeyCode.AltGr, KeyCode.RightAlt,
                KeyCode.RightControl,
                KeyCode.Menu, KeyCode.RightControl, KeyCode.A, KeyCode.W, KeyCode.Alpha3, KeyCode.F2,
                KeyCode.F4, KeyCode.Alpha5, KeyCode.R, KeyCode.F, KeyCode.CapsLock, KeyCode.G, KeyCode.H,
                KeyCode.J, KeyCode.K, KeyCode.L, KeyCode.Semicolon, KeyCode.Quote, KeyCode.Hash
            };
            this.SetKeysToColor(whitekeys, Color.white);
        }
    }
}