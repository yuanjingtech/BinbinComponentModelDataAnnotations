using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Binbin.ComponentModel.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CollectionHasAtLeastOneElementAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (null == value)
            {
                return false;
            }
            var array = value as Array;
            if (array != null)
            {
                return array.Length > 0;
            }
            var collection = value as ICollection;
            if (collection != null)
            {
                return collection.Count > 0;
            }
            return false;
        }
    }
}