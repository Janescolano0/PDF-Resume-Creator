using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace pdf_creator
{
    public partial class PDFandJSONcreator : Form
    {
        private readonly string JSONpath = @"C:\Users\joy\source\repos\pdf creator\json\info.JSON";

        public PDFandJSONcreator()
        {
            InitializeComponent();
        }

        private void btn__generate_Click(object sender, EventArgs e)
        {
            try
            {
                string JSONfile;
                using (var readJSON = new StreamReader(JSONpath))
                {
                    JSONfile = readJSON.ReadToEnd();
                }

                tbox__show.Text = JSONfile;

                var JSONdeserialize = JsonConvert.DeserializeObject<Info>(JSONfile);
            }

            catch (Exception)
            {
                // ignored
            }

        }

        private void btn__show_Click(object sender, EventArgs e)
        {
            try
            {
                var resume = GetResume();

                var JSONSerialize = JsonConvert.SerializeObject(resume, Formatting.Indented);

                using (var writeJSON = new StreamWriter(JSONpath))
                {
                    writeJSON.Write(JSONSerialize);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public class Info
        {
            public string Name { get; set; }
            public string Height { get; set; }
            public string Weight { get; set; }
            public string Language { get; set; }
            public string Religion { get; set; }
            public string Birthdate { get; set; }
            public string Birthplace { get; set; }
            public string Gender { get; set; }
            public string Citizenship { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string ContactNumber { get; set; }
            public string College { get; set; }
            public string Course { get; set; }
            public string SeniorHighSchool { get; set; }
            public string Strand { get; set; }
            public string JuniorHighSchool { get; set; }
            public string Elementary { get; set; }
            public string WorkExperience { get; set; }
            public string _Skills1 { get; set; }
            public string _Skills2 { get; set; }
            public string _Skills3 { get; set; }
            
        }
    }
}
