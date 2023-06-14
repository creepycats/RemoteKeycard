using Exiled.Events.Extensions;
using RemoteKeycard.API.EventArgs;
using static Exiled.Events.Events;
using Exiled.Events.EventArgs.Interfaces;

namespace RemoteKeycard.Handlers
{
    /// <summary>
    /// Handler for this plugin's events.
    /// </summary>
    public static class Events
    {
        /// <inheritdoc cref="KeycardDoorEventArgs"/>
        public static event CustomEventHandler<KeycardDoorEventArgs> UsingKeycardDoor;
        /// <inheritdoc cref="KeycardWarheadEventArgs"/>
        public static event CustomEventHandler<KeycardWarheadEventArgs> UsingKeycardWarhead;
        /// <inheritdoc cref="KeycardGeneratorEventArgs"/>
        public static event CustomEventHandler<KeycardGeneratorEventArgs> UsingKeycardGenerator;
        /// <inheritdoc cref="KeycardLockerEventArgs"/>
        public static event CustomEventHandler<KeycardLockerEventArgs> UsingKeycardLocker;

        /// <summary>
        /// Safely invokes <see cref="UsingKeycardDoor"/> event.
        /// </summary>
        /// <param name="ev"></param>
        public static void OnUsingKeycardDoor(KeycardDoorEventArgs ev) => UsingKeycardDoor?.InvokeSafely(ev);
        /// <summary>
        /// Safely invokes <see cref="UsingKeycardWarhead"/> event.
        /// </summary>
        /// <param name="ev"></param>
        public static void OnUsingKeycardWarhead(KeycardWarheadEventArgs ev) => UsingKeycardWarhead?.InvokeSafely(ev);
        /// <summary>
        /// Safely invokes <see cref="UsingKeycardGenerator"/> event.
        /// </summary>
        /// <param name="ev"></param>
        public static void OnUsingKeycardGenerator(KeycardGeneratorEventArgs ev) => UsingKeycardGenerator?.InvokeSafely(ev);
        /// <summary>
        /// Safely invokes <see cref="UsingKeycardLocker"/> event.
        /// </summary>
        /// <param name="ev"></param>
        public static void OnUsingKeycardLocker(KeycardLockerEventArgs ev) => UsingKeycardLocker?.InvokeSafely(ev);

    }
}
