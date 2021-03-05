﻿using System;

 namespace CodeReadability
{
    public class OptionHasNoItemException:Exception
    {
        public OptionHasNoItemException(string message) : base(message)
        {
            
        }
    }
}