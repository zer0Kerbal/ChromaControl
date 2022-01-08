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

    /// <summary>Implement this to create an animation on your keyboard.</summary>
    internal abstract class KeyboardAnimation
    {
        /// <summary>The fps value for this animation</summary>
        private readonly int fps = 24;

        /// <summary>Array of frames we iterate over to show the animation.</summary>
        private readonly ColorScheme[] frames;

        /// <summary>The list of scenes, this animation can be shown in.</summary>
        private readonly List<GameScenes> validScenes;

        /// <summary>The index of the currently displayed frame.</summary>
        private int currentFrame;

        /// <summary>The realtime the last frame was displayed</summary>
        private int lastFrameTime;

        /// <summary>Creates a new keyboard animation with the given parameters</summary>
        /// <param name="fps">The number of frames per second we want to use.</param>
        /// <param name="validScenes">A list of scenes, the animation should be valid in.</param>
        /// <param name="frames">A list of all frames, containing the actual animation</param>
        public KeyboardAnimation(int fps, List<GameScenes> validScenes, ColorScheme[] frames)
        {
            this.fps = fps;
            this.currentFrame = 0;
            this.validScenes = validScenes;
            this.frames = frames;
        }

        /// <summary>Returns the current animation frame.</summary>
        /// <returns>the current animation frame.</returns>
        public virtual ColorScheme GetFrame()
        {
            ColorScheme myReturn = null;

            if (this.lastFrameTime < (int) (Time.realtimeSinceStartup * this.fps))
            {
                this.currentFrame++;
                this.lastFrameTime = (int) (Time.realtimeSinceStartup * this.fps);
            }

            if (this.frames.Length > this.currentFrame)
            {
                myReturn = this.frames[this.currentFrame];
            }
            else
            {
                myReturn = this.frames[this.frames.Length - 1];
            }

            return myReturn;
        }

        /// <summary>Checks if the animation is complete.</summary>
        /// <returns>true, if the animation is finished.</returns>
        public virtual bool IsFinished() => !this.validScenes.Contains(HighLogic.LoadedScene) ||
                                            this.currentFrame >= this.frames.Length;
    }
}