using DiscordWebHook.Library;
using DiscordWebHook.Library.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiscordWebHook.Client
{
    public partial class FrmMain : Form
    {
        private readonly string serverURL = @"server webhook url";
        private readonly string imageURL = @"link to image";
        private readonly string avatarURL = @"link to avatar";
        private readonly string authorIconURL = @"link to icon";
        private readonly string authorURL = @"author url";
        private readonly string messageURL = @"message url";
        private readonly string fileName = @"path to file";

        WebHookClient client;
        WebHookMessage message;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            PostMessage();
            PostFile();
        }

        // Post message example
        public async void PostMessage()
        {
            message = new WebHookMessage
            {
                UserName = "User Name",
                AvatarURL = avatarURL,
                Content = "**Content text.**",
                Embeds = new List<Embed>
                {
                    new Embed
                    {
                        Color = 15258703,
                        Author = new Author { Name = "Author", URL = authorURL , IconURL = authorIconURL },
                        Title = "Title of message.",
                        URL = messageURL,
                        Description = "Description of message.",
                        Fields = new List<Field>
                        {
                            new Field { Name = "Name1", Value = "Value1", Inline = true },
                            new Field { Name = "Name2", Value = "Value2", Inline = true },
                            new Field { Name = "Name3", Value = "Value3", Inline = true },
                            new Field { Name = "Name4", Value = "Value4", Inline = true },
                        },
                        Image = new Library.Models.Image { URL = imageURL },
                        Thumbnail = new Thumbnail { URL = imageURL },
                        Footer = new Footer { Text = "Footer text.", IconURL = authorIconURL },
                        Timestamp = WebHookClient.DateTimeToISO8601(2020, 1, 1, 10, 15, 20)
                    }
                },
                TTS = false
            };

            client = new WebHookClient(serverURL);
            // client.WebHookURL = URL;

            int code = await client.PostMessage(message);

            lblStatusCode.Text = code.ToString();
        }

        // Post file with some payload example
        public async void PostFile()
        {
            message = new WebHookMessage
            {
                UserName = "User Name",
                AvatarURL = avatarURL,
                Content = "**Content text.**",
                TTS = false
            };

            client = new WebHookClient(serverURL);

            int code = await client.PostFile(fileName, message);

            lblStatusCode.Text = code.ToString();
        }
    }
}
