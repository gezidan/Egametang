﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;

namespace Helper
{
	public static class MongoHelper
	{
		public static string ToJson(object obj)
		{
			return obj.ToJson();
		}

		public static string ToJson(object obj, JsonWriterSettings settings)
		{
			return obj.ToJson(settings);
		}

		public static T FromJson<T>(string str)
		{
			return BsonSerializer.Deserialize<T>(str);
		}

		public static byte[] ToBson(object obj)
		{
			return obj.ToBson();
		}

		public static T FromBson<T>(byte[] bytes)
		{
			return BsonSerializer.Deserialize<T>(bytes);
		}

		public static object FromBson(byte[] bytes, Type type)
		{
			return BsonSerializer.Deserialize(bytes, type);
		}
	}
}