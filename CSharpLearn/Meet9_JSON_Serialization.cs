using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGym
{
    internal class Meet9_JSON_Serialization
    {
        // לקחת מופע של קלאס שלם ולהפוך אותו לזיכרון ולהעביר אותו לרשת - ניתן לשמור נתונים בבסיס נתונים 
        // המרה מנתונים בקובץ ג'ייסון לקובץ טקסטואלי

        int a = 12;
        string b = "456";

        public void RunDe()
        {
            string j = @"{""id"": ""4EAF4717 - 357A - 4545 - 8905 - 44AB94A61D50"",
            ""title"": ""iopop"",
            ""schemaVersion"": ""1.0"",
            ""testVersion"": ""1.0"",
            ""previousVersionId"": ""none"",
            ""authorId"": ""alonf@zion-net.co.il"",
            ""description"": ""C# and JavaScript final test"",
            ""tags"": [
                ""C#"",
                ""JavaScript"",
                ""Final Test""
            ],
            ""questionsRefs"": [
                ""AEAF4717-357A-4545-8905-D4AB94A61D31"",
                ""AEAF4717-357A-4545-8905-D4AB94A61D34"",
                ""AEAF4717-357A-4545-8905-D4AB94A61D35"",
                ""AEAF4717-357A-4545-8905-D4AB94A61D36""
            ]
            }";

            // jSON ==> Class
            JsonSampleClass c = System.Text.Json.JsonSerializer.Deserialize<JsonSampleClass>(j);

            // JSON ==> String
            c.title = "This is new JSON";
            string newJ = System.Text.Json.JsonSerializer.Serialize<JsonSampleClass>(c);

            Dictionary<string, JsonSampleClass> dictionary = new Dictionary<string, JsonSampleClass>();
            dictionary.Add("123", c);
            dictionary.Add("456", c);
            dictionary.Add("789", c);
            dictionary.Add("78", c);

            newJ = System.Text.Json.JsonSerializer.Serialize<Dictionary<string, JsonSampleClass>>(dictionary);

            Dictionary<string, JsonSampleClass> dictionary2 = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, JsonSampleClass>>(newJ);
        }      
    }
}
