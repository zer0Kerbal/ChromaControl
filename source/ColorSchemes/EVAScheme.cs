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


using UnityEngine;
using Corale.Colore;

namespace KspChromaControl.ColorSchemes
{
    /// <summary>Special color scheme for EVA scenes.</summary>
    internal class EvaScheme : ColorScheme
    {
        private readonly KeyCode[] movementKeys =
        {
            GameSettings.EVA_back.primary.code,
            GameSettings.EVA_forward.primary.code,
            GameSettings.EVA_left.primary.code,
            GameSettings.EVA_right.primary.code,
            GameSettings.EVA_Jump.primary.code,
            GameSettings.EVA_Run.primary.code
        };

        private readonly KeyCode[] packKeys =
        {
            GameSettings.EVA_back.primary.code,
            GameSettings.EVA_forward.primary.code,
            GameSettings.EVA_left.primary.code,
            GameSettings.EVA_right.primary.code,
            GameSettings.EVA_Jump.primary.code,
            GameSettings.EVA_yaw_left.primary.code,
            GameSettings.EVA_yaw_right.primary.code,
            GameSettings.EVA_Pack_up.primary.code,
            GameSettings.EVA_Pack_down.primary.code,
            GameSettings.EVA_Run.primary.code
        };


        private readonly KeyCode[] switchKeys =
        {
            GameSettings.FOCUS_NEXT_VESSEL.primary.code,
            GameSettings.FOCUS_PREV_VESSEL.primary.code
        };

        private readonly KeyCode[] useKeys =
        {
            GameSettings.EVA_Use.primary.code,
            GameSettings.EVA_Board.primary.code,
            GameSettings.EVA_ToggleMovementMode.primary.code
        };

        /// <summary>Overlays the defined keys over a black base layout.</summary>
        public EvaScheme()
        {
            if (FlightGlobals.ActiveVessel.evaController.JetpackDeployed)
            {
                this.SetKeysToColor(this.packKeys, Color.yellow);
                this.SetKeyToColor(GameSettings.EVA_TogglePack.primary.code, Color.green);
            }
            else
            {
                this.SetKeysToColor(this.movementKeys, Color.white);
                this.SetKeyToColor(GameSettings.EVA_TogglePack.primary.code, Color.red);
            }

            if (FlightGlobals.ActiveVessel.evaController.lampOn)
            {
                this.SetKeyToColor(GameSettings.EVA_Lights.primary.code, Color.green);
            }
            else
            {
                this.SetKeyToColor(GameSettings.EVA_Lights.primary.code, Color.red);
            }

            this.SetKeysToColor(this.useKeys, Color.cyan);

            this.SetKeysToColor(this.switchKeys, Color.blue);
        }
    }
}