﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace LibraryGenerator
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				OpenApiDocument openapi = LoadApiSpecification(typeof(Program).Namespace + ".Properties.openapi.json");

				CodeGenerator generator = new CodeGenerator(openapi);
				generator.GenerateEntities(writeFiles: true);
				generator.GenerateClient(writeFiles: true);
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
