﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.Storage.File.Cmdlet
{
    using global::Azure.Storage.Files.Shares;
    using Microsoft.WindowsAzure.Commands.Common.Storage.ResourceModel;
    using Microsoft.WindowsAzure.Commands.Storage.Common;
    using System.Globalization;
    using System.Management.Automation;

    [Cmdlet("Remove", Azure.Commands.ResourceManager.Common.AzureRMConstants.AzurePrefix + "StorageFile",SupportsShouldProcess = true,DefaultParameterSetName = Constants.ShareNameParameterSetName), OutputType(typeof(AzureStorageFile))]
    public class RemoveAzureStorageFile : AzureStorageFileCmdletBase
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ParameterSetName = Constants.ShareNameParameterSetName,
            HelpMessage = "Name of the file share where the file would be removed.")]
        [ValidateNotNullOrEmpty]
        public string ShareName { get; set; }

        [Parameter(
            Position = 0, 
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = Constants.ShareParameterSetName,
            HelpMessage = "ShareClient object indicated the share where the file would be removed.")]
        [ValidateNotNull]
        public ShareClient ShareClient { get; set; }

        [Parameter(
            Position = 0, 
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = Constants.DirectoryParameterSetName,
            HelpMessage = "ShareDirectoryClient object indicated the base folder where the file would be removed.")]
        [ValidateNotNull]
        public ShareDirectoryClient ShareDirectoryClient { get; set; }

        [Parameter(
            Position = 0, 
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = Constants.FileParameterSetName,
            HelpMessage = "ShareFileClient object indicated the file would be removed.")]
        [ValidateNotNull]
        public ShareFileClient ShareFileClient { get; set; }

        [Parameter(
            Position = 1,
            Mandatory = true,
            ParameterSetName = Constants.ShareNameParameterSetName,
            HelpMessage = "Path of the file to be removed.")]
        [Parameter(
            Position = 1,
            Mandatory = true,
            ParameterSetName = Constants.ShareParameterSetName,
            HelpMessage = "Path of the file to be removed.")]
        [Parameter(
            Position = 1,
            Mandatory = true,
            ParameterSetName = Constants.DirectoryParameterSetName,
            HelpMessage = "Path of the file to be removed.")]
        [ValidateNotNullOrEmpty]
        public string Path { get; set; }

        [Parameter(HelpMessage = "Returns an object representing the removed file. By default, this cmdlet does not generate any output.")]
        public SwitchParameter PassThru { get; set; }

        public override void ExecuteCmdlet()
        {
            ShareFileClient fileToBeRemoved;
            switch (this.ParameterSetName)
            {
                case Constants.FileParameterSetName:
                    CheckContextForObjectInput((AzureStorageContext)this.Context);
                    fileToBeRemoved = this.ShareFileClient;
                    break;

                case Constants.ShareNameParameterSetName:
                    NamingUtil.ValidateShareName(this.ShareName, false);
                    ShareServiceClient fileserviceClient = Util.GetTrack2FileServiceClient((AzureStorageContext)this.Context, ClientOptions);
                    fileToBeRemoved = fileserviceClient.GetShareClient(this.ShareName).GetRootDirectoryClient().GetFileClient(this.Path);
                    break;

                case Constants.ShareParameterSetName:
                    CheckContextForObjectInput((AzureStorageContext)this.Context);
                    fileToBeRemoved = this.ShareClient.GetRootDirectoryClient().GetFileClient(this.Path);
                    break;

                case Constants.DirectoryParameterSetName:
                    CheckContextForObjectInput((AzureStorageContext)this.Context);
                    fileToBeRemoved = this.ShareDirectoryClient.GetFileClient(this.Path);
                    break;

                default:
                    throw new PSArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid parameter set name: {0}", this.ParameterSetName));
            }

            this.RunTask(async taskId =>
            {
                if (this.ShouldProcess(Util.GetSnapshotQualifiedUri(fileToBeRemoved.Uri), "Remove file"))
                {
                    var responds =  await fileToBeRemoved.DeleteAsync(cancellationToken: this.CmdletCancellationToken).ConfigureAwait(false);
                    responds.Headers.TryGetValue("x-ms-link-count", out var linkCount);
                    if (linkCount != null)
                    {
                        OutputStream.WriteVerbose(taskId, string.Format(CultureInfo.CurrentCulture, "Deleted file {0} with link count {1}", Util.GetSnapshotQualifiedUri(fileToBeRemoved.Uri), linkCount));
                    }
                }

                if (this.PassThru)
                {
                    OutputStream.WriteObject(taskId, new AzureStorageFile(fileToBeRemoved, (AzureStorageContext)this.Context, clientOptions: ClientOptions));
                }
            });
        }
    }
}
