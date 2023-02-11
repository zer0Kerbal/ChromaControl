<!-- readme.md v1.7.0.1
KSP Chroma Control (KCC)
created: 17 Jul 2017
updated: 17 Jan 2023

TEMPLATE: readme.md v1.7.0.2
created: 17 Jul 2017
updated: 10 Feb 2023

this file: CC BY-ND 4.0 by zer0Kerbal-->

[![KSP Chroma Control (KCC)][SHD:mod]][forum] [![KSP version][KSP:shd]][KSP:url]  [![License][LIC:shd]][LIC:url]  
[![Curseforge][CURSFG:shd]][CURSFG:url] [![GitHub][GITHUB:shd]][GITHUB:url] [![SpaceDock][SPCDCK:shd]][SPCDCK:url] [![CKAN][ckan:shd]][ckan:url]  
[![GitHub Pages][SHD:pages]][pages]

![Code][SHD:code]


# KSP Chroma Control (KCC)


Lights up your keyboard to make playing Kerbal Space Program a lot easier. Currently only supports Razer Chroma Keyboards, Mousepads, Mice and Headsets. If you want me to add support for other devices as well, you'll have to send me one. I can send it back after I'm done implementing the code. Enough talk, watch this awesome video by [Game Instructor](https://www.youtube.com/channel/UCeiT-KYAvbos30RKre4W9UQ) to see what this mod really is all about: https://www.youtube.com/watch?v=-nqTzKLMGuU


## By [`zer0Kerbal`][zer0Kerbal], originally by [`FauserneEist`][FauserneEist]

adopted with *express* permission and brought to you by *KerbSimpleCo*

<img src="https://raw.githubusercontent.com/zer0Kerbal/KSPChromaControl/master/img/HeroLogo_1920x1920.png" alt="KSPChromaControl Hero" width="50%" height="50%">

### Preamble by [`FauserneEist`][FauserneEist]

## Known Issues
Due to a bug in the SDK, some people reported strange flickering. This occurs if you use a custom color scheme on your keyboard. To fix this, switch to the standard color scheme and start the game afterwards.

## Features

* Function keys 1 to 0 are only lit, if the underlying action group actually does anything. The keys are displayed in two different colors, depending on whether the action group is toggled or not.
* The keys for SAS, RCS, Gears, Lights and the Brakes are lit up in different colors, indicating if the respective system was activated or not.
* The amount of resources in the current stage is displayed on your keypad and the keys to the left of it (PrtScr, ScrLk, ..., PageDown)
* The color of W, A, S, D, E and Q varies slightly depending on whether you're in precision or normal steering mode
* The keys for timewarp control are lit either red for physics timewarp or green for normal timewarp

## Full list of game effects

* Stylized Kerbal Space Program logo that fades in on every scene that does not contain any noteworthy keyboard interaction (pressing Escape to go to the menu not being noteworthy enough to light up the key)
* In the vessel editor, different kinds of keysets are lit up according to the current editor mode.
* Control keys and toggleable function keys are lit up in different colors, showing whether the function is switched on or off during flight.
* Reduced keyset lit for EVA mode
* Resource gauges displayed on the keypad and the keys above the UpDownLeftRight keys.
* Power failure animation on vessels that need power to be controllable
* Crash animation that triggers when crashing a vessel's root part
* Splashdown animation that triggers, when landing on water.
* Vessel electricity status displayed on any Razer mouse and mousepad connected
* Vessel heat displayed in three colors (blue = cool, red = warm/hot, yellow = you're in trouble), uses the scrollwheel and logo on mice and the bottom LEDs on the mousepad.
* "Dear GF, please don't disturb me now" feature on the headset. The device is colored red, when you can't quicksave right now. Turns green once quicksave is allowed again.
* Vessel height above ground displayed on F1 to F4 keys (F1 = 10m, F2 = 50m, F3 = 100m, F4 = 1000m). The intensity changes, e.g. if F1 is fully lit and F2 is half lit, you are 30 meters above ground.

## Installation

1. Unzip the release archive and place the KSPChromaControl folder in your KSP GameData directory.
2. Start KSP and witness the awesomeness of highlighted function keys while kerbaling through space
3. (optional) Move the file ChromaAppInfo.xml from the mod folder into the KSP folder, to allow Synapse to recognize the game properly.

## Todo

* Make fuel gauge position device dependent (Blackwidow Chroma / Blackwidow Chroma TE / Orbweaver)
* Light up all keys when the player is entering text (vessel name, savegame, etc.)
* Different colors for different altimeter zoom levels.
* Linux version (this might take a bit longer, but I'm planning to do it anyway. What good is a c# interface if it is only ever implemented once...)

### See more

>* [ChangeLog][chlog] for more details of changes
>* [Discussions][discu] or [KSP Forums][forum] for discussions and news
>* [GitHub Pages][pages]
>* [Known Issues][issue] for more details of feature requests and known issues
>* [Marketing Slicks][markt]

### YouTube review by [`Kottabos Gaming`](https://forum.kerbalspaceprogram.com/index.php?/profile/36583-*/)

[![Kottabos reviews KSPChromaControl](https://img.youtube.com/vi/Oj1etoybd7E/0.jpg)](https://youtu.be/Oj1etoybd7E)

### Help Wanted

> * Compatibility patches
> * Contracts for these glorious parts
> * Variant Textures
> * Converting from FireSpitter to Stock and/or KSPWheel  
> * Model updates (add/improve lights, iva, hatches and so forth)
> * Marketing Images and Videos such as hero shots, animated gifs, short highlights
> * Translations: See the [README in the Localization folder][lreadme] for instructions for adding or improving translations. There is also the [quickstart guide][qstart]. [GitHub][GitHub:url] push is the best way to contribute. *Additions and corrections welcome!*
> * Have a request? Glad to have them, kindly submit through [GitHub][issue].

### Localization

>* ![English][EN] English
>* ***your translation here***

### Installation Directions [^1]

Use CurseForge/OverWolf Website/App

<a href="https://download.curseforge.com/"><img src="https://www.overwolf.com/brand-guidelines/img/logo2.svg" alt="CurseForge/OverWolf App" height="80px"></a>

or<a href="https://forum.kerbalspaceprogram.com/index.php?/topic/197082-*/"><img src="https://i.postimg.cc/x8XSVg4R/sj507JC.png" alt="CKAN App" height="75px"></a>

I take no part, nor am I interested in maintaining the [CKAN][ckan:url] metadata for my mods. [CKAN][ckan:url] is a great mod for those that can't use zip tools. If you are having issues please let the [CKAN][ckan:url] people know and refer to the [CKAN][ckan:url] thread. My support of [CKAN][ckan:url] extends with checking the checkbox in [SpaceDock][SPCDCK:url]. Beware, [CKAN][ckan:url] *can* really mess up; though it tries very, very, very hard not to.

OLD: <a href="https://download.curseforge.com/"> <img src="https://www.overwolf.com/brand-guidelines/img/logo2.svg" alt="CurseForge/OverWolf App" width="15%" height="15%"></a>
OLD: [![CKAN][ckan:img]][ckan:url]

### Dependencies

* Razer Synopsis2+Synopsis+ChromaMod
* [Kerbal Space Program][KSP:url] [![Kerbal Space Program][KSP:shd]][KSP:url] [^2]

### Suggests

* [Adjustable Mod Panel (KAMP)][KAMP]
* [Biomatic (BIO)][BIO]
* [GPO (Goo Pumps & Oils') Speed Pump (GPO)][GPO]
* [Kaboom! (BOOM)][BOOM]
* [MoarKerbals (MOAR)][MOAR]
* [On Demand Fuel Cells (ODFC)][ODFC]
* [Precise Maneuver (PM)][PM]
* [SimpleConstruction! (SCON)][SCON]
* [SimpleLogistics! (SLOG)][SLOG]
* [SimpleNotes! (NOTE)][NOTES]

### Tags

plugin, information

<div style="border:0.5px solid Tomato; background-color: #BADA55; color: #FF0000; text-align:center">
  <p><b>red box below is a link to forum post on how to get support</b></p>
  <a href="https://forum.kerbalspaceprogram.com/index.php?/topic/83212-*">
    <p><img src="https://i.postimg.cc/vHP6zmrw/image.png" alt="How to get support"></p></a>
  <p style="color: #000000;">Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date</p>
</div>

### Credits and Special Thanks

>* [FauserneEist][FauserneEist] for creating this glorious plugin addon!
>* see [Attributions][attrb] for more

### Legal Mumbo Jumbo (License *provenance*)

#### Author (1) - [`zer0Kerbal`][zer0Kerbal]

> Forum: [Thread][forum] - Source: [GitHub][GITHUB:url]  
> License: [![License][LIC:shd]][LIC:url] ![License][LIC:log]
>
> ##### Disclaimer(s)
>
> ***All bundled mods are distributed under their own licenses***  
> ***All assets, including but not limited to: animations, models, sounds and textures are distributed under their own licenses***

##### see [Notices][notic] for more *legal Mumbo Jumbo*

#### Original (ROOT) (0) - Author: [`FauserneEist`][FauserneEist]

> Forum: [Thread][MOD:0:thread] - Download: [CurseForge][MOD:0:dnload] - Source: [CurseForge][MOD:0:source]  
> License: [![License][LIC:0:shd]][LIC:0:url] ![License][LIC:0:log]

### How to support this and other great mods by [`zer0Kerbal`][zer0Kerbal]

> ***Completely voluntary, absolutely amazing, and really does help me out a lot!***  
> quote from <a href="https://forum.kerbalspaceprogram.com/index.php?/profile/32393-*/"><img src="https://kerbal-forum-uploads.s3.us-west-2.amazonaws.com/monthly_2020_06/kappa-kerbal-anarchy.thumb.png.673a2f6f7b36cc60a35c24efef217246.png" width="25px" height="25px" alt="cybutek" > cybutek</a> creator of <a href="https://forum.kerbalspaceprogram.com/index.php?/topic/17833-130-*/" alt="Kerbal Engineer Redux (KER)"> Kerbal Engineer</a>

[![Support][PAYPAL:img]][PAYPAL:url] [![Github Sponsor][GSPONS:img]][GSPONS:url] [![Patreon][PATREON:img]][PATREON:url] [![Buy zer0Kerbal a snack][BMCC:img]][BMCC:url]

*and it is true.*

<!-- links -->
[attrb]: https://zer0kerbal.github.io/KSPChromaControl/Attributions "Attribution"
[chlog]: https://raw.githubusercontent.com/zer0Kerbal/KSPChromaControl/master/changelog.md  "Changelog"
[discu]: https://github.com/zer0Kerbal/KSPChromaControl/discussions "Discussions"
[forum]: https://forum.kerbalspaceprogram.com/index.php?/topic/192742-*/ "KSPChromaControl Forum Thread"
[issue]: https://github.com/zer0Kerbal/KSPChromaControl/issues "Issues"
[markt]: https://zer0kerbal.github.io/KSPChromaControl/Marketing "Marketing Slicks"
[notic]: https://zer0kerbal.github.io/KSPChromaControl/Notices "Notices"
[pages]: https://zer0kerbal.github.io/KSPChromaControl "GitHub Pages"

<!--- shields -->
[SHD:mod]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/KSPChromaControl/master/json/mod.json
[SHD:code]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/KSPChromaControl/master/json/code.json
[SHD:pages: https://img.shields.io/badge/GitHub-Pages-white?style=plastic&labelColor=9cf&logoColor=181717&logo=github "GitHub IO"

<!--- mod provenance -->
[MOD:0:dnload]: https://www.curseforge.com/kerbal/ksp-mods/kspchromacontrol "CurseForge"
[MOD:0:source]: https://www.curseforge.com/kerbal/ksp-mods/kspchromacontrol "CurseForge"
[MOD:0:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/64520-*/ "KSP Forum"

<!--- license provenance -->
[LIC:0:url]: https://www.gnu.org/licenses/gpl-3.0-standalone.html "GPL-3.0"
[LIC:0:log]: https://i.postimg.cc/9FrwMgK6/GPL-17x17.png "GPL-3.0"
[LIC:0:shd]: https://img.shields.io/badge/License-GPL--3.0-A42E2B?style=plastic&labelColor=white&logoColor=A42E2B&logo=gnu "GPL-3.0"

[LIC:url]: https://www.gnu.org/licenses/gpl-3.0-standalone.html "GPL-3.0"
[LIC:log]: https://i.postimg.cc/9FrwMgK6/GPL-17x17.png "GPL-3.0"
[LIC:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/KSPChromaControl/master/json/license.json "GPL-3.0"

<!--- release links -->
[CURSFG:url]: https://www.curseforge.com/kerbal/ksp-mods/KSPChromaControl "Curseforge"
[CURSFG:shd]: https://img.shields.io/badge/CurseForge-Link-CCFF00.svg?labelColor=6441A4&style=plastic&logo=curseforge "Curseforge"

[GITHUB:url]: https://github.com/zer0Kerbal/KSPChromaControl/ "GitHub"
[GITHUB:shd]: https://img.shields.io/badge/Github-Link-CCFF00.svg?labelColor=071776&style=plastic&logo=github "GitHub"

[SPCDCK:url]: https://spacedock.info/mod/SP-ID "SpaceDock"
[SPCDCK:shd]: https://img.shields.io/badge/SpaceDock-Link-CCFF00.svg?labelColor=000000&style=plastic&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDE5LjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPgo8c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkxheWVyXzEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4IgoJIHZpZXdCb3g9IjAgMCA1MDAgNTAwIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA1MDAgNTAwOyIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+Cgkuc3Qwe2ZpbGw6IzFBMUExQTt9Cgkuc3Qxe2ZpbGw6IzA1Nzg5Mzt9Cgkuc3Qye2ZpbGw6IzA3QUNEMjt9Cjwvc3R5bGU+CjxwYXRoIGlkPSJYTUxJRF8xXyIgY2xhc3M9InN0MCIgZD0iTTQwMCwwLjZIMTAwYy01NSwwLTEwMCw0NS0xMDAsMTAwVjQwMGMwLDU1LDQ1LDEwMCwxMDAsMTAwaDMwMGM1NSwwLDEwMC00NSwxMDAtMTAwVjEwMC42CglDNTAwLDQ1LjYsNDU1LDAuNiw0MDAsMC42eiIvPgo8ZyBpZD0iWE1MSURfNl8iPgoJPGcgaWQ9IlhNTElEXzlfIj4KCQk8cGF0aCBpZD0iWE1MSURfMTdfIiBjbGFzcz0ic3QxIiBkPSJNMTgzLjMsMTY1LjljNi40LTMuNiwxNi45LTMuNiwyMy4zLDBMNDY3LjQsMzE0YzYuNCwzLjYsNi40LDkuNiwwLDEzLjJMMjA2LjYsNDc0LjQKCQkJYy02LjQsMy42LTE3LjcsNi42LTI1LDYuNmgtNDQuOGMtNy40LDAtOC4xLTMtMS43LTYuNmwyNjEtMTQ3LjJjNi40LTMuNiw2LjQtOS42LDAtMTMuMkwxNzEsMTg2Yy02LjQtMy42LTYuNC05LjYsMC0xMy4yCgkJCUwxODMuMywxNjUuOXoiLz4KCTwvZz4KCTxnIGlkPSJYTUxJRF84XyI+CgkJPHBhdGggaWQ9IlhNTElEXzE2XyIgY2xhc3M9InN0MiIgZD0iTTMxOC44LDE5Yy03LjQsMC0xOC42LDIuOC0yNSw2LjRMMzMsMTczLjRjLTYuNCwzLjYtNi40LDkuNSwwLDEzLjFsMjYwLjcsMTQ3LjEKCQkJYzYuNCwzLjYsMTYuOSwzLjYsMjMuMywwbDEyLjMtN2M2LjQtMy42LDYuNC05LjUsMC0xMy4ybC0yMjUuMS0xMjdjLTYuNC0zLjYtNi40LTkuNSwwLTEzLjJMMzY1LjYsMjUuNGM2LjQtMy42LDUuNi02LjQtMS43LTYuNAoJCQlIMzE4Ljh6Ii8+Cgk8L2c+CjwvZz4KPC9zdmc+Cg==  "SpaceDock"

[ckan:url]: https://forum.kerbalspaceprogram.com/index.php?/topic/197082-*/ "CKAN"
[ckan:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/KSPChromaControl/master/json/ckan.json "CKAN"

<!-- Kerbal Space Program -->
[KSP:url]: https://kerbalspaceprogram.com/ "Kerbal Space Program"
[KSP:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/KSPChromaControl/master/json/ksp.json&logo=data:image/webp;base64,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 "Kerbal Space Program"

<!-- links to add-ons/mods -->
[BIO]: https://forum.kerbalspaceprogram.com/index.php?/topic/191426-*/ "Biomatic (BIO)"
[BOOM]: https://forum.kerbalspaceprogram.com/index.php?/topic/192938-*/ "Kaboom! (BOOM)"
[GPO]: https://forum.kerbalspaceprogram.com/index.php?/topic/207732-*/ "GPO SpeedPump (GPO)"
[KAMP]: https://forum.kerbalspaceprogram.com/index.php?/topic/207263-*/ "Adjustable Mod Panel (KAMP)"
[MOAR]: https://forum.kerbalspaceprogram.com/index.php?/topic/191525-*/ "MoarKerbals (MOAR)"
[NOTES]: https://forum.kerbalspaceprogram.com/index.php?/topic/207118-*/ "SimpleNotes! (NOTES)"
[ODFC]: https://forum.kerbalspaceprogram.com/index.php?/topic/187625-*/ "On Demand Fuel Cells (ODFC)"
[PM]: https://forum.kerbalspaceprogram.com/index.php?/topic/207261-*/ "Precise Maneuver (PM)"
[SCON]: https://forum.kerbalspaceprogram.com/index.php?/topic/191424-*/ "SimpleConstruction! (SCON)"
[SLOG]: https://forum.kerbalspaceprogram.com/index.php?/topic/191045-*/ "SimpleLogistics! (SLOG)"

<!-- financial support -->
[PAYPAL:img]: https://img.shields.io/badge/Buy%20me%20some%20-LFO-BADA55?style=for-the-badge&logo=paypal&labelColor=FFDD00/ "PayPal"
[PAYPAL:url]: https://www.paypal.com/donate?hosted_button_id=DC22YHMEJREKL/ "PayPal"
[PATREON:img]: https://img.shields.io/badge/Patreon%20-Patreonize-FF424D?style=for-the-badge&logo=patreon/ "Patreon"
[PATREON:url]: https://www.patreon.com/bePatron?u=23390503/ "Patreon"
[GSPONS:img]: https://img.shields.io/badge/Github%20-Sponsor-EA4AAA?style=for-the-badge&logo=githubsponsors/ "Github Sponsors"
[GSPONS:url]: https://github.com/sponsors/zer0Kerbal/ "Github Sponsors"
[BMCC:img]: https://img.shields.io/badge/Buy%20Me%20a%20-Snack!-FFDD00?style=for-the-badge&logo=buymeacoffee/ "Buy Me A Snack"
[BMCC:url]: https://buymeacoffee.com/zer0Kerbal/ "Buy Me A Snack"

<!-- Localization -->
[lreadme]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/readme.md "Localization Readme"
[qstart]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/quickstart.md "Quickstart"
[EN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/EN.png "English"

[curseforge]: https://www.curseforge.com/members/zer0kerbal/projects
[reddit]: https://www.reddit.com/user/zer0Kerbal
[twitch]: https://www.twitch.tv/zer0kerbal
[twitter]: https://twitter.com/zer0Kerbal
[youtube]: https://www.youtube.com/@zer0Kerbal
<!-- [steam]: https://steamcommunity.com/id/zeroKerbal -->

[FauserneEist]: https://forum.kerbalspaceprogram.com/index.php?/profile/161819-*/ "FauserneEist"
[zer0Kerbal]: https://forum.kerbalspaceprogram.com/index.php?/profile/190933-*/ "zer0Kerbal"

#### Connect with me

Track progress: issues [here][issue] and projects [here](https://github.com/zer0Kerbal/KSPChromaControl/projects/) along with **[The Short List](https://github.com/users/zer0Kerbal/projects/27)**

[<img align="left" alt="zer0Kerbal | kerbalspaceprogram.com" width="32px" src="https://cdn.icon-icons.com/icons2/1381/PNG/32/kerbalspaceprogram_93898.png" />][zer0Kerbal] [<img align="left" alt="zer0Kerbal | CurseForge" width="32px" src="https://cdn.jsdelivr.net/npm/simple-icons@v3/icons/curseforge.svg" />][curseforge] [<img align="left" alt="zer0Kerbal | reddit" width="32px" src="https://cdn.icon-icons.com/icons2/1945/PNG/512/iconfinder-reddit-4661631_122483.png" />][reddit] [<img align="left" alt="zer0Kerbal | Patreon" width="32px" src="https://cdn.icon-icons.com/icons2/2429/PNG/512/patreon_logo_icon_147253.png" />][PATREON:url] [<img align="left" alt="zer0Kerbal | YouTube" width="32px" src="https://cdn.icon-icons.com/icons2/836/PNG/512/Youtube_icon-icons.com_66802.png" />][youtube] [<img align="left" alt="zer0Kerbal | Twitch" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/twitch_logo_icon_170383.png" />][twitch] [<img align="left" alt="zer0Kerbal | PayPal" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/paypal_logo_icon_168055.png" />][PAYPAL:url] [<img align="left" alt="zer0Kerbal | Buy Me a Coffee" width="32px" src="https://www.buymeacoffee.com/assets/img/bmc-meta-new/new/favicon.ico" />][BMCC:url] [<img align="left" alt="zer0Kerbal | Twitter" width="32px" src="https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/twitter-32.ico" />][twitter]</br> 

##### Release Schedule

1. GitHub, reaching first manual installers and users of KSP-AVC. Right now.
2. CurseForge. Right now.
3. SpaceDock (and CKAN users). Soon™ *(the button was pressed)*

<!-- footnotes -->
[^1]: this isn't a mod. ;P  
[^2]: ***may*** work on other versions (YMMV)  
[^3]: *Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date!*