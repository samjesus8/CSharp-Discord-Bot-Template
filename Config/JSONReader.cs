using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotTemplate.Config
{
    internal class JSONReader
    {
        public string token { get; set; }
        public string prefix { get; set; }

        public async Task ReadJSON() 
        {
            // PLEASE NOTE that you have to copy your "config.json" file (with your token & prefix) over to
            // the /bin/Debug folder of your solution, else this won't work

            // In the config.json file, there is an example of how the file should look before you copy it over
            // The token in that file is one that cannot be used, it is just there as an example

            using (StreamReader sr = new StreamReader("config.json", new UTF8Encoding(false)))
            {
                string json = await sr.ReadToEndAsync(); //Reading whole file
                ConfigJSON obj = JsonConvert.DeserializeObject<ConfigJSON>(json); //Deserialising file into the ConfigJSON structure

                this.token = obj.Token; //Setting our token & prefix that we extracted from our file
                this.prefix = obj.Prefix;
            }
        }
    }
}
