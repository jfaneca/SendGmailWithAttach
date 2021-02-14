# SendGmailWithAttach
The code uses a csv file (really comma separated fields) for sending an email with one attached file using a gmail email account.

The first field is the email address, the second is the file name to be used as email attachment.

## Notes
In order to allow your gmail account to be used by this app, you need to go to your gmail account, option "Manage your Google account" / "Security" and you need to turn ON "less secure app" feature

In order to make it easier getting a list of files from your file system, you can use the command: dir /b /a-d > filelist.txt

## Change log

v 0.4 2021-02-14 : changes at the log file name, in order to support spanish date format + timer increase

v 0.3 2021-02-12 : added support for error handling, supporting a file containing records not sent

v 0.2 2021-02-10 : added support for "," or ";" field separator and trim values at email address values
