﻿/*
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

using System;
using System.Linq;
using Corale.Colore;

[assembly: CLSCompliant(false)]

namespace KspChromaControl
{
    using System.Collections.Generic;
    using KspChromaControl.Animations;
    using KspChromaControl.ColorSchemes;
    using KspChromaControl.SceneManagers;
    using UnityEngine;

    /// <summary>The main class, managing the keyboard appearance for every kind of scene KSPuses.</summary>
    //[KSPAddon(KSPAddon.Startup.Instantly, false)]
    [KSPAddon(KSPAddon.Startup.EveryScene, false)]
    public class KspChromaPlugin : MonoBehaviour
    {
        private readonly List<IDataDrain> dataDrains = new List<IDataDrain>();

        /// <summary>The UDP network socket to send keyboard appearance orders to the server.</summary>
        private readonly ISceneManager flightSceneManager = new FlightSceneManager();

        private readonly ISceneManager vabSceneManager = new VabSceneManager();

        private ColorScheme lastScheme = null;

        /// <summary>Called by unity during the launch of this addon.</summary>
        // ReSharper disable once UnusedMember.Local
        private void Awake()
        {
            this.dataDrains.Add(new ColoreDrain());
            AnimationManager.Instance.SetAnimation(new LogoAnimation());

            GameEvents.VesselSituation.onLand.Add(this.CallbackLanded);
            GameEvents.onPartDie.Add(this.CallbackCrash);
            GameEvents.onGameSceneLoadRequested.Add(this.CallbackSceneChange);
        }

        private void CallbackLanded(Vessel vessel, CelestialBody body)
        {
            if (vessel.situation == Vessel.Situations.SPLASHED)
            {
                AnimationManager.Instance.SetAnimation(new SplashdownAnimation());
            }
        }

        private void CallbackCrash(Part part)
        {
            if (FlightGlobals.ActiveVessel.rootPart == part)
            {
                AnimationManager.Instance.SetAnimation(new CrashAnimation());
            }
        }

        private void CallbackSceneChange(GameScenes scene)
        {
            switch (scene)
            {
                case GameScenes.EDITOR:
                case GameScenes.FLIGHT:
                case GameScenes.LOADING:
                case GameScenes.LOADINGBUFFER:
                case GameScenes.PSYSTEM:
                    AnimationManager.Instance.SetAnimation(null);
                    break;
                default:
                    AnimationManager.Instance.SetAnimation(new LogoAnimation());
                    break;
            }
        }

        /// <summary>Called by unity on every physics frame.</summary>
        // ReSharper disable once UnusedMember.Local
        private void Update()
        {
            ColorScheme scheme;

            if (AnimationManager.Instance.AnimationRunning())
            {
                scheme = AnimationManager.Instance.GetFrame();
            }
            else
            {
                switch (HighLogic.LoadedScene)
                {
                    case GameScenes.FLIGHT:
                        scheme = this.flightSceneManager.GetScheme();
                        break;
                    case GameScenes.EDITOR:
                        scheme = this.vabSceneManager.GetScheme();
                        break;
                    default:
                        scheme = new LogoScheme();
                        break;
                }
            }

            bool update;
            if (lastScheme == null)
            {
                update = true;
            }
            else
            {
                update = scheme.Count != lastScheme.Count || scheme.Except(lastScheme).Any();
            }

            if (update)
            {
                this.dataDrains.ForEach(drain => drain.Send(scheme));
                lastScheme = scheme;
            }
        }
    }
}