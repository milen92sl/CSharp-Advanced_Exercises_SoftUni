﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private readonly T left;
        private readonly T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            return left.Equals(right);
        }
    }

        
}
