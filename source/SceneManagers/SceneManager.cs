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

namespace KspChromaControl.SceneManagers
{
    using KspChromaControl.ColorSchemes;

    /// <summary>Allows creation of keyboard color managers for multiple scenes.</summary>
    internal interface ISceneManager
    {
        /// <summary>Gets the keyboard color scheme for the current frame.</summary>
        /// <returns>The new color scheme.</returns>
        ColorScheme GetScheme();
    }
}