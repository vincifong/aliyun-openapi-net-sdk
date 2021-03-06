/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.industry_brain.Transform;
using Aliyun.Acs.industry_brain.Transform.V20180712;
using System.Collections.Generic;

namespace Aliyun.Acs.industry_brain.Model.V20180712
{
    public class InvokeServiceRequest : RpcAcsRequest<InvokeServiceResponse>
    {
        public InvokeServiceRequest()
            : base("industry_brain", "2018-07-12", "InvokeService")
        {
			Method = MethodType.POST;
        }

		private string requestParams;

		private string serviceId;

		private string requestData;

		private bool? showParams;

		public string RequestParams
		{
			get
			{
				return requestParams;
			}
			set	
			{
				requestParams = value;
				DictionaryUtil.Add(QueryParameters, "RequestParams", value);
			}
		}

		public string ServiceId
		{
			get
			{
				return serviceId;
			}
			set	
			{
				serviceId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceId", value);
			}
		}

		public string RequestData
		{
			get
			{
				return requestData;
			}
			set	
			{
				requestData = value;
				DictionaryUtil.Add(QueryParameters, "RequestData", value);
			}
		}

		public bool? ShowParams
		{
			get
			{
				return showParams;
			}
			set	
			{
				showParams = value;
				DictionaryUtil.Add(QueryParameters, "ShowParams", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InvokeServiceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return InvokeServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}