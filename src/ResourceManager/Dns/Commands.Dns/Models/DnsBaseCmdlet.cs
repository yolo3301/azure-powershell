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

using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Dns.Models
{
    public abstract class DnsBaseCmdlet : AzureRMCmdlet
    {
        private DnsClient dnsClient;

        public DnsClient DnsClient
        {
            get
            {
                if (dnsClient == null)
                {
                    dnsClient = new DnsClient(DefaultContext);
                }
                return dnsClient;
            }

            set { dnsClient = value; }
        }

        /// <summary>
        /// Added for tests only, should be removed in the future.
        /// </summary>
        public void ExecuteCmdlet()
        {
            ProcessRecord();
        }
    }
}
