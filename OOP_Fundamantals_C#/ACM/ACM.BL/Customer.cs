﻿using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            CustomerAddresses = new List<Address>();
        }

        public List<Address> CustomerAddresses { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public override string ToString() => FullName;

        public override bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            
            return isValid;
        }

        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        
    }
}
