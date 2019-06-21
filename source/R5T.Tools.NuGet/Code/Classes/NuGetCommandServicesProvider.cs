using System;

using Microsoft.Extensions.Logging;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.OS;
using R5T.Tools.NuGet.IO;


namespace R5T.Tools.NuGet
{
    public class NuGetCommandServicesProvider
    {
        public FilePath NuGetExecutableFilePath { get; }


        public NuGetCommandServicesProvider(FilePath nuGetExecutableFilePath)
        {
            this.NuGetExecutableFilePath = nuGetExecutableFilePath;
        }

        public void Push(NupkgFilePath packageFilePath, DirectoryPath nugetLocalRepositoryDirectoryPath, ILogger logger)
        {
            logger.LogDebug($"{packageFilePath} - Pushing package to:\n{nugetLocalRepositoryDirectoryPath}");

            var arguments = $@"push ""{packageFilePath}"" -Source ""{nugetLocalRepositoryDirectoryPath}""";

            ProcessRunner.Run(this.NuGetExecutableFilePath.Value, arguments);

            logger.LogInformation($"{packageFilePath} - Pushed package to:\n{nugetLocalRepositoryDirectoryPath}");
        }
    }
}
