/*
	This file is part of Tiny-JSON /L
		© 2023 LisiasT : http://lisias.net <support@lisias.net>
		© 2015-2018 Robert Gering : https://github.com/gering

	Tiny-JSON /L is licensed as follows:
		* MIT (Expat) : https://opensource.org/license/mit/

	Tiny-JSON /L is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

*/
namespace Tiny {
	public static class Json {
		public static T Decode<T>(this string json) {
			if (string.IsNullOrEmpty(json)) return default(T);
			object jsonObj = JsonParser.ParseValue(json);
			if (jsonObj == null) return default(T);
			return JsonMapper.DecodeJsonObject<T>(jsonObj);
		}
		
		public static string Encode(this object value, bool pretty = false) {
			JsonBuilder builder = new JsonBuilder(pretty);
			JsonMapper.EncodeValue(value, builder);
			return builder.ToString();
		}
	}
}

