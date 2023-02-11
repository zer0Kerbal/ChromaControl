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

    /// <summary>The base color scheme for all flight related game scenes.</summary>
    internal class FlightScheme : ColorScheme
    {
        /// <summary>Overlays the defined keys over a black base layout.</summary>
        public FlightScheme()
        {
            KeyCode[] yellowkeys =
            {
                GameSettings.TRANSLATE_BACK.primary.code,
                GameSettings.TRANSLATE_FWD.primary.code,
                GameSettings.TRANSLATE_LEFT.primary.code,
                GameSettings.TRANSLATE_RIGHT.primary.code,
                GameSettings.TRANSLATE_UP.primary.code,
                GameSettings.TRANSLATE_DOWN.primary.code
            };
            this.SetKeysToColor(yellowkeys, Color.yellow);

            KeyCode[] redkeys =
            {
                GameSettings.THROTTLE_FULL.primary.code, GameSettings.THROTTLE_CUTOFF.primary.code,
                GameSettings.THROTTLE_UP.primary.code, GameSettings.THROTTLE_DOWN.primary.code
            };
            this.SetKeysToColor(redkeys, Color.red);

            KeyCode[] bluekeys = {GameSettings.FOCUS_NEXT_VESSEL.primary.code, GameSettings.FOCUS_PREV_VESSEL.primary.code};
            //{
            //    GameSettings.FOCUS_NEXT_VESSEL.primary.code,
            //    GameSettings.FOCUS_PREV_VESSEL.primary.code
            //};
            this.SetKeysToColor(bluekeys, Color.blue);
        }
    }
}