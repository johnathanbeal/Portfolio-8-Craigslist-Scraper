using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CraigslistScraper.SMTP;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace CraigslistScraper
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task<string> FunctionHandler()
        {
            Email email = new Email();
            await email.SendEmail();
            return "The smtp server was changed to protonmail";
        }
    }
}
