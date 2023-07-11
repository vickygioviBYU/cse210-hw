using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commons.Music.Midi;

namespace FinalProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var access = MidiAccessManager.Default;
            var output = access.OpenOutputAsync(access.Outputs.First().Id).Result;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Facade fc = new Facade(output);

            fc.AddBeat(1000, 4000);
            fc.AddBeat(2000, 8000);

            int pitchNote1Beat1 = 60;

            byte[] bytesNote1Beat1 = BitConverter.GetBytes(pitchNote1Beat1);
            byte byteNote1Beat1 = bytesNote1Beat1[0];

            fc.AddNote(byteNote1Beat1, 2, 1000, 1);

            int pitchNote2Beat1 = 62;

            byte[] bytesNote2Beat1 = BitConverter.GetBytes(pitchNote2Beat1);
            byte byteNote2Beat1 = bytesNote2Beat1[0];

            fc.AddNote(byteNote2Beat1, 1, 2000, 1);

            //-----------------------

            int pitchNote1Beat2 = 64;

            byte[] bytesNote1Beat2 = BitConverter.GetBytes(pitchNote1Beat2);
            byte byteNote1Beat2 = bytesNote1Beat2[0];

            fc.AddNote(byteNote1Beat2, 2, 500, 2);

            int pitchNote2Beat2 = 65;

            byte[] bytesNote2Beat2 = BitConverter.GetBytes(pitchNote2Beat2);
            byte bytepitchNote2Beat2 = bytesNote2Beat2[0];

            fc.AddNote(bytepitchNote2Beat2, 3, 1500, 2);

            

            Application.Run(new ProgramUI(fc));

            output.CloseAsync();
        }
    }
}
