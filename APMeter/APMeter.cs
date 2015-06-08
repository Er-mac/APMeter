using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace APMeter
{
    public class APMeter
    {
        private const string GotApPattern = @"Получено очков Бездны: ([\d\s]+).\s*$";
        private const string ChatLogFileName = "Chat.log";

        private string ChatLogFullPath { get; set; }

        //Constructor
        public APMeter(string pathToGame)
        {
            this.ChatLogFullPath = String.Concat(pathToGame, "\\", APMeter.ChatLogFileName);
        }

        /// <summary>
        /// Count Abyss Points from Chat.log file
        /// </summary>
        public int CountAp()
        {
            if (!File.Exists(this.ChatLogFullPath))
                return -1;

            var lines = File.ReadAllLines(this.ChatLogFullPath, Encoding.Default);

            int count = 0;
            foreach (string line in lines)
            {
                var match = Regex.Match(line, APMeter.GotApPattern);
                if (match.Success)
                {
                    int tempCount = 0;
                    string strValue = match.Groups[1].Value;
                    // remove simply spaces (symbol code 0x20, 32)
                    strValue = strValue.Replace(" ", String.Empty);
                    // remove spaces copied from Chat.log (symbol code 0xA0, 160)
                    strValue = strValue.Replace(" ", String.Empty);

                    Int32.TryParse(strValue, out tempCount);

                    count += tempCount;
                }
            }

            return count;
        }

        /// <summary>
        /// Clear Chat.log file
        /// </summary>
        public void ClearLog()
        {
            if (File.Exists(this.ChatLogFullPath))
            {
                File.WriteAllText(this.ChatLogFullPath, String.Empty);
            }
        }

    }
}
