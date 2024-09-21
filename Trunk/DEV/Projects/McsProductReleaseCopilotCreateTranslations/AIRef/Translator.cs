using Azure;
using Azure.AI.OpenAI;
using OpenAI;
using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AIRef
{
    public class Translator
    {
        public static string Translate(string fromLang, string name, string desc, string toLangs, string endpoint, string key, string deployment)
        {
            //string toTranslate = string.Format("translate \"{0}\" and \"{1}\" to {2}. Return the translations as JSON.", name, desc, toLang);
            //string toTranslate = string.Format("translate \"{0}\" and \"{1}\" to {2}.  Return only the languageid and translations | delimited.", name, desc, toLangs);
            string toTranslate = string.Format("translate \"{0}\" as Name and \"{1}\" as Description to {2}. Return languageid|name|description.", name, desc, toLangs);

            AzureKeyCredential credential = new AzureKeyCredential(key);
            AzureOpenAIClient azureClient = new AzureOpenAIClient(new Uri(endpoint), credential);
            ChatClient chatClient = azureClient.GetChatClient(deployment);

            //ChatCompletionOptions opt = new ChatCompletionOptions()
            //{
            //    Temperature = (float)0.7,
            //    MaxTokens = 800,
            //    FrequencyPenalty = 0,
            //    PresencePenalty = 0,
            //};

            UserChatMessage m = new UserChatMessage(toTranslate);
            var messages = new ChatMessage[] { m };
            ChatCompletion completion = chatClient.CompleteChat(messages);
            return completion.ToString();
        }

    }
}
