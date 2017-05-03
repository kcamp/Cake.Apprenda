﻿using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Apprenda.ACS.StartVersion
{
    /// <summary>
    /// Demotes a version of an application to the specified stage
    /// </summary>
    /// <seealso cref="CloudShellTool{TSettings}" />
    public sealed class StartVersion : CloudShellTool<StartVersionSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartVersion" /> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tools.</param>
        /// <param name="resolver">The resolver.</param>
        public StartVersion(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools, CloudShellToolResolver resolver)
            : base(fileSystem, environment, processRunner, tools, resolver)
        {
        }

        /// <summary>
        /// Executes the specified settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public void Execute(StartVersionSettings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            var builder = new ProcessArgumentBuilder();

            builder.Append("StartVersion");
            builder.Append("--NonInteractive");
            builder.Append("-Y");

            builder.Append("-AppAlias");
            builder.AppendQuoted(settings.AppAlias);

            builder.Append("-VersionAlias");
            builder.Append(settings.VersionAlias);

            Run(settings, builder);
        }
    }
}
