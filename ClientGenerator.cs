﻿using NSwag;
using NSwag.CodeGeneration.CSharp;

namespace SwaggerApiClientLab2
{
    public class ClientGenerator
    {
        public async Task GenerateClient()
        {
            using var httpClient = new HttpClient();
            var swaggerJson = await httpClient.GetStringAsync("http://localhost:5000/swagger/v1/swagger.json");
            var document = await OpenApiDocument.FromJsonAsync(swaggerJson);

            var settings = new CSharpClientGeneratorSettings
            {
                ClassName = "GeneratedApiClient",
                CSharpGeneratorSettings = { Namespace = "MyApiClientNamespace" }
            };

            var generator = new CSharpClientGenerator(document, settings);
            var code = generator.GenerateFile();

            //const string outputDirectory = "../../../";
            //const string outputFileName = "GeneratedApiClient.cs";

            //var outputPath = Path.Combine(outputDirectory, outputFileName);

            await File.WriteAllTextAsync("GeneratedApiClient.cs", code);
        }
    }
}
