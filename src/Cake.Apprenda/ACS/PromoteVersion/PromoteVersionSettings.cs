﻿using System;

namespace Cake.Apprenda.ACS.PromoteVersion
{
    /// <summary>
    /// Contains settings used by <see cref="PromoteVersion"/>
    /// </summary>
    public sealed class PromoteVersionSettings : ACSSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteVersionSettings"/> class.
        /// </summary>
        /// <param name="appAlias">The application alias.</param>
        /// <param name="versionAlias"></param>
        public PromoteVersionSettings(string appAlias, string versionAlias)
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
        /// <value>
        /// The application alias.
        /// </value>
        public string AppAlias { get; }

        /// <summary>
        /// Gets the version alias.
        /// </summary>
        /// <value>
        /// The version alias.
        /// </value>
        public string VersionAlias { get; }
        
        /// <summary>
        /// Gets or sets the initial application stage.
        /// </summary>
        /// <value>
        /// The stage.
        /// </value>
        public ApplicationStage? Stage { get; set; }

    }
}