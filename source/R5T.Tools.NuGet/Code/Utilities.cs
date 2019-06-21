using System;

using R5T.Code.VisualStudio.IO;
using R5T.NetStandard.IO.Paths;

using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;
using VsIoUtilities = R5T.Code.VisualStudio.IO.Utilities;


namespace R5T.Tools.NuGet
{
    public static class Utilities
    {
        /// <summary>
        /// The default package ID is the same as the project file-name-without-extensions.
        /// </summary>
        public static PackageID GetDefaultPackageID(FileNameWithoutExtension projectFileNameWithoutExtension)
        {
            var packageID = new PackageID(projectFileNameWithoutExtension.Value);
            return packageID;
        }

        public static PackageID GetDefaultPackageID(ProjectFileName projectFileName)
        {
            var projectFileNameWithoutExtension = PathUtilities.GetFileNameWithoutExtension(projectFileName);

            var packageID = Utilities.GetDefaultPackageID(projectFileNameWithoutExtension);
            return packageID;
        }

        public static PackageID GetDefaultPackageID(ProjectFilePath projectFilePath)
        {
            var projectFileName = VsIoUtilities.GetProjectFileName(projectFilePath);

            var packageID = Utilities.GetDefaultPackageID(projectFileName);
            return packageID;
        }
    }
}
