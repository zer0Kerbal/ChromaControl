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

namespace KspChromaControl
{
    using KspChromaControl.ColorSchemes;

    /// <summary>Implement this to use the mod with other devices.</summary>
    internal interface IDataDrain
    {
        /// <summary>Sends the requested color scheme to the implemented output channel</summary>
        /// <param name="scheme">The color scheme to apply to the implemented output device</param>
        void Send(ColorScheme scheme);
    }
}