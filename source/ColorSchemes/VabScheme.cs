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

    /// <summary>Contains the base color scheme for all VAB and SPH scenes.</summary>
    internal class VabScheme : ColorScheme
    {
        /// <summary>Overlays the defined key colors over the base color scheme.</summary>
        public VabScheme()
        {
            this.SetKeysToColor(
                new[]
                {
                    GameSettings.Editor_pitchUp.primary.code, GameSettings.Editor_pitchDown.primary.code,
                    GameSettings.Editor_rollLeft.primary.code, GameSettings.Editor_rollRight.primary.code,
                    GameSettings.Editor_yawLeft.primary.code, GameSettings.Editor_yawRight.primary.code
                },
                new Color(1f, 1f, 0f)
            );
            this.SetKeysToColor(
                new[]
                {
                    GameSettings.Editor_fineTweak.primary.code,
                    GameSettings.Editor_resetRotation.primary.code,
                    GameSettings.Editor_coordSystem.primary.code
                },
                Color.magenta
            );
        }
    }
}