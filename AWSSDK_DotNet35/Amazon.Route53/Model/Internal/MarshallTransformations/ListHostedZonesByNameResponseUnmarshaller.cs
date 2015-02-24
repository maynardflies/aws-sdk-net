/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListHostedZonesByName operation
    /// </summary>  
    public class ListHostedZonesByNameResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ListHostedZonesByNameResponse response = new ListHostedZonesByNameResponse();
            UnmarshallResult(context,response);
            
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, ListHostedZonesByNameResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
                   targetDepth += 1;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("HostedZones/HostedZone", targetDepth))
                    {
                        var unmarshaller = HostedZoneUnmarshaller.Instance;
                        response.HostedZones.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("DNSName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DNSName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HostedZoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.HostedZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        response.IsTruncated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextDNSName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NextDNSName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextHostedZoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NextHostedZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxItems", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.MaxItems = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
          
            return;
        }
  

        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidDomainName"))
            {
                return new InvalidDomainNameException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInput"))
            {
                return new InvalidInputException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonRoute53Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static ListHostedZonesByNameResponseUnmarshaller _instance = new ListHostedZonesByNameResponseUnmarshaller();        

        internal static ListHostedZonesByNameResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static ListHostedZonesByNameResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}