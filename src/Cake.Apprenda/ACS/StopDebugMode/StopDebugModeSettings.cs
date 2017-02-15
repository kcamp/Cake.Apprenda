﻿using System;

namespace Cake.Apprenda.ACS.StopDebugMode
{
    /// <summary>
    /// Contains settings used by <see cref="StopDebugMode"/>
    /// </summary>
    public sealed class StopDebugModeSettings : ACSSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StopDebugModeSettings"/> class.
        /// </summary>
        /// <param name="appAlias">The application alias.</param>
        /// <param name="versionAlias"></param>
        public StopDebugModeSettings(string appAlias, string versionAlias)
        {
            if (string.IsNullOrEmpty(appAlias))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(appAlias));
            }

            if (string.IsNullOrEmpty(versionAlias))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(versionAlias));
            }

            this.AppAlias = appAlias;
            this.VersionAlias = versionAlias;
        }

        /// <summary>
        /// Gets the application alias.
        /// </summary>
        public string AppAlias { get; }

        /// <summary>
        /// Gets the version alias.
        /// </summary>
        public string VersionAlias { get; }

        /// <summary>
        /// Gets or sets the component alias.
        /// </summary>
        public string ComponentAlias { get; set; }

    }
}