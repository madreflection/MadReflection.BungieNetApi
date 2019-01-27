using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace LibraryGenerator
{
	public static class Program
	{
		private const string OpenApiJsonFile = @"submodules\bnetapi\openapi.json";

		public static readonly Dictionary<string, TypeBuilder> GeneratedTypes = new Dictionary<string, TypeBuilder>();


		public static void Main(string[] args)
		{
			try
			{
				string resourceName = typeof(Program).Namespace + ".Properties.openapi.json";
				OpenApiDocument openapi = LoadApiSpecification(resourceName);

				EntitiesGenerator.GenerateEntities(openapi, true);

				ClientGenerator.GenerateClient(openapi, true);
			}
			catch (Exception exception)
			{
				Console.Error.WriteLine(exception.Message + Environment.NewLine + exception.StackTrace);
			}
		}

		private static OpenApiDocument LoadApiSpecification(string name)
		{
			using (Stream stream = typeof(Program).Assembly.GetManifestResourceStream(name))
			{
				return new OpenApiStreamReader().Read(stream);
			}
		}
	}
}
