using System;

using R5T.NetStandard.IO.Paths;
using R5T.Tools.NuGet.IO;


namespace R5T.Tools.NuGet
{
    public static class NuGetCommandExtensions
    {
        public static void Push(this NuGetCommand command, NupkgFilePath packageFilePath, DirectoryPath nugetLocalRepositoryDirectoryPath)
        {
            NuGetCommandServicesProvider.Push(command.NuGetExecutableFilePath, packageFilePath, nugetLocalRepositoryDirectoryPath, command.Logger);
        }
    }
}
