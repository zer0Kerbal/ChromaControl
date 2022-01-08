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

    /// <summary>Slowly displays the KSP logo from a blue base scheme.</summary>
    internal class LogoAnimation : KeyboardAnimation
    {
        /// <summary>The frames this animation consists of.</summary>
        private static readonly ColorScheme[] frames;

        /// <summary>List of scenes this animation is valid in.</summary>
        private static readonly List<GameScenes> validScenes = new List<GameScenes>
        {
            GameScenes.MAINMENU,
            GameScenes.SPACECENTER,
            GameScenes.TRACKSTATION,
            GameScenes.CREDITS,
            GameScenes.SETTINGS,
            GameScenes.LOADINGBUFFER,
            GameScenes.PSYSTEM,
            GameScenes.LOADING,
            GameScenes.MAINMENU,
            GameScenes.MISSIONBUILDER
        };

        /// <summary>Static constructor interpolates from blue to logo.</summary>
        static LogoAnimation()
        {
            frames = AnimationUtils.InterpolateFrames(new ColorScheme(Color.blue), new LogoScheme(), 20);
        }

        /// <summary>Initializes the base keyboard animation object.</summary>
        public LogoAnimation() : base(10, validScenes, frames)
        {
        }
    }
}