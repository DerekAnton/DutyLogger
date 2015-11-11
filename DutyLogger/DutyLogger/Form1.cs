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


namespace DutyLogger
{
    public partial class Form1 : Form
    {
        private string saveDirectory, selectedDirectory;
        private bool noDumpStored;
        string[] Sorority, Harris, FiveHundreds;


        public Form1()
        {
            InitializeComponent();
            saveDirectory = "C:\\Users\\Public\\DutyLogger\\";
            Directory.CreateDirectory(saveDirectory);


            if (File.Exists(saveDirectory + "SavedDirectory.dump"))
            {
                selectedDirectory = File.ReadAllText(saveDirectory + "SavedDirectory.dump");
                noDumpStored = false;
            }
            else
            {
                noDumpStored = true;
                selectedDirectory = saveDirectory;
            }



            Sorority = new string[] //23
            {
                "There was no disturbance in the three houses.",
                "All the sorority houses were quite.",
                "Had a conversation with one of the residents.  All was quiet in the other houses",
                "Had conversations with multiple residents.",
                "Talked with a few of the girls in each of the houses.  Everyone was quiet.",
                "There were only a few residents in the houses.  All was quiet in the remaining houses.",
                "The RAs on duty had a conversation with a resident about family she was going to see this weekend.",
                "Had a quick conversation with one of the residents.  All was quiet in the other houses.",
                "The RAs had a conversation with two girls studying in their common area.  All was quiet in the other houses.",
                "Saw the same two girls studying.  All was quiet in the other houses.",
                "There were two residents talking in one of the lounges.  They did not see any residents in the other buildings.",
                "Had a conversation with a group of girls hanging out in the lounge.",
                "Some girls were talking in the lounge.  They did not see any other residents in the other buildings.",
                "The buildings were mostly quiet.  There were a few girls talking that the RAs had quick conversations with.",
                "There were a few residents talking in the lounge eating popcorn of castle and some residents in manor were watching a movie in the lounge.",
                "There were a bunch of residents hanging out together on the first floor of the castle.  All of the other buildings were quiet.",
                "There were a group of residents studying in the common area of castle.  The other two buildings were both quiet.",
                "There were a few girls talking in the common area of the castle.  The other buildings were all quiet.",
                "RA Alexis had a conversation with a resident sitting on the first floor.  All other buildings were quiet.",
                "Two girls were studying together in manor.  There were no other noticeable residents in the other buildings and all was quiet.",
                "There were a few girls talking in the common area in the castle.  All was quiet in the other buildings.",
                "Alexis had a conversation with one of the residents.  The girls in the castle were still talking in the common area.",
                "All was quiet in the houses."
            };

            Harris = new string[] //25
            {
                "The RAs on duty reported to a lockout on the fourth floor.",
                "Had a conversation with the security guard.",
                "Did not see any other residents in the halls.",
                "Had a quick conversation with a few residents walking through the hall.",
                "Had a conversation with three residents who had just gotten back from the store.  Residents were all quiet throughout the building.",
                "Residents in their rooms were all quiet.",
                "Had a quick conversation with residents walking to their room.  They did not pass any other residents though out the building.",
                "The RA’s on duty had a quick conversation with Resident Kent before leaving the building.",
                "Had conversations with multiple residents about how their days were going, their classes, and upcoming campus events.",
                "All residents were in their rooms and quiet.  Had a quick conversation with the security guard.",
                "Had conversations with multiple residents about how their days were.",
                "The RAs on duty had a quick conversation with two of the residents.  There were also two residents studying in the lounge.  All was quiet on the other floors.",
                "Passed a resident on the second floor and had a quick conversation with them before wishing them a good night.",
                "Had a conversation with a resident about how his week was.  They did not see other residents on any of the other floors.",
                "The RAs passed two residents coming back from getting Moes.  They had a quick conversation about their food options.",
                "The RAs had a few conversations with residents coming back from Moes.  All was quiet on the other floors.",
                "The RAs on duty had a conversation with a resident coming back from shopping.  All of the other floors were quiet.",
                "There were a few residents walking throughout the building.",
                "The RAs on duty passed two girls walking back to their room.  All was quiet on the other floors.",
                "The RAs on duty saw multiple residents studying in the second floor longue.  They also talked to a resident doing his laundry.",
                "There was some noise on the first floor but the RAs on duty did not see any residents.  There were also seven residents in the second floor study room.",
                "All residents appeared to be in their rooms.  There was not any noise in the halls.",
                "The RAs on duty had a conversation with the security guard about the building.  They also saw a resident doing their laundry.",
                "The RAs on duty reported to a lockout on the third floor.  They also talked to a resident about his day.",
                "We spoke to a few residents returning to their rooms.  There were only light conversations that could be heard in the halls"
            };

            FiveHundreds = new string[] //27
            {
                "Talked to the residents on the second floor of 501 about classes. The remaining buildings were quiet.",
                "Outside of 507 the RAs on duty had a quick conversation with a resident as he was walking into the building.",
                "All buildings were quiet after the RAs on duty responded to the lock out on the second floor of 505.",
                "The RAs on duty had a conversation with Resident Joe about his family. All else was quiet in the other buildings.",
                "The RAs on duty had a conversation with 505 residents Sherman, Seion, Eric, and Dan. All other buildings were quiet.",
                "Had a quick conversation with Seever.  All was quiet in the other buildings.",
                "The RAs on duty had a conversation with Resident Xianying and Hnin about a movie they were watching.  All was quiet in the other buildings.",
                "All was quiet in each building.",
                "Had a conversation with two residents about how their days were going.",
                "All residents were in their rooms and quiet.",
                "Had a quick conversation with one of the residents about a movie they were watching before they went to sleep.",
                "Had a conversation with Resident Cindy and Resident Suki.  All was quiet in the other buildings.",
                "Had a conversation with a resident doing her laundry and also a resident in the longue.",
                "All was quiet in each of the houses.  All residents appeared to be in their rooms.",
                "The RAs on duty talked to two residents who were watching a movie.  They also had a conversation with a resident who was going how to celebrate her dad’s birthday.",
                "Talked to a resident about how his classes were this week and how his day was going.",
                "Had a quick conversation with a resident.  All was quiet in the other buildings.",
                "The RAs on duty did not see any residents.  All was quiet throughout the buildings.",
                "The RAs on duty saw a couple of residents hanging out in the lounge talking to each other.  All was quiet in the other buildings.",
                "A few of the residents were talking in the longue.  Had a quick conversation with a resident doing laundry.",
                "All residents seemed to be in their rooms.  The RAs on duty could hear a few quiet conversations in resident’s rooms.",
                "There were 2 residents walking back from dinner and a couple of residents talking in the longue.",
                "The RAs had a quick conversation with a resident walking back into 505.  There was little noise in the other buildings.",
                "There were a few conversations happening in resident’s rooms, but no one was in the halls.",
                "Talked to the residents on the second floor of 501 about her weekend.  The remaining buildings were quiet.",
                "Talked to resident Sherman in 507. All was quiet in the rest of the buildings.",
                "Outside of 507 the RAs on duty had a quick conversation with a resident as he was walking into the building."
            };
        }

        //Make Log button
        private void button1_Click(object sender, EventArgs e)
        {
            // 4 rounds, 1 of each
            string fileToBeWritten = "";
            Random rnd = new Random(); //  needs to be declared out of the loop because of how the seed works w/ system time.
            int ticks;

            for ( int counter = 0; counter < 4; counter++)
            {
                string creturn = "\r\n";

                fileToBeWritten += "Round " + (counter + 1) + creturn ;

                ticks = rnd.Next(0, 24);
                fileToBeWritten += "Harris: " + Harris[ticks]  + creturn;

                ticks = rnd.Next(0, 26);
                fileToBeWritten += "500's: " + FiveHundreds[ticks] + creturn;

                ticks = rnd.Next(0, 22);
                fileToBeWritten += "Sorority's: " + Sorority[ticks] + creturn;

                fileToBeWritten += creturn;
            }
            if (!noDumpStored)
            {
                string fileNameAndPath = selectedDirectory + "ConvertedFile.txt";
                File.WriteAllText(selectedDirectory + "ConvertedFile.txt", fileToBeWritten);
                DialogResult popupResult = MessageBox.Show("Conversion Success! saved to " + selectedDirectory);
                if (popupResult == DialogResult.OK)
                    System.Diagnostics.Process.Start(fileNameAndPath);

            }
            else
            {
                string fileNameAndPath = saveDirectory + "ConvertedFile.txt";
                File.WriteAllText(fileNameAndPath, fileToBeWritten);

                DialogResult popupResult = MessageBox.Show("Conversion Success! saved to " + saveDirectory);
                if(popupResult == DialogResult.OK)
                    System.Diagnostics.Process.Start(fileNameAndPath);
            }
        }

        //Default reset button
        private void button2_Click(object sender, EventArgs e)
        {
            string directory = "";
            DialogResult popupResult = MessageBox.Show("Please select a default folder to convert into.", "Alert", MessageBoxButtons.OK);

            if (popupResult == DialogResult.OK)
            {
                var fD = new FolderBrowserDialog();

                if (fD.ShowDialog() == DialogResult.OK)
                {
                    directory = fD.SelectedPath + "\\";
                    File.WriteAllText(saveDirectory + "SavedDirectory.dump", directory);
                    if (directory == "" || directory == null)
                    {
                        selectedDirectory = directory;// Save to default directory 
                    }
                }
                else
                {
                    selectedDirectory = saveDirectory; // Save to default directory 
                }
            }
        }
    }
}
