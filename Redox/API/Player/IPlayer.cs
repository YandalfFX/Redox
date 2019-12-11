﻿using System;


namespace Redox.API.Player
{
    /// <summary>
    /// Base representation for Players
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// The display name of the player
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The type name of the player, Example "Guard", "Monster"
        /// </summary>
        string TypeName { get; }

        /// <summary>
        /// The SteamID of the player
        /// </summary>
        string ID { get; }

        /// <summary>
        /// The steam ID as ulong
        /// </summary>
        ulong UID { get; }

        /// <summary>
        /// Health of the player
        /// </summary>
        float Health { get; }

        /// <summary>
        /// Maximum health of the player
        /// </summary>
        float MaxHealth { get; }

        /// <summary>
        /// The date of the join session
        /// </summary>
        DateTime JoinDate { get; }

        /// <summary>
        /// The date of the leave session
        /// 
        /// <para> Returns null if the player never left</para>
        /// </summary>
        DateTime? LeaveDate { get; }

        /// <summary>
        /// The original object of the player
        /// </summary>
        object OriginalPlayer { get; }

        /// <summary>
        /// Sends a chat message to the user
        /// </summary>
        /// <param name="message"></param>
        void Message(string message);

        /// <summary>
        /// Sends a chat message along with an prefix
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="message"></param>
        void Message(string prefix, string message);

        /// <summary>
        /// Disconnects the player from the server
        /// </summary>
        void Disconnect();

        /// <summary>
        /// Disconnects the player from the server with a message
        /// </summary>
        /// <param name="reason"></param>
        void Disconnect(string reason);
    }
}