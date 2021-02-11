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
