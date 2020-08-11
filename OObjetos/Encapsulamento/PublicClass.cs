using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class PublicClass
    {
        public int PublicProprety { get; set; }

        private int PrivateProprety { get; set; }

        protected int ProtectedProprety { get; set; }

        internal int InternalProprety { get; set; }

        protected internal int ProtectedInternalProprety { get; set; }

        private protected int PrivateProtectedProprety { get; set; }

    }
}
