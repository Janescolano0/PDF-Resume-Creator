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
using PdfSharp.Pdf;
using PdfSharp.Drawing;


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
                var resume = CreateResume();

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

        private void btn__show_Click(object sender, EventArgs e)
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

        private Info CreateResume()
        {
            var resume = new Info
            {

                Name = "Joy Ann A. Escolano",
                Age = "Age: 19",
                Height = "Height: 5'4",
                Weight = "Weight: 123 lbs.",
                Language = "Language: English and Filipino",
                Religion = "Religion: Born-Again, Christian",
                Birthdate = "Date of Birth: June 10, 2003",
                Birthplace = "Place of Birth: Taguig City",
                Gender = "Gender: Female",
                Citizenship = "Citizenship: Filipino",
                Address = "Blk 33 Lot 40B-3 Sunflower St.,",
                Address2 = "Central Bicutan, Taguig City",
                Email = "joyann381@gmail.com",
                ContactNumber = "+639389501853",
                College = "Polytechnic University of the Philippines - Manila",
                CollegeSY = "2021-Present",
                Course = "Bachelor of Science in Computer Engineering",
                SeniorHighSchool = "Moreh Academy - Taguig",
                SeniorHighSchoolSY = "2019-2021",
                Strand = "Science, Techonology, Engineering, and Mathematics",
                JuniorHighSchool = "Maria Asuncion Rodriguez Tiñga Memorial High School",
                JuniorHighSchoolSY = "2015-2019",
                Elementary = "Upper Bicutan Elementary School",
                ElementarySY = "2009-2015",
                _Skills1 = "Computer Literate",
                _Skills2 = "Typing and Encoding",
                _Skills3 = "Communication",
                WorkExperience = "None",
            };

            return resume;
        }

        public class Info
        {
            public string Name { get; set; }
            public string Age { get; set; }
            public string Height { get; set; }
            public string Weight { get; set; }
            public string Language { get; set; }
            public string Religion { get; set; }
            public string Birthdate { get; set; }
            public string Birthplace { get; set; }
            public string Gender { get; set; }
            public string Citizenship { get; set; }
            public string Address { get; set; }
            public string Address2 { get; set; }
            public string Email { get; set; }
            public string ContactNumber { get; set; }
            public string College { get; set; }
            public string CollegeSY { get; set; }
            public string Course { get; set; }
            public string SeniorHighSchool { get; set; }
            public string SeniorHighSchoolSY { get; set; }
            public string Strand { get; set; }
            public string JuniorHighSchool { get; set; }
            public string JuniorHighSchoolSY { get; set; }
            public string Elementary { get; set; }
            public string ElementarySY { get; set; }
            public string WorkExperience { get; set; }
            public string _Skills1 { get; set; }
            public string _Skills2 { get; set; }
            public string _Skills3 { get; set; }
            
        }

        private void btn__generate2_Click(object sender, EventArgs e)
        {
            string JSONfile;
            using (var readJSON = new StreamReader(JSONpath))
            {
                JSONfile = readJSON.ReadToEnd();
            }
            var Resume = JsonConvert.DeserializeObject<Info>(JSONfile);

            //Name
            string Name = Resume.Name;

            //Contacts
            string Address = Resume.Address;
            string Address2 = Resume.Address2;
            string Email = Resume.Email;
            string ContactNumber = Resume.ContactNumber;
           
            //Personal Profile
            string Age = Resume.Age;
            string Height = Resume.Height;
            string Weight = Resume.Weight;
            string Language = Resume.Language;
            string Religion = Resume.Religion;
            string Birthdate = Resume.Birthdate;
            string Birthplace = Resume.Birthplace;
            string Gender = Resume.Gender;
            string Citizenship = Resume.Citizenship;

            //Educational History
            string College = Resume.College;
            string CollegeSY = Resume.CollegeSY;
            string Course = Resume.Course;
            string SeniorHighSchool = Resume.SeniorHighSchool;
            string SeniorHighSchoolSY = Resume.SeniorHighSchoolSY;
            string Strand = Resume.Strand;
            string JuniorHighSchool = Resume.JuniorHighSchool;
            string JuniorHighSchoolSY = Resume.JuniorHighSchoolSY;
            string Elementary = Resume.Elementary;
            string ElementarySY = Resume.ElementarySY;

            //Skills Summary
            string _Skills1 = Resume._Skills1;
            string _Skills2 = Resume._Skills2;
            string _Skills3 = Resume._Skills3;

            //Work Experience
            string WorkExperience = Resume.WorkExperience;

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.InitialDirectory = @"C:\Users\joy\source\repos\pdf creator\pdf";
                saveFile.FileName = Name + ".pdf";
                saveFile.Filter = "PDF|*.pdf";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = Name + " " + "Resume";
                    PdfPage page = pdf.AddPage();

                    XGraphics graphics = XGraphics.FromPdfPage(page);

                    XFont title_mediumsize = new XFont(" ", 19, XFontStyle.Bold);  
                    XFont info = new XFont(" ", 12, XFontStyle.Regular);
                    XFont FONTbig = new XFont(" ", 35, XFontStyle.Bold);

                    graphics.DrawRectangle(XBrushes.SaddleBrown, 13, 0, 190, 1000);
                    graphics.DrawRectangle(XBrushes.Goldenrod, 0, 25, 1000, 140);
                    

                    //Line
                    graphics.DrawRectangle(XBrushes.White, 0, 50, 1000, 3);

                    //Name
                    graphics.DrawString(Name, FONTbig, XBrushes.SaddleBrown, new XRect(230, 70, 0, 0 ), XStringFormats.TopLeft);

                    //Line
                    graphics.DrawRectangle(XBrushes.White, 0, 130, 1000, 3);

                    //Contacts
                    graphics.DrawString("Contacts", title_mediumsize, XBrushes.White, new XRect(25, 200, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Address, info, XBrushes.White, new XRect(30, 225, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Address2, info, XBrushes.White, new XRect(30, 240, 0, 0 ), XStringFormats.TopLeft);
                    graphics.DrawString(Email, info, XBrushes.White, new XRect(30, 255, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(ContactNumber, info, XBrushes.White, new XRect(30, 270, 0, 0), XStringFormats.TopLeft);

                    //Skills
                    graphics.DrawString("Skills Summary", title_mediumsize, XBrushes.White, new XRect(25, 320, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(_Skills1, info, XBrushes.White, new XRect(30, 345, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(_Skills2, info, XBrushes.White, new XRect(30, 360, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(_Skills3, info, XBrushes.White, new XRect(30, 375, 0, 0), XStringFormats.TopLeft);

                    //Personal Profile BG
                    graphics.DrawRectangle(XBrushes.Goldenrod, 230, 195, 360, 30);

                    //Personal Profile
                    graphics.DrawString("Personal Profile", title_mediumsize, XBrushes.SaddleBrown, new XRect(245, 200, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Age, info, XBrushes.Black, new XRect(245, 230,0 ,0), XStringFormats.TopLeft);
                    graphics.DrawString(Height, info, XBrushes.Black, new XRect(245, 245, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Weight, info, XBrushes.Black, new XRect(245, 260, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Language, info, XBrushes.Black, new XRect(245, 275, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Religion, info, XBrushes.Black, new XRect(245, 290, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Birthdate, info, XBrushes.Black, new XRect(245, 305, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Birthplace, info, XBrushes.Black, new XRect(245, 320, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Gender, info, XBrushes.Black, new XRect(245, 335, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Citizenship, info, XBrushes.Black, new XRect(245, 350, 0, 0), XStringFormats.TopLeft);

                    //Educational History BG
                    graphics.DrawRectangle(XBrushes.Goldenrod, 230, 380, 360, 30);

                    //Educational History
                    graphics.DrawString("Educational Profile", title_mediumsize, XBrushes.SaddleBrown, new XRect(245, 385, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(College, info, XBrushes.Black, new XRect(245, 415, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(CollegeSY, info, XBrushes.Black, new XRect(245, 430, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Course, info, XBrushes.Black, new XRect(245, 445, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(SeniorHighSchool, info, XBrushes.Black, new XRect(245, 475, 0, 0), XStringFormats.TopLeft); 
                    graphics.DrawString(SeniorHighSchoolSY, info, XBrushes.Black, new XRect(245, 490, 0, 0), XStringFormats.TopLeft); 
                    graphics.DrawString(Strand, info, XBrushes.Black, new XRect(245, 505, 0, 0), XStringFormats.TopLeft); 
                    graphics.DrawString(JuniorHighSchool, info, XBrushes.Black, new XRect(245, 535, 0, 0), XStringFormats.TopLeft); 
                    graphics.DrawString(JuniorHighSchoolSY, info, XBrushes.Black, new XRect(245, 550, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(Elementary, info, XBrushes.Black, new XRect(245, 580, 0, 0), XStringFormats.TopLeft); 
                    graphics.DrawString(ElementarySY, info, XBrushes.Black, new XRect(245, 595, 0, 0), XStringFormats.TopLeft);


                    //Work Experience BG
                    graphics.DrawRectangle(XBrushes.Goldenrod, 230, 625, 360, 30);

                    //Work Experience
                    graphics.DrawString("Work Experience", title_mediumsize, XBrushes.SaddleBrown, new XRect(245, 630, 0, 0), XStringFormats.TopLeft);
                    graphics.DrawString(WorkExperience, info, XBrushes.Black, new XRect(245, 660, 0, 0), XStringFormats.TopLeft);



                    pdf.Save(saveFile.FileName);
                    MessageBox.Show("Generating...");
                    MessageBox.Show("PDF file generated");
                    this.Close();

                }
            }
        }
    }
}
