﻿using System;
namespace Day_7.Models
{
	public class ErrorViewModel
	{
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
