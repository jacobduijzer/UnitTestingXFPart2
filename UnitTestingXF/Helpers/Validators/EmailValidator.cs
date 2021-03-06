﻿using System;
using System.Text.RegularExpressions;

namespace UnitTestingXF.Helpers
{
    public static class EmailValidator
    {
		private const string emailRegexString = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
			@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

		private static readonly Regex emailRegex = new Regex(emailRegexString, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

		public static bool IsValidEmail(string email)
		{
			return !string.IsNullOrWhiteSpace(email) && emailRegex.Match(email).Success;
		}
    }
}
