using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendGmailWithAttach
{
    class Logger
    {
        private Char fieldSeparator = ';';
        private String errorLogFileName;
        private String errorRecordFileName;

        public Logger(Char fieldSeparator, String errorLogFileName, String errorRecordFileName)
        {
            this.fieldSeparator = fieldSeparator;
            this.errorLogFileName = errorLogFileName;
            this.errorRecordFileName = errorRecordFileName;
        }

        public void Log(String field1, String field2, Exception ex)
        {
            CreateLogFilesWithCheck();
            LogException(ex);
            LogRecordWithError(field1,field2);
        }

        private void LogRecordWithError(String field1, String field2)
        {
            File.AppendAllText(this.errorRecordFileName, field1 + this.fieldSeparator + field2 + "\r\n");
        }

        private void LogException(Exception ex)
        {
            String timeStamp = "[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + "] ";
            String logLine = timeStamp + "Error message: " + ex.Message + "\r\nStack trace: " + ex.StackTrace + "\r\n";
            File.AppendAllText(this.errorLogFileName, logLine);
        }

        private void CreateLogFilesWithCheck()
        {
            if (!File.Exists(this.errorLogFileName))
            {
                CreateEmptyFile(this.errorLogFileName);
            }
            if (!File.Exists(this.errorRecordFileName))
            {
                CreateEmptyFile(this.errorRecordFileName);
            }
        }

        private void CreateEmptyFile(string filename)
        {
            File.Create(filename).Dispose();
        }
    }
}
