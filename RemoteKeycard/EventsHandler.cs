﻿using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Interactables.Interobjects.DoorUtils;
using RemoteKeycard.API.Extensions;
using RemoteKeycard.Handlers;
using Players = Exiled.Events.Handlers.Player;

namespace RemoteKeycard
{
    /// <summary>
    /// Handles all the events this plugin needs to function.
    /// </summary>
    public class EventsHandler
    {
        private readonly Config.Config config;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsHandler"/> class.
        /// </summary>
        /// <param name="config">The <see cref="Config.Config"/> settings that will be used.</param>
        public EventsHandler(Config.Config config) => this.config = config;

        /// <summary>
        /// Registers all events used.
        /// </summary>
        public void Start()
        {
            Players.InteractingDoor += OnDoorInteract;
            Players.UnlockingGenerator += OnGeneratorUnlock;
            Players.InteractingLocker += OnLockerInteract;
            Players.ActivatingWarheadPanel += OnWarheadUnlock;
        }

        /// <summary>
        /// Unregisters all events used.
        /// </summary>
        public void Stop()
        {
            Players.InteractingDoor -= OnDoorInteract;
            Players.UnlockingGenerator -= OnGeneratorUnlock;
            Players.InteractingLocker -= OnLockerInteract;
            Players.ActivatingWarheadPanel -= OnWarheadUnlock;
        }

        private void OnDoorInteract(InteractingDoorEventArgs ev)
        {
            try
            {
                if(!config.AffectDoors)
                    return;

                if(!ev.IsAllowed && ev.Player.HasKeycardPermission(ev.Door.RequiredPermissions.RequiredPermissions))
                {
                    if(config.Extras.EnableEvents)
                    {
                        var _ev = new API.EventArgs.KeycardDoorEventArgs(ev.Player, ev);

                        Events.OnUsingKeycardDoor(_ev);

                        if(!_ev.IsAllowed)
                            return;
                    }

                    ev.IsAllowed = true;
                }

            } catch(Exception e)
            {
                if (config.Extras.ShowExceptions) {
                    Log.Debug($"{nameof(OnDoorInteract)}: {e.Message}\n{e.StackTrace}");
                }
            }
        }

        private void OnWarheadUnlock(ActivatingWarheadPanelEventArgs ev)
        {
            try
            {
                if(!config.AffectWarheadPanel)
                    return;

                if(!ev.IsAllowed && ev.Player.HasKeycardPermission(KeycardPermissions.AlphaWarhead))
                {
                    if(config.Extras.EnableEvents)
                    {
                        var _ev = new API.EventArgs.KeycardWarheadEventArgs(ev.Player, ev);

                        Events.OnUsingKeycardWarhead(_ev);

                        if(!_ev.IsAllowed)
                            return;
                    }

                    ev.IsAllowed = true;
                }
            } catch(Exception e)
            {
                if (config.Extras.ShowExceptions)
                {
                    Log.Debug($"{nameof(OnWarheadUnlock)}: {e.Message}\n{e.StackTrace}");
                }
            }
        }

        private void OnGeneratorUnlock(UnlockingGeneratorEventArgs ev)
        {
            try
            {
                if(!config.AffectGenerators)
                    return;

                if(!ev.IsAllowed && ev.Player.HasKeycardPermission(KeycardPermissions.ArmoryLevelTwo))
                {
                    if(config.Extras.EnableEvents)
                    {
                        var _ev = new API.EventArgs.KeycardGeneratorEventArgs(ev.Player, ev);

                        Events.OnUsingKeycardGenerator(_ev);

                        if(!_ev.IsAllowed)
                            return;
                    }

                    ev.IsAllowed = true;
                }
            } catch(Exception e)
            {
                if (config.Extras.ShowExceptions)
                {
                    Log.Debug($"{nameof(OnGeneratorUnlock)}: {e.Message}\n{e.StackTrace}");
                }
            }
        }

        private void OnLockerInteract(InteractingLockerEventArgs ev)
        {
            try
            {
                if(!config.AffectScpLockers)
                    return;

                if(!ev.IsAllowed && ev.Chamber != null && ev.Player.HasKeycardPermission(ev.Chamber.RequiredPermissions, true))
                {
                    if(config.Extras.EnableEvents)
                    {
                        var _ev = new API.EventArgs.KeycardLockerEventArgs(ev.Player, ev);

                        Events.OnUsingKeycardLocker(_ev);

                        if(!_ev.IsAllowed)
                            return;
                    }

                    ev.IsAllowed = true;
                }
            } catch(Exception e)
            {
                if (config.Extras.ShowExceptions)
                {
                    Log.Debug($"{nameof(OnLockerInteract)}: {e.Message}\n{e.StackTrace}");
                }
            }
        }
    }
}