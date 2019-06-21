using System;

using Microsoft.Extensions.Logging;

using R5T.NetStandard.IO.Paths;


namespace R5T.Tools.NuGet
{
    public class NuGetCommand
    {
        public FilePath NuGetExecutableFilePath { get; }
        public ILogger Logger { get; }


        public NuGetCommand(FilePath nuGetExecutableFilePath, ILogger<NuGetCommand> logger)
        {
            this.NuGetExecutableFilePath = nuGetExecutableFilePath;
            this.Logger = logger;
        }
    }
}
