using Exiled.API.Features;
using Exiled.Events.EventArgs.Interfaces;

namespace RemoteKeycard.API.EventArgs
{
    /// <summary>
    /// Contains all the information before a <see cref="Exiled.API.Features.Player"/> unlocks an object with a keycard.
    /// </summary>
    public class KeycardDoorEventArgs : Exiled.Events.EventArgs.Interfaces.IExiledEvent
    {
        /// <inheritdoc/>
        public KeycardDoorEventArgs(Player player, Exiled.Events.EventArgs.Player.InteractingDoorEventArgs originalEvent, bool isAllowed = true)
        {
            Player = player;
            IsAllowed = isAllowed;
            OriginalEvent = originalEvent;
        }

        /// <summary>
        /// Gets the <see cref="Exiled.API.Features.Player"/> who used a keycard.
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// Gets or sets whether the object is unlocked.
        /// </summary>
        public bool IsAllowed { get; set; }

        /// <summary>
        /// Gets the original Exiled <see cref="System.EventArgs"/> this is tied to.
        /// </summary>
        public Exiled.Events.EventArgs.Player.InteractingDoorEventArgs OriginalEvent { get; }
    }
    /// <summary>
    /// Contains all the information before a <see cref="Exiled.API.Features.Player"/> unlocks an object with a keycard.
    /// </summary>
    public class KeycardWarheadEventArgs : Exiled.Events.EventArgs.Interfaces.IExiledEvent
    {
        /// <inheritdoc/>
        public KeycardWarheadEventArgs(Player player, Exiled.Events.EventArgs.Player.ActivatingWarheadPanelEventArgs originalEvent, bool isAllowed = true)
        {
            Player = player;
            IsAllowed = isAllowed;
            OriginalEvent = originalEvent;
        }

        /// <summary>
        /// Gets the <see cref="Exiled.API.Features.Player"/> who used a keycard.
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// Gets or sets whether the object is unlocked.
        /// </summary>
        public bool IsAllowed { get; set; }

        /// <summary>
        /// Gets the original Exiled <see cref="System.EventArgs"/> this is tied to.
        /// </summary>
        public Exiled.Events.EventArgs.Player.ActivatingWarheadPanelEventArgs OriginalEvent { get; }
    }
    /// <summary>
    /// Contains all the information before a <see cref="Exiled.API.Features.Player"/> unlocks an object with a keycard.
    /// </summary>
    public class KeycardGeneratorEventArgs : Exiled.Events.EventArgs.Interfaces.IExiledEvent
    {
        /// <inheritdoc/>
        public KeycardGeneratorEventArgs(Player player, Exiled.Events.EventArgs.Player.UnlockingGeneratorEventArgs originalEvent, bool isAllowed = true)
        {
            Player = player;
            IsAllowed = isAllowed;
            OriginalEvent = originalEvent;
        }

        /// <summary>
        /// Gets the <see cref="Exiled.API.Features.Player"/> who used a keycard.
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// Gets or sets whether the object is unlocked.
        /// </summary>
        public bool IsAllowed { get; set; }

        /// <summary>
        /// Gets the original Exiled <see cref="System.EventArgs"/> this is tied to.
        /// </summary>
        public Exiled.Events.EventArgs.Player.UnlockingGeneratorEventArgs OriginalEvent { get; }
    }
    /// <summary>
    /// Contains all the information before a <see cref="Exiled.API.Features.Player"/> unlocks an object with a keycard.
    /// </summary>
    public class KeycardLockerEventArgs : Exiled.Events.EventArgs.Interfaces.IExiledEvent
    {
        /// <inheritdoc/>
        public KeycardLockerEventArgs(Player player, Exiled.Events.EventArgs.Player.InteractingLockerEventArgs originalEvent, bool isAllowed = true)
        {
            Player = player;
            IsAllowed = isAllowed;
            OriginalEvent = originalEvent;
        }

        /// <summary>
        /// Gets the <see cref="Exiled.API.Features.Player"/> who used a keycard.
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// Gets or sets whether the object is unlocked.
        /// </summary>
        public bool IsAllowed { get; set; }

        /// <summary>
        /// Gets the original Exiled <see cref="System.EventArgs"/> this is tied to.
        /// </summary>
        public Exiled.Events.EventArgs.Player.InteractingLockerEventArgs OriginalEvent { get; }
    }
}
