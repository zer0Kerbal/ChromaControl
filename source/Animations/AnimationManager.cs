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
    using KspChromaControl.ColorSchemes;

    /// <summary>Handles all animations to avoid confusion and multiple animations running at the same time.</summary>
    internal class AnimationManager
    {
        /// <summary>Singleton instance</summary>
        private static AnimationManager instance;

        /// <summary>The currently running animation or null</summary>
        private KeyboardAnimation activeAnimation;

        /// <summary>Private constructor to avoid out of singleton instantiation</summary>
        private AnimationManager()
        {
        }

        /// <summary>Instance getter</summary>
        public static AnimationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnimationManager();
                }
                return instance;
            }
        }

        /// <summary>Set the current animation</summary>
        /// <param name="animation">the animation to display</param>
        public void SetAnimation(KeyboardAnimation animation) => this.activeAnimation = animation;

        /// <summary>Fetches one frame from the animation</summary>
        /// <returns>the current animation frame</returns>
        public ColorScheme GetFrame() => this.AnimationRunning() ? this.activeAnimation.GetFrame() : new ColorScheme();

        /// <summary>Checks if there is still an animation running.</summary>
        /// <returns></returns>
        public bool AnimationRunning() => this.activeAnimation != null && !this.activeAnimation.IsFinished();
    }
}