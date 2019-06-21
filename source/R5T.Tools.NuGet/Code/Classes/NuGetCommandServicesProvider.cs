using System;

using Microsoft.Extensions.Logging;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.OS;
using R5T.Tools.NuGet.IO;


namespace R5T.Tools.NuGet
{
    public static class NuGetCommandServicesProvider
    {
        public static void Push(FilePath nugetExecutableFilePath, NupkgFilePath packageFilePath, DirectoryPath nugetLocalRepositoryDirectoryPath, ILogger logger)
        {
            logger.LogDebug($"{packageFilePath} - Pushing package to:\n{nugetLocalRepositoryDirectoryPath}");

            var arguments = $@"push ""{packageFilePath}"" -Source ""{nugetLocalRepositoryDirectoryPath}""";

            ProcessRunner.Run(nugetExecutableFilePath.Value, arguments);

            logger.LogInformation($"{packageFilePath} - Pushed package to:\n{nugetLocalRepositoryDirectoryPath}");
        }
    }
}
