using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pdf_creator
{
    public partial class PDFandJSONcreator : Form
    {
        private readonly string json_filepath = @"C:\Users\joy\source\repos\pdf creator\json\info.JSON";

        public PDFandJSONcreator()
        {
            InitializeComponent();
        }

        private void btn__generate_Click(object sender, EventArgs e)
        {

           
        }

        private void btn__show_Click(object sender, EventArgs e)
        {
           
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
