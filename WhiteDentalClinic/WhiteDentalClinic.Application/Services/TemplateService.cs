﻿using System.Reflection;
using WhiteDentalClinic.Application.Services.Interfaces;

namespace WhiteDentalClinic.Application.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly string _templatesPath;
        public TemplateService()
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            var templatePath = Assembly.GetExecutingAssembly().GetName().Name;

            _templatesPath = Path.Combine(projectPath, templatePath);
        }
        public async Task<string> GetTemplateAsync(string templateName)
        {
            using var reader = new StreamReader(Path.Combine(_templatesPath, templateName));
            return await reader.ReadToEndAsync();
        }

        public string ReplaceInTemplate(string input, IDictionary<string, string> replaceWords)
        {
            var response = string.Empty;

            foreach(var temp in replaceWords)
            {
                response = input.Replace(temp.Key, temp.Value);
            }
            return response;
        }
    }
}
