using System;
using Exiled.API.Features;

namespace RemoteKeycard
{
    /// <summary>
    /// The plugin's core class.
    /// </summary>
    public class RemoteKeycard : Plugin<Config.Config>
    {

        /// <summary>
        /// Gets a static instance of this class.
        /// </summary>
        public static RemoteKeycard Instance { get; private set; }

        /// <inheritdoc/>
        public override string Name => "RemoteKeycard";

        /// <inheritdoc/>
        public override string Prefix => "remotekeycard";

        /// <inheritdoc/>
        public override Version RequiredExiledVersion => new Version(7, 0, 0);

        /// <inheritdoc/>
        public override string Author => "Beryl + creepycats";

        /// <inheritdoc/>
        public override Version Version => new Version(4, 0, 0);

        /// <inheritdoc cref="EventsHandler"/>
        public EventsHandler Handler { get; private set; }

        /// <summary>
        /// Instance initializer.
        /// </summary>
        public RemoteKeycard() => Instance = this;

        /// <inheritdoc/>
        public override void OnEnabled()
        {
            Log.Info("Remote Keycards v" + Version + " - Original By Beryl, Ported to v13 by creepycats");
            if (Config.Extras.DebugMode)
            {
                Log.Debug("Initializing events...");
            }
            Handler = new EventsHandler(Config);
            Handler.Start();
            if (Config.Extras.DebugMode)
            {
                Log.Debug("Events initialized successfully.");
            }

            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            if (Config.Extras.DebugMode) {
                Log.Debug("Stopping events...");
            }
            Handler.Stop();
            Handler = null;
            if (Config.Extras.DebugMode)
            {
                Log.Debug("Events stopped successfully.");
            }

            base.OnDisabled();
        }
    }
}
