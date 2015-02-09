﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Security.Saml
{
    public static class IDictionaryExtensions
    {
        public static NameValueCollection ToNameValueCollection<TKey, TValue>(this IDictionary<TKey, TValue> value)
        {
            if (value == null) throw new ArgumentNullException("value");
            var nvc = new NameValueCollection(value.Count);
            foreach (var item in value)
                nvc.Add(item.Key.ToString(), item.Value.ToString());
            return nvc;
        }
    }
}
