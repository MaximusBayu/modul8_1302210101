using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_1302210101
{
    internal class BankTransferConfig
    {
        public class set
        {
            public string lang { get; set; }
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
            public string methods { get; set; }
            public string en { get; set; }
            public string id { get; set; }


            public set(string lang, int threshold, int low_fee, int high_fee, string methods, string en, string id)
            {
                this.lang = lang;
                this.threshold = threshold;
                this.low_fee = low_fee;
                this.high_fee = high_fee;
                this.methods = methods;
                this.en = en;
                this.id = id;
            }

            public class readWrite
            {
                public set config;
                public const string txt = @"./BankTransferConfig.json";

                private void SetDefault()
                {
                    config = new set("en", 25000000, 6500, 15000, "RTO", "yes", "ya");
                }

                private void NewConfigFile()
                {
                    JsonSerializerOptions baru = new JsonSerializerOptions()
                    {
                        WriteIndented = true
                    };

                    string jsonString = JsonSerializer.Serialize(config, baru);
                    File.WriteAllText(txt, jsonString);
                }

                private set ReadConfigFile()
                {
                    string readJSON = File.ReadAllText(txt);
                    config = JsonSerializer.Deserialize<set>(readJSON);
                    return config;
                }

                public readWrite()
                {
                    try
                    {
                        ReadConfigFile();
                    }
                    catch (Exception)
                    {
                        SetDefault();
                        NewConfigFile();
                    }
                }

                public void pilihM(int i)
                {
                    if (i == 1)
                    {
                        config.methods = "RTO(real-time)";
                    }
                    else if (i == 2)
                    {
                        config.methods = "SKN";
                    }
                    else if (i == 3)
                    {
                        config.methods = "RTGS";
                    }
                    else if (i == 4)
                    {
                        config.methods = "BI FAST";
                    }
                }

                public void Ubahlang()
                {
                    if (config.lang == "en")
                    {
                        config.lang = "id";
                        NewConfigFile();
                    }
                    else
                    {
                        config.lang = "en";
                        NewConfigFile();
                    }
                }

            }
        }
    }
}
