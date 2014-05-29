﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReliableIM.Network.Protocol.SSL.Listener
{
    public interface SslAuthenticationListener
    {

        /// <summary>
        /// Authenticates a remote party in the SSL authentication mechanism.
        /// </summary>
        /// <param name="certificate">X.509 Certificate to verify.</param>
        /// <param name="chain">X.509 Chain the certificate is part of.</param>
        /// <param name="policyErrors">SSL policy errors discovered with the input certificate and chain.</param>
        /// <returns>True if the authentication should continue, false otherwise.</returns>
        bool Authenticate(X509Certificate certificate, X509Chain chain, SslPolicyErrors policyErrors);

    }
}
