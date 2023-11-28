// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.Email
{
    /// <summary> Content of the email. </summary>
    public partial class EmailContent
    {
        /// <summary> Initializes a new instance of <see cref="EmailContent"/>. </summary>
        /// <param name="subject"> Subject of the email message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subject"/> is null. </exception>
        public EmailContent(string subject)
        {
            Argument.AssertNotNull(subject, nameof(subject));

            Subject = subject;
        }

        /// <summary> Subject of the email message. </summary>
        public string Subject { get; }
        /// <summary> Plain text version of the email message. </summary>
        public string PlainText { get; set; }
        /// <summary> Html version of the email message. </summary>
        public string Html { get; set; }
    }
}
