// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.WebRisk.V1Beta1.Snippets
{
    // [START webrisk_v1beta1_generated_WebRiskServiceV1Beta1_SearchUris_async]
    using Google.Cloud.WebRisk.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedWebRiskServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for SearchUrisAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task SearchUrisRequestObjectAsync()
        {
            // Create client
            WebRiskServiceV1Beta1Client webRiskServiceV1Beta1Client = await WebRiskServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            SearchUrisRequest request = new SearchUrisRequest
            {
                Uri = "",
                ThreatTypes =
                {
                    ThreatType.Unspecified,
                },
            };
            // Make the request
            SearchUrisResponse response = await webRiskServiceV1Beta1Client.SearchUrisAsync(request);
        }
    }
    // [END webrisk_v1beta1_generated_WebRiskServiceV1Beta1_SearchUris_async]
}
