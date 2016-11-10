using System;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
		{
			if(string.IsNullOrEmpty(input))
			{
				return string.Empty;
			}

			var charArray = input.ToCharArray();
			Array.Reverse(charArray);

			return new string(charArray);
		}
	}
}
