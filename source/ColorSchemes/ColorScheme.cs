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
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using UnityEngine;

    /// <summary>Represents a base color scheme, saving a base color and colors for modified keys. Implements the
    /// flyweight design pattern, to keep the memory footprint low. This is necessary for the animations to
    /// work smoothly. Also allows the storage of values for other gauge display devices, should range from 0 to 1.</summary>
    [Serializable]
    internal class ColorScheme : Dictionary<KeyCode, Color>
    {
        /// <summary>Creates a new ColorScheme rendering all keys black;</summary>
        public ColorScheme() : this(Color.black)
        {
        }

        /// <summary>Creates a new ColorScheme rendering all keys in the defined color.</summary>
        /// <param name="color">The color to use</param>
        public ColorScheme(Color color)
        {
            this.BaseColor = color;
        }

        public Color BaseColor { get; }
        public Dictionary<string, double> OtherValues { get; } = new Dictionary<string, double>();

        public new Color this[KeyCode key]
        {
            get
            {
                Color myReturn;

                if (this.ContainsKey(key))
                {
                    myReturn = base[key];
                }
                else
                {
                    myReturn = this.BaseColor;
                }

                return myReturn;
            }
            set { base[key] = value; }
        }

        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        public void SetKeyToColor(KeyCode key, Color color)
        {
            if (color.r == this.BaseColor.r &&
                color.g == this.BaseColor.g &&
                color.b == this.BaseColor.b &&
                this.ContainsKey(key))
            {
                this.Remove(key);
            }
            else
            {
                if (this.ContainsKey(key))
                {
                    this[key] = color;
                }
                else
                {
                    this.Add(key, color);
                }
            }
        }

        public void SetKeyToColor(int x, int y, Color color)
            => this.SetKeyToColor(Config.Instance.KeyByPosition[y, x], color);

        /// <summary>Sets a number of keys to the defined color</summary>
        /// <param name="keys">An array of keys to light up</param>
        /// <param name="color">The color to use</param>
        public void SetKeysToColor(KeyCode[] keys, Color color)
        {
            foreach (var key in keys)
            {
                this.SetKeyToColor(key, color);
            }
        }
    }
}